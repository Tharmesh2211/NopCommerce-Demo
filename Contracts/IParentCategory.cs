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
        Task<ParentCategory> GetParentCategoryId(int parcatgId);
        Task<ParentCategory> AddParentCategory(ParentCategory parcatg);
        Task<ParentCategory> UpdateParentCategory(ParentCategory parcatg);
        Task DeleteParentCategory(int parcatgId);
        Task<IQueryable<ParentCategory>> GetParentCategoryByName(string name);

    }
}
