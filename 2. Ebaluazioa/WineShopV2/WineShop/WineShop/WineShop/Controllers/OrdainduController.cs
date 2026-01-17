using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc; // Ez da borratu behar bestea kopiatzean
using WineShop.Data;
using WineShop.Models;
using WineShop.Services;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    [Authorize]
    public class OrdainduController : Controller
    {
        private readonly ISaskiaService _saskiaService;
        private readonly IArdoaService _ardoaService;


        public OrdainduController(ISaskiaService saskiaService, IArdoaService ardoaService)
        {
            _saskiaService = saskiaService;
            _ardoaService = ardoaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Abizena,Helbidea,Herrialdea,Hiria,Izena,Postakodea,Telefonoa")] BezeroaEskaera bezeroaEskaera)
        {
            if (ModelState.IsValid)
            {
                /*Bezeroendatuak gorde*/
                bezeroaEskaera.Erabiltzailea = HttpContext.User.Identity.Name; // Momentuko erabiltzailearen izena lortu
                bezeroaEskaera.Data = DateTime.Now; // Uneko data eta ordua ezarri
                await _saskiaService.EskaeraBezeroaGehitu(bezeroaEskaera);
                //Eskaera berria sortu eta gorde
                BezeroaEskaera createdBezeroaEskaera = new BezeroaEskaera();
                createdBezeroaEskaera = await _saskiaService.EskaeraBezeroaGehitu(bezeroaEskaera);
                /*Eskaera gorde*/
                var cart = Saskia.SaskiaLortu(this.HttpContext);
                await _saskiaService.EskaeraSortu(createdBezeroaEskaera, cart.SaskiaId);
                /*Beste pantaila batera berbideratzenda*/
                return RedirectToAction("Osatu", new
                {
                    bezeroa = bezeroaEskaera.Izena + " " + bezeroaEskaera.Abizena,
                    saskiaId = cart.SaskiaId
                });
            }
            return View(bezeroaEskaera);
        }

        public async Task<IActionResult> Osatu(string bezeroa, string saskiaId)
        {
            var osatuViewModel = new OsatuViewModel(); //ViewModel bat erabiliko dugu
            //osatuViewModel.SaskiaAleak = await _saskiaService.SaskiaLortuAleak(saskiaId);

            // SaskiaAleak lortu
            IList<SaskiaAlea> saskiaAleaList = new List<SaskiaAlea>();
            saskiaAleaList = await _saskiaService.SaskiaLortuAleak(saskiaId);


            osatuViewModel.SaskiaId = saskiaId;
            osatuViewModel.Bezeroa = bezeroa;

            // SaskiaAleaViewModel zerrenda osatu
            IList<SaskiaAleaViewModel> saskiaAleaVMList = new List<SaskiaAleaViewModel>();
            foreach (var saskiaAlea in saskiaAleaList)
            {
                // Ardoa lortu ardoaService erabiliz
                var ardoa = await _ardoaService.GetArdoa(saskiaAlea.ArdoaId);
                // SaskiaAleaViewModel objektua sortu eta datuak kopiatu
                SaskiaAleaViewModel saskiaAleaViewModel = new SaskiaAleaViewModel()
                {
                    ArdoaId = ardoa.Id,
                    Irudia = ardoa.Irudia,
                    Izena = ardoa.Izena,
                    Kantitatea = saskiaAlea.Kantitatea,
                    Salneurria = ardoa.Salneurria
                };
                // Gehitu zerrendara
                saskiaAleaVMList.Add(saskiaAleaViewModel);
            }

            // SaskiaAleaVMList ezarri ViewModel-ean 
            osatuViewModel.SaskiaAleaVMList = saskiaAleaVMList;

            return View(osatuViewModel);
        }

    }
}
