using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRental
    {
        Task<IEnumerable<Rental>> GetRental();
        Task<Rental> GetRentalbyId(int Id);
        Task<Rental> AddRental(Rental rental);
        Task<Rental> UpdateRental(Rental rental);
        Task DeleteRental(int Id);
    }
}
