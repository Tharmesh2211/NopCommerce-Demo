using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufactures _manufacturer;
        public ManufacturerController(IManufactures manufacturer)
        {
            _manufacturer = manufacturer;
        }
        [HttpGet("GetManufacturer")]
        public async Task<IEnumerable<Manufacturer>> GetManufacturer()
        {
            var manufracturer = await _manufacturer.GetManufacturer();
            return manufracturer;
        }
        [HttpGet("GetManufacturerByID")]
        public async Task<ActionResult<Manufacturer>> GetManufacturerId(int id)
        {
            var manufracturer = await _manufacturer.GetManufacturerId(id);
            return manufracturer;
        }
        [HttpPost("CreateManufacturer")]
        public async Task<ActionResult<Manufacturer>> CreateManufacturer(Manufacturer manufacturer)
        {
            Manufacturer obj = new Manufacturer();
            if (manufacturer != null)
            {
                obj = await _manufacturer.AddManufacturer(manufacturer);
            }
            return obj;
        }
        [HttpPut("UpdateManufacturer")]
        public async Task<ActionResult<Manufacturer>> UpdateManufacturer(Manufacturer manufacturer)
        {
            var update = await _manufacturer.UpdateManufacturer(manufacturer);
            return update;
        }

        [HttpDelete("DeleteManufacturer")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            await _manufacturer.DeleteManufacturer(id);
            return NoContent();
        }
    }
}
