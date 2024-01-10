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
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet("GetCategory")]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            var category = await _category.GetCategory();
            return category;
        }
        [HttpGet("GetCategoryByID")]
        public async Task<ActionResult<Category>> GetCategoryId(int id)
        {
            var manufracturer = await _category.GetCategoryId(id);
            return manufracturer;
        }
        [HttpPost("CreateCategory")]
        public async Task<ActionResult<Category>> CreateManufacturer(Category category)
        {
            Category obj = new Category();
            if (category != null)
            {
                obj = await _category.AddCategory(category);
            }
            return obj;
        }
        [HttpPut("UpdateCategory")]
        public async Task<ActionResult<Category>> UpdateManufacturer(Category category)
        {
            var update = await _category.UpdateCategory(category);
            return update;
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _category.DeleteCategory(id);
            return NoContent();
        }
    }
}
