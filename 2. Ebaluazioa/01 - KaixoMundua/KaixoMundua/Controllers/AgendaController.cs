using KaixoMundua.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KaixoMundua.Controllers
{

    public class AgendaController : Controller
    {
        // Corrige CS8802: mueve la inicialización de la lista dentro de la clase como campo estático.
        // Corrige IDE0028 e IDE0090: simplifica la inicialización de la colección y los objetos.
        private static List<Kontaktua> kontaktuLista = new()
            {
                new("12345678A", "Ainhize", "Arrese") { Emaila = "arrese.ainhize@uni.eus" },
                new("12345678B", "Mireia", "Calvo") { Emaila = "calvo.mireia@uni.eus" },
                new("12345678C", "Naroa", "Maiztegui") { Emaila = "maiztegui.naroa@uni.eus" }
            };

        // GET: AgendaController
        public ActionResult Index()
        {
            return View(kontaktuLista);
        }

        // GET: AgendaController/Details/5
        public ActionResult Details(String nan)
        {
            Kontaktua k1 = null;
            foreach (Kontaktua k in kontaktuLista)
            {
                if (k.Nan.Equals(nan))
                {
                    k1 = k;
                    break;
                }
            }

            if (k1 == null)
            {
                return View();
            }
            return View(k1);
        }

        // GET: AgendaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgendaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AgendaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AgendaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AgendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
