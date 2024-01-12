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
    public class CustomerRoleRepository : ICustomerRoleService
    {
        private readonly DataContext _context;
        public CustomerRoleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<CustomerRole> AddCustomerRole(CustomerRole customerRole)
        {
            var result = await _context.CustomerRoles.AddAsync(customerRole);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteCustomerRole(int Id)
        {
            var result = await _context.CustomerRoles.FirstOrDefaultAsync(t => t.Id == Id);
            if (result != null)
            {
                _context.CustomerRoles.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CustomerRole>> GetCustomerRole()
        {
            return await _context.CustomerRoles.ToListAsync();
        }

        public async Task<CustomerRole> GetCustomerRoleById(int Id)
        {
            return await _context.CustomerRoles.FirstOrDefaultAsync(t => t.Id == Id);
        }

        public async Task<CustomerRole> UpdateCustomerRole(CustomerRole customerRole)
        {
            var result = await _context.CustomerRoles.FirstOrDefaultAsync(t => t.Id == customerRole.Id);
            if (result != null)
            {
                result.Name = customerRole.Name;
                result.FreeShipping = customerRole.FreeShipping;
                result.Taxexempt = customerRole.Taxexempt;
                result.Active = customerRole.Active;
                result.IsSystemRole = customerRole.IsSystemRole;
                result.CreatedAt = customerRole.CreatedAt;
                result.CreatedBy = customerRole.CreatedBy;
                result.ModifiedAt = customerRole.ModifiedAt;
                result.ModifiedBy = customerRole.ModifiedBy;
                result.IsDeleted = customerRole.IsDeleted;
                await _context.SaveChangesAsync();
                return result;

            }
            return null;
        }
    }
}
