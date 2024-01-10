using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProduct _context;

        public ProductController(IProduct context)

        {

            _context = context;

        }

        [HttpGet("GetProduct")]

        public async Task<IEnumerable<Product>> GetProduct()

        {

            var pro = await _context.GetProducts();

            return pro;

        }

        [HttpGet("GetProductId")]

        public async Task<ActionResult<Product>> GetProductById(int productid)

        {

            var pro = await _context.GetProductById(productid);

            return pro;

        }

        [HttpPost("CreateProduct")]

        public async Task<ActionResult<Product>> CreateParentCatg(Product product)

        {

            var pro = await _context.AddProduct(product);

            return pro;

        }

        [HttpPut("UpdateProduct")]

        public async Task<ActionResult<Product>> UpdateParentCatg(Product product)

        {

            var pro = await _context.UpdateProduct(product);

            return pro;

        }

        [HttpDelete("DeleteProduct")]

        public async Task<IActionResult> DeleteProduct(int id)

        {

            await _context.DeleteProduct(id);

            return NoContent();

        }
    }
}
