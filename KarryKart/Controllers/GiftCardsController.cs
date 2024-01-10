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
    public class GiftCardsController : ControllerBase
    {
        private readonly IGiftCard _context;
        public GiftCardsController(IGiftCard context)
        {
            _context = context;
        }
        [HttpGet("GetGiftCard")]
        public async Task<IEnumerable<GiftCard>> GetGiftCard()
        {
            var pro = await _context.GetGiftCards();
            return pro;
        }

        [HttpGet("GetGiftCardId")]
        public async Task<ActionResult<GiftCard>> GetGiftCardById(int giftCardid)
        {
            var pro = await _context.GetGiftCardId(giftCardid);
            return pro;
        }

        [HttpPost("CreateGiftCard")]
        public async Task<ActionResult<GiftCard>> CreateGiftCard(GiftCard giftCard)
        {
            var pro = await _context.AddGiftCard(giftCard);
            return pro;
        }
        [HttpPut("UpdateGiftCard")]
        public async Task<ActionResult<GiftCard>> UpdateGiftCard(GiftCard giftCard)
        {
            var pro = await _context.UpdateGiftCard(giftCard);
            return pro;
        }
        [HttpDelete("DeleteGiftCard")]
        public async Task<IActionResult> DeleteGiftCard(int id)
        {
            await _context.DeleteGiftCard(id);
            return NoContent();
        }
    }
}
