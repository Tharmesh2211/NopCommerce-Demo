using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRecurringProduct
    {
        Task<IEnumerable<Recurring_Product>> GetRecurringProduct();
        Task<Recurring_Product> GetRecurringProductById(int RecurringProductId);
        Task<Recurring_Product> AddRecurringProduct(Recurring_Product RecurringProduct);
        Task<Recurring_Product> UpdateRecurringProduct(Recurring_Product RecurringProduct);
        Task DeleteRecurringProduct(int RecurringProductId);
    }
}
