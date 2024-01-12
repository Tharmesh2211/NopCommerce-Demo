using Entites.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICartAndWishlist
    {
        Task<IEnumerable<CartAndWishlist>> GetCartAndWishlists();
        Task<CartAndWishlist> GetCartAndWishlistId(int cartAndWishlistId);
        Task<CartAndWishlist> AddCartAndWishlist(CartAndWishlist cartAndWishlist);
        Task<CartAndWishlist> UpdateCartAndWishlist(CartAndWishlist cartAndWishlist);
        Task<IQueryable<CartAndWishlist>> SearchyByValues(string name);
        Task DeleteCartAndWishlist(int cartAndWishlistId);
    }
}
