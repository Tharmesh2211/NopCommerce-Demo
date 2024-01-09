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
    public class DiscountRepo : IDiscounts
    {
        private readonly DataContext _dataContext;
        public DiscountRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Discount>> GetDiscounts()
        {
            return await _dataContext.Discounts.ToListAsync();
        }
        public async Task<Discount> GetDiscountId(int Id)
        {
            return await _dataContext.Discounts.FirstOrDefaultAsync(e => e.ID == Id);
        }
        public async Task<Discount> AddDiscount(Discount discount)
        {
            var result = await _dataContext.Discounts.AddAsync(discount);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Discount> UpdateDiscounts(Discount discount)
        {
            var result = await _dataContext.Discounts
                .FirstOrDefaultAsync(e => e.ID == discount.ID);

            if (result != null)
            {
                result.Discount_Name = discount.Discount_Name;
                result.Discount_Percent = discount.Discount_Percent;
                result.Discount_Type = discount.Discount_Type;
                result.Start_Date = discount.Start_Date;
                result.End_Date = discount.End_Date;
                result.CreatedAt = discount.CreatedAt;
                result.CreatedBy = discount.CreatedBy;
                result.ModifiedAt = discount.ModifiedAt;
                result.ModifiedBy = discount.ModifiedBy;
                result.IsDeleted = discount.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteDiscounts(int Id)
        {
            var result = await _dataContext.Discounts
                .FirstOrDefaultAsync(e => e.ID == Id);
            if (result != null)
            {
                _dataContext.Discounts.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
