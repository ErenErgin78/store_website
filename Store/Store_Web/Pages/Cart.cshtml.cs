using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace Store_Web.Pages
{
    public class CartModel : PageModel
    {
        private readonly IServiceManager  _manager;
        private readonly Cart  _cart;
        public Cart Cart { get; set; }
        public String ReturnUrl { get; set; } = "/";

        public CartModel(IServiceManager manager, Cart cart)
        {
            _manager = manager;
            Cart = cart;
        }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int product_Id, string returnUrl)
        {
            Product? product = _manager.ProductService.GetProductById(product_Id, false);

            if(product is not null)
            {
                Cart.AddItem(product,1);
            } 
            return Page();
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(i => i.Product.Product_Id.Equals(id)).Product);
            return Page();
        }
    }
}