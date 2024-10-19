using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;
using Store_Web.Infrastructe.Extensions;

namespace Store_Web.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager  _manager;
        private readonly Cart  _cart;
        public Cart Cart { get; set; }
        public String ReturnUrl { get; set; } = "/";

        public CartModel(IServiceManager manager)
        {
            _manager = manager;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int product_Id, string returnUrl)
        {
            Product? product = _manager.ProductService.GetProductById(product_Id, false);

            if(product is not null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product,1);
                HttpContext.Session.SetJson<Cart>("cart", Cart);
            } 
            return Page();
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.RemoveLine(Cart.Lines.First(i => i.Product.Product_Id.Equals(id)).Product);
            HttpContext.Session.SetJson<Cart>("cart", Cart);
            return Page();
        }
    }
}