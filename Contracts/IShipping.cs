using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IShipping
    {
        Task<IEnumerable<Shipping>> GetShippings();
        Task<Shipping> GetShippingId(int ShippingId);
        Task<Shipping> AddShipping(Shipping shipping);
        Task<Shipping> UpdateShipping(Shipping shipping);
        Task DeleteShipping(int ShippingId);

    }
}
