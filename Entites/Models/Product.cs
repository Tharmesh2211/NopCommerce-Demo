using Entites.Enums;
using Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string SKU { get; set; }
        public double price { get; set; }
        public double OldPrice { get; set; }
        public double productCost { get; set; }
        public bool DisableBuyButton { get; set; }
        public bool DisableWishListButton { get; set; }
        public bool AvailableForPreOrder { get; set; }
        public DateTime PreOrderAvailablityStartDate { get; set; }
        public bool CallForPrice { get; set; }
        public bool CustomerEnterPrice { get; set; }
        public double MinAmount { get; set; }
        public double MaxAmount { get; set; }
        public bool pangvBasePriceEnable { get; set; }
        public double AmountInProduct { get; set; }
        // enum
        public UnitOfProduct unitOfProduct { get; set; }

        public double ReferenceAmount { get; set; }
        //enum
        public ReferenceUnitEnum ReferenceUnit { get; set; }
        //
        public bool Published { get; set; }
        public string ProductTags { get; set; }
        public int GTINNumber { get; set; }
        public int ManufacturerpartNumber { get; set; }
        public bool Showonhomepage { get; set; }
        // Enum
        [Column(TypeName = "nvarchar(100)")]
        public ProductTypeEnum ProductType { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public ProductTemplateEnum ProductTemplate { get; set; }
        public bool VisibleIndividualy { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public CustomerRolesEnum CustomerRoles { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public limitedToStoresEnum LimitedToStores { get; set; }

        public bool RequireotherProducts { get; set; }
        public int RequiredproductIDs { get; set; }
        public bool Automaticallyaddproductstocart { get; set; }
        public bool Allowcustomerreviews { get; set; }
        public DateTime AvailableStartDate { get; set; }
        public DateTime AvailableEndDate { get; set; }
        public bool MarkAsNew { get; set; }
        public string AdminComment { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool TaxExpempt { get; set; }

        public bool TelecommunicationBoardCastingAndElectronicServices { get; set; }

    }

    public partial class Product

    {


        // fORGIN kEY
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        // FORIGN KEY
        public int DiscountId { get; set; }
        public Discount discount { get; set; }
        // forgin key
        public int VendorId { get; set; }
        public Vendors Vendor { get; set; }
        // forgin key
        public int GiftCardID { get; set; }
        public GiftCard GiftCard { get; set; }
        // forgin key
        public int RecurringProductsId { get; set; }
        public Recurring_Product RecurringProducts { get; set; }

        //forgin key

        public int RentalId { get; set; }
        public Rental Rental { get; set; }
        //forgin key
        public int SeoId { get; set; }
        public SEO SEO { get; set; }
        //forgin key

        public int downloadableProductID { get; set; }
        public DownloadableProduct DownloadableProduct { get; set; }
        //forgin key
        public int ShippingId { get; set; }
        public Shipping Shipping { get; set; }

        //forgin key
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }

    }


}
