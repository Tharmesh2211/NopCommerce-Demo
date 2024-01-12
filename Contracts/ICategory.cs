using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICategory
    {
        Task<IEnumerable<Category>> GetCategory();
        Task<Category> GetCategoryId(int CategoryId);
        Task<Category> AddCategory(Category Category);
        Task<Category> UpdateCategory(Category Category);
        Task<IQueryable<Category>> SearchyByValues(string name);
        Task DeleteCategory(int CategoryId);
    }
}
