using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ITax
    {
        Task<IEnumerable<Tax>> GetTax();
        Task<Tax> GetTaxId(int taxId);
        Task<Tax> AddTax(Tax tax);
        Task<Tax> UpdateTax(Tax tax);
        Task DeleteTax(int taxId);
    }
}
