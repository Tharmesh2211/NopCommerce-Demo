using Entites.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOnlineCustomer
    {
        Task<IEnumerable<OnlineCustomer>> GetOnlineCustomer();
        Task<OnlineCustomer> GetOnlineCustomerbyId(int Id);
        Task<OnlineCustomer> AddOnlineCustomer(OnlineCustomer onlineCustomer);
        Task<OnlineCustomer> UpdateOnlineCustomer(OnlineCustomer onlineCustomer);
        Task<OnlineCustomer> DeleteOnlineCustomer(int Id);
    }
}
