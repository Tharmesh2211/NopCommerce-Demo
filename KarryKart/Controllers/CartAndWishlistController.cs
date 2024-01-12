using Contracts;
using Entites.Models.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KarryKart.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartAndWishlistController : ControllerBase
    {
        private readonly ICartAndWishlist _CartAndWishlist;
        public CartAndWishlistController(ICartAndWishlist cartAndWishlist)
        {
            _CartAndWishlist = cartAndWishlist;
        }
        [HttpGet("GetcartAndWishlist")]
        public async Task<IEnumerable<CartAndWishlist>> GetcartAndWishlist()
        {
            var player = await _CartAndWishlist.GetCartAndWishlists();
            return player;
        }

        [HttpGet("GetCartAndWishlistById")]
        public async Task<ActionResult<CartAndWishlist>> GetCartAndWishlistById(int id)
        {
            var player = await _CartAndWishlist.GetCartAndWishlistId(id);
            return player;
        }
        [HttpPost("AddCartAndWishlist")]
        public async Task<ActionResult<CartAndWishlist>> AddCartAndWishlist(CartAndWishlist cartAndWishlist)
        {
            CartAndWishlist obj = new CartAndWishlist();
            if (cartAndWishlist != null)
            {
                obj = await _CartAndWishlist.AddCartAndWishlist(cartAndWishlist);
            }
            return obj;
        }
        [HttpPut("UpdatecartAndWishlist")]
        public async Task<ActionResult<CartAndWishlist>> UpdatecartAndWishlist(CartAndWishlist cartAndWishlist)
        {
            var update = await _CartAndWishlist.UpdateCartAndWishlist(cartAndWishlist);
            return update;
        }

        [HttpDelete("DeletecartAndWishlist")]
        public async Task<IActionResult> DeletecartAndWishlist(int cartAndWishlistid)
        {
            await _CartAndWishlist.DeleteCartAndWishlist(cartAndWishlistid);
            return NoContent();
        }

    }
}
