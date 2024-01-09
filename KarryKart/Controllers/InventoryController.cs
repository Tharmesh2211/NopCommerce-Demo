using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventory _iInventoryRepository;
        public InventoryController(IInventory iInventoryRepository)
        {
            _iInventoryRepository = iInventoryRepository;
        }
        [HttpGet(" GetInventory")]
        public async Task<IEnumerable<Inventory>> GetInventory()
        {
            var parentcategory = await _iInventoryRepository.GetInventory();
            return parentcategory;
        }
        [HttpGet("GetInventorybyId")]
        public async Task<ActionResult<Inventory>> GetInventorybyId(int id)
        {
            var Inventory = await _iInventoryRepository.GetInventorybyId(id);
            return Inventory;
        }

        [HttpPost("AddInventory")]
        public async Task<ActionResult<Inventory>> AddInventory(Inventory inventory)
        {
            Inventory Response = new Inventory();
            if (inventory != null)
            {
                inventory.Id = 0;
                Response = await _iInventoryRepository.AddInventory(inventory);
            }

            return Response;
        }
        [HttpPut("UpdateInventory/{id}")]
        public async Task<ActionResult<Inventory>> UpdateInventory(Inventory inventory)
        {


            var update = await _iInventoryRepository.UpdateInventory(inventory);


            return update;
        }
        [HttpDelete("DeleteInventory/{id}")]
        public async Task<IActionResult> DeleteInventory(int id)
        {


            await _iInventoryRepository.DeleteInventory(id);
            return NoContent();
        }
    }
}
