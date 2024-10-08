using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace Store_Web.Controllers
{
    public class CategoryController : Controller
    {
        private IRepositoryManager _manager;

        public CategoryController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.CategoryRepository.FindAll(false);
            return View(model);
        }
    }
    
}