using Liburuak.Models;
using Liburuak.Services;
using Liburuak.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Liburuak.Controllers
{
    public class LiburuakController : Controller
    {
        private readonly ILiburuakService _liburuakService;

        public LiburuakController(ILiburuakService liburuakService)
        {
            _liburuakService = liburuakService;
        }
        public async Task<IActionResult> Index()
        {
            var liburuak = await _liburuakService.getLiburuak();

            // DEBUG: Muestra en consola cuántos libros obtienes
            Console.WriteLine($"Liburu kopurua: {liburuak.Count}");

            // Convierte a ViewModel
            var libViewModel = liburuak.Select(l => new LiburuaViewModel
            {
                id = l.id,
                titulo = l.titulo,
                saga = l.saga,
                anio_publicacion = l.anio_publicacion,
                paginas = l.paginas,
                valoracion_promedio = l.valoracion_promedio,
                sinopsis = l.sinopsis
            }).ToList();

            return View(libViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Create(Liburua liburuEskaera)
        {
            if (!ModelState.IsValid)
            {
                return View(liburuEskaera);
            }

            // Lehenengo: API-an BezeroaEskaera sortu
            await _liburuakService.addLiburua(liburuEskaera);


            TempData["Success"] = "Eskaera ondo bidali da.";
            return RedirectToAction("index");
            //return View();
        }
    }
}
