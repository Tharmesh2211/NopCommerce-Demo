using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IInventory
    {
        Task<IEnumerable<Inventory>> GetInventory();
        Task<Inventory> GetInventorybyId(int Id);
        Task<Inventory> AddInventory(Inventory inventory);
        Task<Inventory> UpdateInventory(Inventory inventory);
        Task<IQueryable<Inventory>> SearchyByStockQuantity(int sq);

        Task DeleteInventory(int Id);
    }
}
