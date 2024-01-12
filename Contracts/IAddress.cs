using Entites.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAddress
    {
        Task<IEnumerable<Address>> GetAddress();
        Task<Address> GetAddressbyId(int Id);
        Task<Address> AddAddress(Address address);
        Task<Address> UpdateAddress(Address address);
        Task DeleteAddress(int Id);
    }
}
