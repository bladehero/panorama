using Microsoft.AspNetCore.Mvc;

namespace OdekuTour.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}