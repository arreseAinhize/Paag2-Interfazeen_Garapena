using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    public class SaskiaController : Controller
    {

        private readonly ISaskiaService _saskiaService;
        private readonly IArdoaService _ardoaService;
        public SaskiaController(ISaskiaService saskiaService, IArdoaService ardoaService)
        {
            _saskiaService = saskiaService;
            _ardoaService = ardoaService;
        }
        public async Task<IActionResult> Index(string id)
        {
            IList<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            saskiaAleaList = await _saskiaService.SaskiaLortuAleak(id);

            //Ardo bakoitzaren datuak hartu eta ViewModel bezala sortu
            IList<SaskiaAleaViewModel> saskiaAleaVMList = new List<SaskiaAleaViewModel>();
            decimal guztira = 0; // Saskiaren totala
            if (saskiaAleaList.Count() > 0)
            {
                foreach (var saskiaAlea in saskiaAleaList)
                {
                    var ardoa = await _ardoaService.GetArdoa(saskiaAlea.ArdoaId);
                    SaskiaAleaViewModel saskiaAleaViewModel = new SaskiaAleaViewModel()
                    {
                        ArdoaId = ardoa.Id,
                        Irudia = ardoa.Irudia,
                        Izena = ardoa.Izena,
                        Kantitatea = saskiaAlea.Kantitatea,
                        Salneurria = ardoa.Salneurria
                    };
                    saskiaAleaVMList.Add(saskiaAleaViewModel);
                    guztira += saskiaAlea.Kantitatea * ardoa.Salneurria;

                }                                                         // ViewModela sortu bistarako
            }
            else
            {
                ViewBag.Mezuak = "Zure saskia hutsik dago.";
            }

                var saskiaViewModel = new SaskiaViewModel()
                {
                    SaskiaAleaVMList = saskiaAleaVMList,
                    Guztira = guztira // <-- aquí incluimos el total
                }; return View(saskiaViewModel);
        }
        public async Task<IActionResult> SaskiaGehitu(int id)
        {
            var cart = Saskia.SaskiaLortu(this.HttpContext); //aurretik sortu dugun Saskia klasea erabiliz
            await _saskiaService.SaskiaGehitu(id, cart.SaskiaId); //zerbitzu berrian karritoan gehitzeko
            return RedirectToAction("Index", new { id = cart.SaskiaId });
        }

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

            // Elementua kendu y obtener lista actualizada
            await _saskiaService.SaskiaKendu(id, cart.SaskiaId);

            var saskiaItems = await _saskiaService.SaskiaLortuAleak(cart.SaskiaId);


            // Calcular total
            decimal guztira = 0;
            foreach (var item in saskiaItems)
            {
                var a = await _ardoaService.GetArdoa(item.ArdoaId);
                guztira += item.Kantitatea * a.Salneurria;
            }

            // Encontrar el item (si todavía existe después de la operación)
            var itemAfterRemoval = saskiaItems.FirstOrDefault(x => x.ArdoaId == id);
            int kantitatea = itemAfterRemoval != null ? itemAfterRemoval.Kantitatea : 0;
            decimal lineSubtotal = 0;

            // Calcular subtotal de línea si el item todavía existe
            if (itemAfterRemoval != null)
            {
                var ardoa = await _ardoaService.GetArdoa(id);
                lineSubtotal = itemAfterRemoval.Kantitatea * ardoa.Salneurria;
            }

            // Devolver respuesta JSON
            return Json(new
            {
                kantitatea,
                lineSubtotal,
                guztira,
                guztiraFormateatua = guztira.ToString("C"), // Formato moneda
                mezua = "Zure saskia eguneratu da",
                itemExists = itemAfterRemoval != null // Para saber si el item fue eliminado completamente
            });
        }


    }
}
