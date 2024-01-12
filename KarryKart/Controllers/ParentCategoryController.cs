using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace KarryKart.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParentCategoryController : ControllerBase
    {
        private readonly IParentCategory _parentCategory;
        public ParentCategoryController(IParentCategory parentCategory)
        {
            _parentCategory = parentCategory;
        }
        [HttpGet("GetParentCategory")]
        public async Task<IEnumerable<ParentCategory>> GetParentCategory()
        {
            var ParentCategory = await _parentCategory.GetParentCategory();

            return ParentCategory != null ? ParentCategory : Enumerable.Empty<ParentCategory>();

        }

        [HttpGet("GetParentCategoryById")]
        public async Task<IEnumerable<ParentCategory>> GetParentCategoryById(int ParentCategoryId)
        {
            var ParentCategory = await _parentCategory.GetParentCategoryId(ParentCategoryId);

            return ParentCategory != null ? ParentCategory : Enumerable.Empty<ParentCategory>();
        }

        [HttpPost("PostParentCategory")]
        public async Task<ActionResult<ParentCategory>> PostParentCategory(ParentCategory parentCategory)
        {
            var ParentCategory = await _parentCategory.AddParentCategory(parentCategory);
            return ParentCategory;
        }
        [HttpPut("UpdateParentCategory")]
        public async Task<ActionResult<ParentCategory>> UpdateParentCategory(ParentCategory parentCategory)
        {
            var updatedParentCategory = await _parentCategory.UpdateParentCategory(parentCategory);

            return updatedParentCategory.Any()? Ok(updatedParentCategory) : Ok(new { message = "No Data Found !" });
        }
        [HttpDelete("DeleteParentCategory")]
        public async Task<ActionResult> DeleteParentCategory(int id)
        {
            var DeleteParentCategory = await _parentCategory.DeleteParentCategory(id);

            if(DeleteParentCategory.Any())
            {
                return Ok(new { message = " Successfully Deleted" });
            }
            return Ok(new { message = "No Data Found!" });

        }
        [HttpGet("GetParentCatbByName")]
        public async Task<ActionResult<IQueryable<ParentCategory>>> GetParentByName(string name)
        {
            var pro = await _parentCategory.GetParentCategoryByName(name);
            return Ok(pro);
        }
    }
}
