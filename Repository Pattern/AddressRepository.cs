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
    public class AddressRepository : IAddress
    {
        private readonly DataContext _context;
        public AddressRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Address> AddAddress(Address address)
        {
            var result = await _context.Address.AddAsync(address);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteAddress(int Id)
        {
            var result = await _context.Address.FirstOrDefaultAsync(t => t.Id == Id);
            if (result != null)
            {
                _context.Address.Remove(result);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Address>> GetAddress()
        {
            return await _context.Address.ToListAsync();
        }

        public async Task<Address> GetAddressbyId(int Id)
        {
            return await _context.Address.FirstOrDefaultAsync(t => t.Id == Id);
        }

        public async Task<Address> UpdateAddress(Address address)
        {
            var result = await _context.Address.FirstOrDefaultAsync(t => t.Id == address.Id);
            if (result != null)
            {
                result.CreatedBy = address.CreatedBy;
                result.ModifiedBy = address.ModifiedBy;
                result.PhoneNumber = address.PhoneNumber;
                result.Email = address.Email;
                result.FaxNumber = address.FaxNumber;

                await _context.SaveChangesAsync();
                return result;

            }
            return null;
        }
    }
}
