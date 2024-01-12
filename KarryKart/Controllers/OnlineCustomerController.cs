using Contracts;
using Entites.Models.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern;

namespace KarryKart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineCustomerController : ControllerBase
    {
        private readonly IOnlineCustomer _iOnlineCustomerRepository;
        public OnlineCustomerController(IOnlineCustomer iOnlineCustomerRepository)
        {
            _iOnlineCustomerRepository = iOnlineCustomerRepository;
        }
        [HttpGet("GetOnlineCustomer")]
        public async Task<IEnumerable<OnlineCustomer>> GetOnlineCustomer()
        {
            var onlineCustomer = await _iOnlineCustomerRepository.GetOnlineCustomer();
            return onlineCustomer;
        }
        [HttpGet("GetOnlineCustomerbyId")]
        public async Task<ActionResult<OnlineCustomer>> GetOnlineCustomerbyId(int id)
        {
            var onlineCustomer = await _iOnlineCustomerRepository.GetOnlineCustomerbyId(id);
            return onlineCustomer;
        }

        [HttpPost("AddOnlineCustomer")]
        public async Task<ActionResult<OnlineCustomer>> AddOnlineCustomer(OnlineCustomer onlineCustomer)
        {
            OnlineCustomer Response = new OnlineCustomer();
            if (onlineCustomer != null)
            {
                onlineCustomer.Id = 0;
                Response = await _iOnlineCustomerRepository.AddOnlineCustomer(onlineCustomer);
            }

            return Response;
        }
        [HttpPut("UpdateOnlineCustomer/{id}")]
        public async Task<ActionResult<OnlineCustomer>> UpdateOnlineCustomer(OnlineCustomer onlineCustomer)
        {


            var update = await _iOnlineCustomerRepository.UpdateOnlineCustomer(onlineCustomer);


            return update;
        }
        [HttpDelete("DeleteOnlineCustomer/{id}")]
        public async Task<IActionResult> DeleteOnlineCustomer(int id)
        {


            await _iOnlineCustomerRepository.DeleteOnlineCustomer(id);
            return NoContent();
        }
    }
}
