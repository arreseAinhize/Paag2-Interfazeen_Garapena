using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;

namespace WineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArdoaService _ardoaService; //Ardoares zerbitzuaren deklarazioa

        public HomeController(ILogger<HomeController> logger, IArdoaService ardoaService)
        {
            _logger = logger;
            _ardoaService = ardoaService;  //Ardoares zerbitzuaren instantzia sortu
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index()
        {
            List<Ardoa> ardoaList = new List<Ardoa>();
            ardoaList = await _ardoaService.GetArdoak();
            return View(ardoaList.Where(a => a.Eskaintza == true));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
