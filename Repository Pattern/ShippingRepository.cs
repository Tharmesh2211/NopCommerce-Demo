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
    public class ShippingRepository : IShipping
    {
        private readonly DataContext _dataContext;
        public ShippingRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Shipping>> GetShippings()
        {
            return await _dataContext.Shipping.ToListAsync();
        }
        public async Task<Shipping> GetShippingId(int Id)
        {
            return await _dataContext.Shipping.FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task<Shipping> AddShipping(Shipping shipping)
        {
            var result = await _dataContext.Shipping.AddAsync(shipping);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Shipping> UpdateShipping(Shipping shipping)
        {
            var result = await _dataContext.Shipping
                .FirstOrDefaultAsync(e => e.Id == shipping.Id);

            if (result != null)
            {
                result.Width = shipping.Width;
                result.Height = shipping.Height;
                result.Weight = shipping.Weight;
                result.FreeShipping = shipping.FreeShipping;
                result.AdditionalShippingCharges = shipping.AdditionalShippingCharges;
                result.Shippingseperately = shipping.Shippingseperately;
                result.ShippingEnabled = shipping.ShippingEnabled;
                result.created_at = shipping.created_at;
                result.Created_By = shipping.Created_By;
                result.ModifiedAt = shipping.ModifiedAt;
                result.ModifiedBy = shipping.ModifiedBy;
                result.IsDeleted = shipping.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteShipping(int Id)
        {
            var result = await _dataContext.Taxes
                .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _dataContext.Taxes.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
