using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IParentCategory
    {
        Task<IEnumerable<ParentCategory>> GetParentCategory();
        Task<IEnumerable<ParentCategory>> GetParentCategoryId(int ParentCategoryId);
        Task<ParentCategory> AddParentCategory(ParentCategory ParentCategory);
        Task<IEnumerable<ParentCategory>> UpdateParentCategory(ParentCategory ParentCategory);
        Task<IEnumerable<ParentCategory>> DeleteParentCategory(int ParentCategoryId);
        Task<IQueryable<ParentCategory>> GetParentCategoryByName(string name);

    }
}
