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
        Task<Category> GetCategoryId(int parcatgId);
        Task<Category> AddCategory(Category parcatg);
        Task<Category> UpdateCategory(Category parcatg);
        Task<IQueryable<Category>> SearchyByValues(string name);
        Task DeleteCategory(int parcatgId);
    }
}
