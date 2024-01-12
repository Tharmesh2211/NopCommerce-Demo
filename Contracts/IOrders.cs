using Entites.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOrders
    {
        Task<IEnumerable<Orders>> GetOrders();
        Task<Orders> GetOrdersbyId(int Id);
        Task<Orders> AddOrders(Orders orders);
        Task<Orders> UpdateOrders(Orders orders);
        Task<Orders> DeleteOrders(int Id);
        Task<IQueryable<Orders>> GetOrdersByName(string name);


    }
}
