using Contracts;
using Entites.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository_Pattern
{
    public class ParentCategoryRepository : IParentCategory
    {
        private readonly DataContext _dataContext;

        //AllNopClasses nopClasses = new AllNopClasses();
        public ParentCategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<ParentCategory>> GetParentCategory()
        {
            try
            {
                if (_dataContext.ParentCategory.Any())
                {
                    var result = await (from value in _dataContext.ParentCategory
                                        where value.IsDeleted.Equals(true)
                                        select value).ToListAsync();

                    return result;
                }
                return Enumerable.Empty<ParentCategory>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public async Task<IEnumerable<ParentCategory>> GetParentCategoryId(int ParentCategoryId)
        {
            try
            {
                if (_dataContext.ParentCategory.Any())
                {
                    var result = await (from value in _dataContext.ParentCategory
                                        where value.Id == ParentCategoryId && value.IsDeleted.Equals(true)
                                        select value).ToListAsync();
                    return result;
                }
                return Enumerable.Empty<ParentCategory>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public async Task<ParentCategory> AddParentCategory(ParentCategory parentCategory)
        {
            try
            {
                if (parentCategory == null)
                {
                    parentCategory = new ParentCategory();
                    return await AddMethod(parentCategory);
                }
                else
                {
                    return await AddMethod(parentCategory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<IEnumerable<ParentCategory>> UpdateParentCategory(ParentCategory parentCategory)
        {
            try
            {
                if (_dataContext.ParentCategory.Any())
                {
                    var result = await _dataContext.ParentCategory
                        .FirstOrDefaultAsync(e => e.Id == parentCategory.Id);

                    if (result != null)
                    {
                        result.Parent_Category_Name = parentCategory.Parent_Category_Name;
                        result.Description = parentCategory.Description;
                        result.parentCategories = parentCategory.parentCategories;
                        result.ModifiedAt = parentCategory.ModifiedAt;
                        result.ModifiedBy = parentCategory.ModifiedBy;
                        result.IsDeleted = parentCategory.IsDeleted;

                        await _dataContext.SaveChangesAsync();

                        return new List<ParentCategory> { result };
                    }

                    return Enumerable.Empty<ParentCategory>();
                }
                return Enumerable.Empty<ParentCategory>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public async Task<IEnumerable<ParentCategory>> DeleteParentCategory(int parentCategoryId)
        {
            try
            {
                if (_dataContext.ParentCategory.Any())
                {
                    var result = await _dataContext.ParentCategory
                      .FirstOrDefaultAsync(e => e.Id == parentCategoryId);

                    if (result != null && result.IsDeleted)
                    {
                        result.IsDeleted = false;
                        await _dataContext.SaveChangesAsync();
                        return new List<ParentCategory> { result };
                    }
                    return Enumerable.Empty<ParentCategory>();
                }
                return Enumerable.Empty<ParentCategory>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ParentCategory> AddMethod(ParentCategory parentCategory)
        {
            try
            {
                var result = await _dataContext.ParentCategory.AddAsync(parentCategory);
                await _dataContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Task<IQueryable<ParentCategory>> GetParentCategoryByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}