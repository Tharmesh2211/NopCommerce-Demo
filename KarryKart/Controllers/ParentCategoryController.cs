using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentCategoryController : ControllerBase
    {
        private readonly IParentCategory _context;
        public ParentCategoryController(IParentCategory context)
        {
            _context = context;
        }
        [HttpGet("GetParentCatg")]
        public async Task<IEnumerable<ParentCategory>> GetParentCatg()
        {
            var pro = await _context.GetParentCategory();
            return pro;
        }

        [HttpGet("GetParentCatgId")]
        public async Task<ActionResult<ParentCategory>> GetParentById(int parcatgId)
        {
            var pro = await _context.GetParentCategoryId(parcatgId);
            return pro;
        }

        [HttpPost("CreateParentCatg")]
        public async Task<ActionResult<ParentCategory>> CreateParentCatg(ParentCategory parent_Catg)
        {
            var pro = await _context.AddParentCategory(parent_Catg);
            return pro;
        }
        [HttpPut("UpdateParentCatg")]
        public async Task<ActionResult<ParentCategory>> UpdateParentCatg(ParentCategory parent_Catg)
        {
            var pro = await _context.UpdateParentCategory(parent_Catg);
            return pro;
        }
        [HttpDelete("DeleteParentCatg")]
        public async Task<IActionResult> DeleteParentCatg(int id)
        {
            await _context.DeleteParentCategory(id);
            return NoContent();
        }
        [HttpGet("GetParentCatbByName")]
        public async Task<ActionResult<IQueryable<ParentCategory>>> GetParentByName(string name)
        {
            var pro = await _context.GetParentCategoryByName(name);
            return Ok(pro);
        }
    }
}
