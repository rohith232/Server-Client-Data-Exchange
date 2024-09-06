using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPIProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { ProductId = 1, Name = "Product One", Price = 12000 },
             new Product() { ProductId = 2, Name = "Product Two", Price = 12000 },
              new Product() { ProductId = 3, Name = "Product Three", Price = 12000 },


        };
        [HttpGet]

        public List<Product> GetProducts()
        {
            return Products;
        }

        [HttpPost]

        public void PostProducts()
        {
            Products.Add(new Product() { ProductId = 4, Name = "Product Four", Price = 12000 });
        }
    }
}
