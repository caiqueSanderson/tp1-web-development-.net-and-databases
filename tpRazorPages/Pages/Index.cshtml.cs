using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace tpRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100.0 },
                new Product { Id = 2, Name = "Product 2", Price = 200.0 },
                new Product { Id = 3, Name = "Product 3", Price = 150.0 }
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
