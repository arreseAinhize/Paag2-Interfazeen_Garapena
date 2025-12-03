using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabaRanking.Models;

namespace RabaRanking.Controllers
{
    public class JatetxeakController : Controller
    {
        private static List<Jatetxea> jatetxeLista = new()
            {
                new("Azkenetxe", "Mutriku", 8.6,1){ Helbidea = "Alto del Calvario 1, Mutriku, ES 20830"},
                new("Alai", "Ondarru", 8.4,2),
                new("Mantxua", "Lekitto", 8,3) { Helbidea = "Beheko Kalea, 24, Lekeitio, ES 48280"},
                new("Zazpi","Durango",6.8,4) { Helbidea= "Ibaizabal Auzunea, 1 -1A - 48200 Durango (Bizkaia)" } ,
                new("Prim","Lekitto", 0.0,5)
            };
        // GET: JatetxeakController
        public ActionResult Index()
        {
            return View(jatetxeLista);
        }

        // GET: JatetxeakController/Details/5
        public ActionResult Details(string izena)
        {
            Jatetxea jatetxea = null;
            foreach (Jatetxea j in jatetxeLista)
            {
                if (j.Izena.Equals(izena))
                {
                    jatetxea = j;
                    break;
                    
                }
            }

            if(jatetxea == null)
            {
                return View();
            }
            return View(jatetxea);
        }

        // GET: JatetxeakController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JatetxeakController/Create
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

        // GET: JatetxeakController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JatetxeakController/Edit/5
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

        // GET: JatetxeakController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JatetxeakController/Delete/5
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
