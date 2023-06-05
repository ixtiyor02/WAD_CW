using Microsoft.AspNetCore.Mvc;

namespace CarPartsWebApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
