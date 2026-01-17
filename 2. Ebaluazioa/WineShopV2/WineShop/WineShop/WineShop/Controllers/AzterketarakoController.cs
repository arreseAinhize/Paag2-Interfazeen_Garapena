using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;
using WineShop.ViewModels;

namespace WineShop.Controllers
{
    public class AzterketarakoController : Controller
    {
        private readonly IAzterketarakoService _azterketarakoService;

        public AzterketarakoController(IAzterketarakoService azterketarakoService)
        {
            _azterketarakoService = azterketarakoService;
        }

        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Index(BezeroaEskaera model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Erabiltzailea esparrua beteta ez badago, automatikoki balio bat sortu 
            if (string.IsNullOrEmpty(model.Erabiltzailea))
            {
                model.Erabiltzailea = $"{model.Izena.ToLower()}.{model.Abizena.ToLower()}";
            }
            // Baliozko Data bat asignatu --> SQL Server datetime-k ez ditu 1753-baino lehenagoko datak onartzen
            model.Data = DateTime.Now; // Fecha actual

            // Lehenengo: API-an BezeroaEskaera sortu
            await _azterketarakoService.EskaeraBezeroaGehitu(model);
                //Eskaerak BezeroaEskaera bat itzuliko balu:
                // BezeroaEskaera createdEskaera = await _azterketarakoService.EskaeraBezeroaGehitu(model);    

            // Ondoren: Erosketa sortu, API-ak itzulitako BezeroaEskaera.Id-a erabiliz.
            await _azterketarakoService.EskaeraGehitu(model.Id);

            TempData["Success"] = "Eskaera ondo bidali da.";
            return RedirectToAction("EskaerenLista");
        }

        public async Task<IActionResult> EskaerenLista()
        {
            List<BezeroaEskaera> bezeroEskaeraList = new List<BezeroaEskaera>();

            bezeroEskaeraList  = await _azterketarakoService.getEskaeraBezeroaList();
            return View(bezeroEskaeraList.Where(b => b.Postakodea == "48200")); // PostaKodea 48200 duten bezeroEkaerak soilik pasatuko dira.
            // <-- Lista bat pasatzen ez bada edo Null pasatzen bada
            // "System.NullReferenceException: 'Object reference not set to an instance of an object.'"
            // errorea emango du
        }
    }
}
