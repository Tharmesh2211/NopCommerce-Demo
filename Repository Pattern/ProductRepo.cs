using Contracts;
using Entites.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class ProductRepo : IProduct
    {
        private readonly DataContext _dataContext;
        public ProductRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _dataContext.Product.ToListAsync();
        }
        public async Task<Product> GetProductById(int Id)
        {
            return await _dataContext.Product.FirstOrDefaultAsync(e => e.Id == Id);
        }
        public async Task<Product> AddProduct(Product product)
        {
            var result = await _dataContext.Product.AddAsync(product);
            await _dataContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await _dataContext.Product
                .FirstOrDefaultAsync(e => e.Id == product.Id);

            if (result != null)
            {
                result.Name = product.Name;
                result.ShortDescription = product.ShortDescription;
                result.FullDescription = product.FullDescription;
                result.SKU = product.SKU;
                result.CategoryId = product.CategoryId;
                result.ManufacturerId = product.ManufacturerId;
                result.Published = product.Published;
                result.ProductTags = product.ProductTags;
                result.GTINNumber = product.GTINNumber;
                result.ManufacturerpartNumber = product.ManufacturerpartNumber;
                result.Showonhomepage = product.Showonhomepage;
                result.ProductType = product.ProductType;
                result.ProductTemplate = product.ProductTemplate;
                result.VisibleIndividualy = product.VisibleIndividualy;
                result.CustomerRoles = product.CustomerRoles;
                result.LimitedToStores = product.LimitedToStores;
                result.RequireotherProducts = product.RequireotherProducts;
                result.RequiredproductIDs = product.RequiredproductIDs;
                result.Automaticallyaddproductstocart = product.Automaticallyaddproductstocart;
                result.Allowcustomerreviews = product.Allowcustomerreviews;
                result.AvailableStartDate = product.AvailableStartDate;
                result.AvailableEndDate = product.AvailableEndDate;
                result.MarkAsNew = product.MarkAsNew;
                result.AdminComment = product.AdminComment;
                result.CreatedAt = product.CreatedAt;
                result.CreatedBy = product.CreatedBy;
                result.ModifiedAt = product.ModifiedAt;
                result.ModifiedBy = product.ModifiedBy;
                result.IsDeleted = product.IsDeleted;


                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task DeleteProduct(int Id)
        {
            var result = await _dataContext.Product
                .FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                _dataContext.Product.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
