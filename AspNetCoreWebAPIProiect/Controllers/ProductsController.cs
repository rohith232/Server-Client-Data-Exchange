using AspNetCoreWebAPIProiect.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Nest;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreWebAPIProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getAll")]

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();

        }

        [HttpPost("add")]

        public IActionResult AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, product);
               
            }
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Products.Find(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id ,Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    _context.Products.Update(product);
                    _context.SaveChanges(true);
                    return StatusCode(StatusCodes.Status200OK);
                }

                return StatusCode(StatusCodes.Status400BadRequest);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }







    }
}
