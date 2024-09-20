using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Store_Web.Models;

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