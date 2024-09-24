using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Store_Web.Components
{
    
    public class CategoriesMenuViewComponent : ViewComponent
    {
        public readonly IServiceManager _manager;

        public CategoriesMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _manager.CategoryService.GetCategories(false);
            return View(categories);
        }
    }
}