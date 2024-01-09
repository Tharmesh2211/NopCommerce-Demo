using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProduct
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int prodId);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(int prodId);
    }
}
