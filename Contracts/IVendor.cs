using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IVendor
    {
      
            Task<IEnumerable<Vendors>> GetVendors();
            Task<Vendors> GetVendorId(int vendorid);
            Task<Vendors> AddVendor(Vendors vendor);
            Task<Vendors> UpdateVendor(Vendors vendor);
            Task DeleteVendor(int vendorid);
    }
}
