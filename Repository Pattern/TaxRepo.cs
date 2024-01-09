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
    public class TaxRepo : ITax
    {
        private readonly DataContext _dataContext;
        public TaxRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Tax>> GetTax()
        {
            return await _dataContext.Taxes.ToListAsync();
        }
        public async Task<Tax> GetTaxId(int Id)
        {
            return await _dataContext.Taxes.FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task<Tax> AddTax(Tax tax)
        {
            var result = await _dataContext.Taxes.AddAsync(tax);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Tax> UpdateTax(Tax tax)
        {
            var result = await _dataContext.Taxes
                .FirstOrDefaultAsync(e => e.Id == tax.Id);

            if (result != null)
            {
                result.TaxCode = tax.TaxCode;
                result.SGSTPercentage = tax.SGSTPercentage;
                result.CGSTPercentage = tax.CGSTPercentage;
                result.created_at = tax.created_at;
                result.Created_By = tax.Created_By;
                result.ModifiedAt = tax.ModifiedAt;
                result.ModifiedBy = tax.ModifiedBy;
                result.IsDeleted = tax.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteTax(int Id)
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
