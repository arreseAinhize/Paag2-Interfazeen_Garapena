using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Resources;
using WineShop.Models;
using WineShop.Services;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    public class SaskiaController : Controller
    {
        //Kontroladorak erabiliko dituen zerbituzak definitu
        private readonly ISaskiaService _saskiaService;
        private readonly IArdoaService _ardoaService;
        public SaskiaController(ISaskiaService saskiaService, IArdoaService ardoaService)
        {
            _saskiaService = saskiaService;
            _ardoaService = ardoaService;
        }

        // Kontroladorearen ekintzak
        /*public async Task<IActionResult> Index()
        {
            return View(); // momentuz bista hutsa sortuko dugu (empty txantiloia)
        }*/

        // Index ekintza eguneratu kontroladorean 
        public async Task<IActionResult> Index(string id)
        {
            var saskiaAleaList = await _saskiaService.SaskiaLortuAleak(id);
            var saskiaAleaVMList = new List<SaskiaAleaViewModel>();
            decimal guztira = 0; // Saskiaren totala
            foreach (var saskiaAlea in saskiaAleaList)
            {
                var ardoa = await _ardoaService.GetArdoa(saskiaAlea.ArdoaId);
                var saskiaAleaViewModel = new SaskiaAleaViewModel()
                {
                    ArdoaId = ardoa.Id,
                    Irudia = ardoa.Irudia,
                    Izena = ardoa.Izena,
                    Kantitatea = saskiaAlea.Kantitatea,
                    Salneurria = ardoa.Salneurria
                };
                saskiaAleaVMList.Add(saskiaAleaViewModel);
                // Totala gehitu
                guztira += saskiaAlea.Kantitatea * ardoa.Salneurria;
            }
            // ViewModela sortu bistarako
            var saskiaViewModel = new SaskiaViewModel()
            {
                SaskiaAleaVMList = saskiaAleaVMList,
                Guztira = guztira // <-- aquí incluimos el total
            };
            return View(saskiaViewModel);
        }

        // SaskiaGehitu ekintza gehitu kontroladorean
        public async Task<IActionResult> SaskiaGehitu(int id)
        {
            var cart = Saskia.SaskiaLortu(this.HttpContext); //aurretik sortu dugun Saskia klasea erabiliz
            await _saskiaService.SaskiaGehitu(id, cart.SaskiaId); //zerbitzu berrian karritoan gehitzeko
            return RedirectToAction("Index", new { id = cart.SaskiaId });
        }

        // SaskiaGehituAjax ekintza gehitu kontroladorean
        public async Task<IActionResult> SaskiaGehituAjax(int id)
        {
            // Saskia objektua lortu saioetik
            var cart = Saskia.SaskiaLortu(this.HttpContext);
            // Elementua gehitu zerbitzuaren bidez
            await _saskiaService.SaskiaGehitu(id, cart.SaskiaId);
            // Saskiako elementuak lortu zerbitzuaren bidez
            var saskiaItems = await _saskiaService.SaskiaLortuAleak(cart.SaskiaId);
            // Gehitu den elementua bilatu
            var itemAdded = saskiaItems.FirstOrDefault(x => x.ArdoaId == id);
            // Lerroaren azpitotala eta saskia guztira kalkulatu
            var ardoa = await _ardoaService.GetArdoa(id);
            // Lerroaren azpitotala kalkulatu
            decimal lineSubtotal = (itemAdded?.Kantitatea ?? 0) * ardoa.Salneurria;
            // Saskiako guztira kalkulatu
            decimal guztira = 0;
            // Saskiako guztira kalkulatu
            foreach (var item in saskiaItems)
            {
                // Ardoa lortu eta guztira gehitu 
                var a = await _ardoaService.GetArdoa(item.ArdoaId);
                guztira += item.Kantitatea * a.Salneurria;
            }
            // Erantzun JSON objektu batekin
            return Json(new
            {
                kantitatea = itemAdded?.Kantitatea ?? 0,
                lineSubtotal,
                guztira,
                mezua = "Zure saskia eguneratu da"
            });
        }

        // SaskiaKendu ekintza gehitu kontroladorean 
        public async Task<IActionResult> SaskiaKendu(int id)
        {
            // Saskia objektua lortu saioetik
            var cart = Saskia.SaskiaLortu(this.HttpContext);
            // Elementua kendu zerbitzuaren bidez
            await _saskiaService.SaskiaKendu(id, cart.SaskiaId);
            // Saskia orrira birbideratu
            return RedirectToAction("Index", new { id = cart.SaskiaId });
        }

        // SaskiaKenduAjax ekintza gehitu kontroladorean
        public async Task<IActionResult> SaskiaKenduAjax(int id)
        {
            // Saskia objektua lortu saioetik
            var cart = Saskia.SaskiaLortu(this.HttpContext);
            await _saskiaService.SaskiaKendu(id, cart.SaskiaId);
            // Saskiako elementuak lortu zerbitzuaren bidez
            var saskiaItems = await _saskiaService.SaskiaLortuAleak(cart.SaskiaId);
            decimal guztira = 0;
            // Saskiako guztira kalkulatu 
            foreach (var item in saskiaItems)
            {
                var a = await _ardoaService.GetArdoa(item.ArdoaId);
                guztira += item.Kantitatea * a.Salneurria;
            }
            // Kendu den elementua bilatu eta bere kantitatea eta lerroaren azpitotala kalkulatu 
            var itemRemoved = saskiaItems.FirstOrDefault(x => x.ArdoaId == id);
            int kantitatea = itemRemoved != null ? itemRemoved.Kantitatea : 0;
            decimal lineSubtotal = 0;
            // Lerroaren azpitotala kalkulatu bakarrik elementua aurkitu bada
            if (itemRemoved != null)
            {
                var ardoa = await _ardoaService.GetArdoa(id);
                lineSubtotal = itemRemoved.Kantitatea * ardoa.Salneurria;
            }
            // Erantzun JSON objektu batekin
            return Json(new
            {
                kantitatea,
                lineSubtotal,
                guztira,
                mezua = "Zure saskia eguneratu da"
            });
        }
    }
}
