using Entites.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.CheckConditions
{
    public class AllNopClasses
    {
        private readonly DataContext _dataContext;
       
        public bool CheckObjectNullOrNot(object obj)
        {

            if (obj == null)
            {
                return true;
            }
            return false;
        }

        public bool CheckIdPresentOrNot(object id, string objectName)
        {
            if(objectName.Equals("ParentCategory"))
            {
                var findId = from value in _dataContext.ParentCategory
                             where id.Equals(value.Id)
                             select value;

               return findId.Any();

            }
            else if(objectName.Equals("Category"))
            {

                var findId = from value in _dataContext.Category
                             where id.Equals(value.CategoryId)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Rental"))
            {

                var findId = from value in _dataContext.Rental
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Taxes"))
            {

                var findId = from value in _dataContext.Taxes
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Vendors"))
            {

                var findId = from value in _dataContext.Vendors
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Discounts"))
            {

                var findId = from value in _dataContext.Discounts
                             where id.Equals(value.ID)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Address"))
            {

                var findId = from value in _dataContext.Address
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("CartAndWishlist"))
            {

                var findId = from value in _dataContext.CartAndWishlist
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("CustomerInfos"))
            {

                var findId = from value in _dataContext.CustomerInfos
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("CustomerRoles"))
            {

                var findId = from value in _dataContext.CustomerRoles
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("GiftCards"))
            {

                var findId = from value in _dataContext.GiftCards
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("DownloadProduct"))
            {

                var findId = from value in _dataContext.DownloadProduct
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("OnlineCustomers"))
            {

                var findId = from value in _dataContext.OnlineCustomers
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Inventory"))
            {

                var findId = from value in _dataContext.Inventory
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Manufacturer"))
            {

                var findId = from value in _dataContext.Manufacturer
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Orders"))
            {

                var findId = from value in _dataContext.Orders
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Product"))
            {

                var findId = from value in _dataContext.Product
                             where id.Equals(value.CategoryId)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("RecurringProduct"))
            {

                var findId = from value in _dataContext.RecurringProduct
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("RewardPoint"))
            {

                var findId = from value in _dataContext.RewardPoint
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("SEO"))
            {

                var findId = from value in _dataContext.SEO
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("Shipping"))
            {

                var findId = from value in _dataContext.Shipping
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }
            else if (objectName.Equals("StockSubscriptions"))
            {

                var findId = from value in _dataContext.StockSubscriptions
                             where id.Equals(value.Id)
                             select value;

                return findId.Any();
            }

            return false;
        }

       
    }
}
