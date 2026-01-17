using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WineShop.Controllers
{
    // This controller handles the payment process for the WineShop application.
    // It requires users to be authorized to access its actions.
    [Authorize]
    public class OrdainduController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
