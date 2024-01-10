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
    public class TaxController : ControllerBase
    {
        private readonly ITax _tax;
        public TaxController(ITax tax)
        {
            _tax = tax;
        }
        [HttpGet("GetTaxes")]
        public async Task<IEnumerable<Tax>> GetTaxes()
        {
            var tax = await _tax.GetTax();
            return tax;
        }
        [HttpGet("GetTaxByID")]
        public async Task<ActionResult<Tax>> GetTaxByID(int id)
        {
            var var = await _tax.GetTaxId(id);
            return var;
        }
        [HttpPost("CreateTax")]
        public async Task<ActionResult<Tax>> CreateTax(Tax tax)
        {
            Tax obj = new Tax();
            if (tax != null)
            {
                obj = await _tax.AddTax(tax);
            }
            return obj;
        }
        [HttpPut("UpdateTax")]
        public async Task<ActionResult<Tax>> UpdateTax(Tax tax)
        {
            var update = await _tax.UpdateTax(tax);
            return update;
        }

        [HttpDelete("DeleteTax")]
        public async Task<IActionResult> DeleteTax(int id)
        {
            await _tax.DeleteTax(id);
            return NoContent();
        }
    }
}
