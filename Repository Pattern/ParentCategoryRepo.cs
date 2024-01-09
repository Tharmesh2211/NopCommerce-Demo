using Contracts;
using Entites.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class ParentCategoryRepo : IParentCategory
    {
        private readonly DataContext _dataContext;
        public ParentCategoryRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ParentCategory> AddParentCategory(ParentCategory parcatg)
        {
            var result = await _dataContext.ParentCategory.AddAsync(parcatg);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteParentCategory(int parcatgId)
        {
            var result = await _dataContext.ParentCategory
                   .FirstOrDefaultAsync(e => e.Id == parcatgId);
            if (result != null)
            {
                _dataContext.ParentCategory.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<ParentCategory>> GetParentCategory()
        {
            return await _dataContext.ParentCategory.ToListAsync();
        }

        public async Task<IQueryable<ParentCategory>> GetParentCategoryByName(string name)
        {

            var query = from value in _dataContext.ParentCategory
                        where value.Parent_Category_Name == name || value.CreatedBy == name
                        select value;

            return query;
        }

        public async Task<ParentCategory> GetParentCategoryId(int parcatgId)
        {
            return await _dataContext.ParentCategory.FirstOrDefaultAsync(e => e.Id == parcatgId);
        }

        public async Task<ParentCategory> UpdateParentCategory(ParentCategory parcatg)
        {
            var result = await _dataContext.ParentCategory
                   .FirstOrDefaultAsync(e => e.Id == parcatg.Id);

            if (result != null)
            {
                result.Parent_Category_Name = parcatg.Parent_Category_Name;
                result.Description = parcatg.Description;
                result.parentCategories = parcatg.parentCategories;
                result.CreatedAt = parcatg.CreatedAt;
                result.CreatedBy = parcatg.CreatedBy;
                result.ModifiedAt = parcatg.ModifiedAt;
                result.ModifiedBy = parcatg.ModifiedBy;
                result.IsDeleted = parcatg.IsDeleted;

                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}