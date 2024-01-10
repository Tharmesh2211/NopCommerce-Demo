using Contracts;
using Entites.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern;

namespace KarryKart.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRental _iRental;
        public RentalController(IRental iRentalRepository)
        {
            _iRental = iRentalRepository;
        }

        [HttpGet(" GetRental")]
        public async Task<IEnumerable<Rental>> GetRental()
        {
            var Rental = await _iRental.GetRental();
            return Rental;
        }
        [HttpGet("GetRentalbyId")]
        public async Task<ActionResult<Rental>> GetRentalbyId(int Id)
        {
            var rental = await _iRental.GetRentalbyId(Id);
            return rental;
        }
        [HttpPost("AddRental")]
        public async Task<ActionResult<Rental>> AddRental(Rental rental)
        {
            Rental Response = new Rental();
            if (rental != null)
            {
                rental.Id = 0;
                Response = await _iRental.AddRental(rental);
            }

            return Response;
        }
        [HttpPut("UpdateRental/{id}")]
        public async Task<ActionResult<Rental>> UpdateRental(Rental rental)
        {


            var update = await _iRental.UpdateRental(rental);


            return update;
        }
        [HttpDelete("DeleteRental/{id}")]
        public async Task<IActionResult> DeleteRental(int id)
        {


            await _iRental.DeleteRental(id);
            return NoContent();
        }
    }
}
