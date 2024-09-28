using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;

namespace Store_Web.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_manager.CategoryService.GetCategories(false),"Category_Id","Category_Name","1");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                _manager.ProductService.CreateProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var model = _manager.ProductService.GetProductById(id, false);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _manager.ProductService.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _manager.ProductService.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}