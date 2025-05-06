using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tpRazorPages.Pages.TP10
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public void OnGet() { }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
