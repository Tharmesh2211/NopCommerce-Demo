using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDiscounts
    {
        Task<IEnumerable<Discount>> GetDiscounts();
        Task<Discount> GetDiscountId(int discountid);
        Task<Discount> AddDiscount(Discount discount);
        Task<Discount> UpdateDiscounts(Discount discount);
        Task DeleteDiscounts(int discountid); 
    }
}
