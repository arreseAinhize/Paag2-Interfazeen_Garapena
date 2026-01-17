using Microsoft.AspNetCore.Mvc;
using WineShop.Models;
using WineShop.Services;

namespace WineShop.ViewComponents
{
    public class KarritoaViewComponent : ViewComponent
    {
        private readonly ISaskiaService _saskiaService;
        public KarritoaViewComponent(ISaskiaService saskiaService)
        {
            _saskiaService = saskiaService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var cart = Saskia.SaskiaLortu(this.HttpContext); //aurretik sortu dugun Saskia klasea erabiliz
            List<SaskiaAlea> saskialist = await _saskiaService.SaskiaLortuAleak(cart.SaskiaId);
            ViewBag.kopurua = saskialist.Count();
            return View();
        }
    }
}
