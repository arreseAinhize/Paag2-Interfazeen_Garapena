using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace KaixoMundua.Controllers
{
    public class KaixoMunduaController : Controller
    {
        //Atal honek Vista bat itzultzen du:
        public IActionResult Index()
        {
            return View();
        }

        /*public String Index() //Defektos kargatuko den metodoa
        {
            return "Hau da nire hasierako ekintza.";

        }*/
        //public String OngiEtorri(String izena, int zenbakia = 4)
        //{
        //    //return "Hau da OngiEtorri metodoa.";
        //    //return $"Ongi etorri {izena}, zenbakia da {zenbakia}.";
        //    return HttpUtility.HtmlEncode($"Ongi etorri {izena}, zenbakia da {zenbakia}.");
        //}
        public ActionResult OngiEtorri(String izena, int zenbakia = 1)
        {
            ViewBag.Mezua = $"Kaixo {izena}";
            ViewBag.Zenbat = zenbakia;
            return View();
        }
    }
}
