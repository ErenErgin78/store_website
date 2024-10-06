using Entities.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Store_Web.Pages
{
    public class CartModel : PageModel
    {
        public Cart Cart { get; set; }
        public String ReturnUrl { get; set; } = "/";
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            
        }

    }
}