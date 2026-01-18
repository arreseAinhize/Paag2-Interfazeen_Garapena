using Liburuak.Models;
using Liburuak.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Liburuak.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILiburuakService _liburuakService;

        public HomeController(ILogger<HomeController> logger, ILiburuakService liburuakService)
        {
            _logger = logger;
            _liburuakService = liburuakService;
        }

        public IActionResult Index()
        {
            return View();
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
