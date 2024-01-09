using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly IShipping _shipping;
        public ShippingController(IShipping shipping)
        {
            _shipping = shipping;
        }
        [HttpGet("GetShipping")]
        public async Task<IEnumerable<Shipping>> GetShipping()
        {
            var category = await _shipping.GetShippings();
            return category;
        }
        [HttpGet("GetShippingByID")]
        public async Task<ActionResult<Shipping>> GetShippingId(int id)
        {
            var manufracturer = await _shipping.GetShippingId(id);
            return manufracturer;
        }
        [HttpPost("AddShipping")]
        public async Task<ActionResult<Shipping>> AddShipping(Shipping shipping)
        {
            Shipping obj = new Shipping();
            if (shipping != null)
            {
                obj = await _shipping.AddShipping(shipping);
            }
            return obj;
        }
        [HttpPut("UpdateShipping")]
        public async Task<ActionResult<Shipping>> UpdateShipping(Shipping shipping)
        {
            var update = await _shipping.UpdateShipping(shipping);
            return update;
        }

        [HttpDelete("DeleteShipping")]
        public async Task<IActionResult> DeleteShipping(int id)
        {
            await _shipping.DeleteShipping(id);
            return NoContent();
        }
    }
}
