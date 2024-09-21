using Microsoft.AspNetCore.Mvc;

namespace Store_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}