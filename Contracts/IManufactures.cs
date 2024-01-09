using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IManufactures
    {
        Task<IEnumerable<Manufacturer>> GetManufacturer();
        Task<Manufacturer> GetManufacturerId(int manufacturerid);
        Task<Manufacturer> AddManufacturer(Manufacturer manufacturer);
        Task<Manufacturer> UpdateManufacturer(Manufacturer manufacturer);
        Task DeleteManufacturer(int manufacturerid);
    }
}
