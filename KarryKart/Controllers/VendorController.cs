using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendor _vendor;
        public VendorController(IVendor vendor)
        {
            _vendor = vendor;
        }
        [HttpGet("GetVendors")]
        public async Task<IEnumerable<Vendors>> GetVendors()
        {
            var tax = await _vendor.GetVendors();
            return tax;
        }
        [HttpGet("GetVendorByID")]
        public async Task<ActionResult<Vendors>> GetVendorByID(int id)
        {
            var var = await _vendor.GetVendorId(id);
            return var;
        }
        [HttpPost("AddVendors")]
        public async Task<ActionResult<Vendors>> AddVendors(Vendors vendor)
        {
            Vendors obj = new Vendors();
            if (vendor != null)
            {
                obj = await _vendor.AddVendor(vendor);
            }
            return obj;
        }
        [HttpPut("UpdateVendor")]
        public async Task<ActionResult<Vendors>> UpdateVendor(Vendors vendor)
        {
            var update = await _vendor.UpdateVendor(vendor);
            return update;
        }

        [HttpDelete("DeleteVendor")]
        public async Task<IActionResult> DeletVendor(int id)
        {
            await _vendor.DeleteVendor(id);
            return NoContent();
        }
    }
}
