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
    public class ManufacturerRepository : IManufactures
    {
        private readonly DataContext _dataContext;
        public ManufacturerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Manufacturer>> GetManufacturer()
        {
            return await _dataContext.Manufacturer.ToListAsync();
        }
        public async Task<Manufacturer> GetManufacturerId(int Id)
        {
            return await _dataContext.Manufacturer.FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task<Manufacturer> AddManufacturer(Manufacturer manufacturer)
        {
            var result = await _dataContext.Manufacturer.AddAsync(manufacturer);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Manufacturer> UpdateManufacturer(Manufacturer manufacturer)
        {
            var result = await _dataContext.Manufacturer
                .FirstOrDefaultAsync(e => e.Id == manufacturer.Id);

            if (result != null)
            {
                result.ManufacturerName = manufacturer.ManufacturerName;
                result.MDescription = manufacturer.MDescription;
                result.CreatedAt = manufacturer.CreatedAt;
                result.CreatedBy = manufacturer.CreatedBy;
                result.ModifiedAt = manufacturer.ModifiedAt;
                result.ModifiedBy = manufacturer.ModifiedBy;
                result.IsDeleted = manufacturer.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteManufacturer(int Id)
        {
            var result = await _dataContext.Manufacturer
                .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _dataContext.Manufacturer.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
