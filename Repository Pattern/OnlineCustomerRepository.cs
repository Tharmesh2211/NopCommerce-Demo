using Contracts;
using Entites.Data;
using Entites.Models.Customer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class OnlineCustomerRepository : IOnlineCustomer
    {
        private readonly DataContext appDbContext;

        public OnlineCustomerRepository(DataContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<OnlineCustomer>> GetOnlineCustomer()
        {
            return await appDbContext.OnlineCustomers.ToListAsync();
        }

        public async Task<OnlineCustomer> GetOnlineCustomerbyId(int Id)
        {
            return await appDbContext.OnlineCustomers
                .FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<OnlineCustomer> AddOnlineCustomer(OnlineCustomer onlineCustomer)
        {
            var result = await appDbContext.OnlineCustomers.AddAsync(onlineCustomer);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<OnlineCustomer> UpdateOnlineCustomer(OnlineCustomer onlineCustomer)
        {
            var result = await appDbContext.OnlineCustomers
                .FirstOrDefaultAsync(p => p.Id == onlineCustomer.Id);

            if (result != null)
            {

                result.IPAddress = onlineCustomer.IPAddress;
                result.Location = onlineCustomer.Location;
                result.CreatedBy = onlineCustomer.CreatedBy;
                result.ModifiedBy = onlineCustomer.ModifiedBy;
                result.LastVisitedPage = onlineCustomer.LastVisitedPage;


                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }

        public async Task<OnlineCustomer> DeleteOnlineCustomer(int Id)
        {
            var result = await appDbContext.OnlineCustomers
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (result != null)
            {
                appDbContext.OnlineCustomers.Remove(result);
                await appDbContext.SaveChangesAsync();

            }
            return result;

        }
    }
}
