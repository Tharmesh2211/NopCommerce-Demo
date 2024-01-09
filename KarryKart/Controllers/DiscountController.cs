using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscounts _context;
        public DiscountController(IDiscounts context)
        {
            _context = context;
        }
        [HttpGet("GetDiscount")]
        public async Task<IEnumerable<Discount>> GetDiscount()
        {
            var pro = await _context.GetDiscounts();
            return pro;
        }

        [HttpGet("GetDiscountId")]
        public async Task<ActionResult<Discount>> GetDiscountById(int discountid)
        {
            var pro = await _context.GetDiscountId(discountid);
            return pro;
        }

        [HttpPost("CreateDiscount")]
        public async Task<ActionResult<Discount>> CreateDiscount(Discount discount)
        {
            var pro = await _context.AddDiscount(discount);
            return pro;
        }
        [HttpPut("UpdateDiscount")]
        public async Task<ActionResult<Discount>> UpdateDiscount(Discount discount)
        {
            var pro = await _context.UpdateDiscounts(discount);
            return pro;
        }
        [HttpDelete("DeleteDiscount")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            await _context.DeleteDiscounts(id);
            return NoContent();
        }
    }
}
