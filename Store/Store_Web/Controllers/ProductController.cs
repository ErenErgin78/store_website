using Microsoft.AspNetCore.Mvc;
using Repositories;
using Entities.Models;
using Repositories.Contracts;
using Microsoft.VisualBasic;
using Services.Contracts;

namespace Store_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ProductService.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            var model = _manager.ProductService.GetProductById(id, false);
            return View(model);
        }
    }
}