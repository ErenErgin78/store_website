using Microsoft.AspNetCore.Mvc;
using Repositories;
using Entities.Models;
using Repositories.Contracts;
using Microsoft.VisualBasic;

namespace Store_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ProductRepository.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            var model = _manager.ProductRepository.GetProductById(id, false);
            return View(model);
        }
    }
}