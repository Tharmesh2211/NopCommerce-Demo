using Contracts;
using Entites.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class InventoryRepo : IInventory
    {
        private readonly DataContext appDbContext;

        public InventoryRepo(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Inventory>> GetInventory()
        {
            return await appDbContext.Inventory.ToListAsync();
        }

        public async Task<Inventory> GetInventorybyId(int Id)
        {
            return await appDbContext.Inventory
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<Inventory> AddInventory(Inventory inventory)
        {
            var result = await appDbContext.Inventory.AddAsync(inventory);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Inventory> UpdateInventory(Inventory inventory)
        {
            var result = await appDbContext.Inventory
                .FirstOrDefaultAsync(p => p.Id == inventory.Id);

            if (result != null)
            {

                result.warehouse = inventory.warehouse;
                result.Stockquantity = inventory.Stockquantity;
                result.Allowedquantities = inventory.Allowedquantities;
                result.CreatedAt = inventory.CreatedAt;
                result.CreatedBy = inventory.CreatedBy;
                result.ModifiedBy = inventory.ModifiedBy;
                result.ModifiedAt = inventory.ModifiedAt;
                result.IsDeleted = inventory.IsDeleted;
                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task DeleteInventory(int Id)
        {
            var result = await appDbContext.Inventory
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.Inventory.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
        }

        public Task<IQueryable<Inventory>> SearchyByStockQuantity(int sq)
        {
            var query = from value in appDbContext.Inventory
                        where value.Stockquantity > 3
                        select value;

            return (Task<IQueryable<Inventory>>)query;
        }
    }
}