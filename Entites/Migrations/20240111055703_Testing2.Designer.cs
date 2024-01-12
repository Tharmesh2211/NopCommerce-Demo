﻿// <auto-generated />
using System;
using Entites.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entites.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240111055703_Testing2")]
    partial class Testing2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entites.Models.CartAndWishlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StoreName")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("shoppingCartTypeEnum")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CartAndWishlist");
                });

            modelBuilder.Entity("Entites.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parent_CatgId")
                        .HasColumnType("int");

                    b.Property<int>("TaxID")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("Parent_CatgId");

                    b.HasIndex("TaxID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Entites.Models.Discount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discount_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount_Percent")
                        .HasColumnType("float");

                    b.Property<string>("Discount_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Entites.Models.DownloadableProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DownloadURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Downloadactivationtype")
                        .HasColumnType("int");

                    b.Property<bool>("Hassampledownloadfile")
                        .HasColumnType("bit");

                    b.Property<bool>("Hasuseragreement")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoofDays")
                        .HasColumnType("int");

                    b.Property<bool>("Unlimiteddownloads")
                        .HasColumnType("bit");

                    b.Property<bool>("UsedownloadURL")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DownloadProduct");
                });

            modelBuilder.Entity("Entites.Models.GiftCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Giftcard")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Overriddengiftcardamount")
                        .HasColumnType("float");

                    b.Property<int>("giftcardtype")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GiftCards");
                });

            modelBuilder.Entity("Entites.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Allowbackinstocksubscriptions")
                        .HasColumnType("bit");

                    b.Property<string>("Allowedquantities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Allowonlyexistingattributecombinations")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Displayavailability")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Maximumcartqty")
                        .HasColumnType("int");

                    b.Property<int>("Minimumcartqty")
                        .HasColumnType("int");

                    b.Property<int>("Minimumstockqty")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MultipleWarehouse")
                        .HasColumnType("bit");

                    b.Property<int>("Notifyforqtybelow")
                        .HasColumnType("int");

                    b.Property<bool>("Notreturnable")
                        .HasColumnType("bit");

                    b.Property<int>("Stockquantity")
                        .HasColumnType("int");

                    b.Property<int>("backordersbelow")
                        .HasColumnType("int");

                    b.Property<int>("inventoryMethodEnum")
                        .HasColumnType("int");

                    b.Property<int>("lowstockactivityenum")
                        .HasColumnType("int");

                    b.Property<int>("productavailabilityrange")
                        .HasColumnType("int");

                    b.Property<int>("warehouse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Entites.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("Entites.Models.ParentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parent_Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parentCategories")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ParentCategory");
                });

            modelBuilder.Entity("Entites.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Allowcustomerreviews")
                        .HasColumnType("bit");

                    b.Property<double>("AmountInProduct")
                        .HasColumnType("float");

                    b.Property<bool>("Automaticallyaddproductstocart")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AvailableEndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("AvailableForPreOrder")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AvailableStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CallForPrice")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerEnterPrice")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerRoles")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("DisableBuyButton")
                        .HasColumnType("bit");

                    b.Property<bool>("DisableWishListButton")
                        .HasColumnType("bit");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<string>("FullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GTINNumber")
                        .HasColumnType("int");

                    b.Property<int>("GiftCardID")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LimitedToStores")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerpartNumber")
                        .HasColumnType("int");

                    b.Property<bool>("MarkAsNew")
                        .HasColumnType("bit");

                    b.Property<double>("MaxAmount")
                        .HasColumnType("float");

                    b.Property<double>("MinAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OldPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("PreOrderAvailablityStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<int>("RecurringProductsId")
                        .HasColumnType("int");

                    b.Property<double>("ReferenceAmount")
                        .HasColumnType("float");

                    b.Property<int>("ReferenceUnit")
                        .HasColumnType("int");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.Property<int>("RequiredproductIDs")
                        .HasColumnType("int");

                    b.Property<bool>("RequireotherProducts")
                        .HasColumnType("bit");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeoId")
                        .HasColumnType("int");

                    b.Property<int>("ShippingId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Showonhomepage")
                        .HasColumnType("bit");

                    b.Property<bool>("TaxExpempt")
                        .HasColumnType("bit");

                    b.Property<bool>("TelecommunicationBoardCastingAndElectronicServices")
                        .HasColumnType("bit");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<bool>("VisibleIndividualy")
                        .HasColumnType("bit");

                    b.Property<int>("downloadableProductID")
                        .HasColumnType("int");

                    b.Property<bool>("pangvBasePriceEnable")
                        .HasColumnType("bit");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<double>("productCost")
                        .HasColumnType("float");

                    b.Property<int>("unitOfProduct")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("GiftCardID");

                    b.HasIndex("InventoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("RecurringProductsId");

                    b.HasIndex("RentalId");

                    b.HasIndex("SeoId");

                    b.HasIndex("ShippingId");

                    b.HasIndex("VendorId");

                    b.HasIndex("downloadableProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Entites.Models.Recurring_Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Cycle_Length")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Total_Cycle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RecurringProduct");
                });

            modelBuilder.Entity("Entites.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRental")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RentalPeriod")
                        .HasColumnType("int");

                    b.Property<int>("RentalPeriodLength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rental");
                });

            modelBuilder.Entity("Entites.Models.SEO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaKeywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("searchenginefriendlypagename")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SEO");
                });

            modelBuilder.Entity("Entites.Models.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AdditionalShippingCharges")
                        .HasColumnType("float");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FreeShipping")
                        .HasColumnType("bit");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShippingEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("Shippingseperately")
                        .HasColumnType("bit");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("deliveryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("Entites.Models.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CGSTPercentage")
                        .HasColumnType("float");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SGSTPercentage")
                        .HasColumnType("float");

                    b.Property<string>("TaxCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Entites.Models.Vendors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_number")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Entites.Models.Category", b =>
                {
                    b.HasOne("Entites.Models.ParentCategory", "Parent_Catg")
                        .WithMany()
                        .HasForeignKey("Parent_CatgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Tax", "Tax")
                        .WithMany()
                        .HasForeignKey("TaxID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent_Catg");

                    b.Navigation("Tax");
                });

            modelBuilder.Entity("Entites.Models.Product", b =>
                {
                    b.HasOne("Entites.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Discount", "discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.GiftCard", "GiftCard")
                        .WithMany()
                        .HasForeignKey("GiftCardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Recurring_Product", "RecurringProducts")
                        .WithMany()
                        .HasForeignKey("RecurringProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.SEO", "SEO")
                        .WithMany()
                        .HasForeignKey("SeoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.Vendors", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entites.Models.DownloadableProduct", "DownloadableProduct")
                        .WithMany()
                        .HasForeignKey("downloadableProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("DownloadableProduct");

                    b.Navigation("GiftCard");

                    b.Navigation("Inventory");

                    b.Navigation("Manufacturer");

                    b.Navigation("RecurringProducts");

                    b.Navigation("Rental");

                    b.Navigation("SEO");

                    b.Navigation("Shipping");

                    b.Navigation("Vendor");

                    b.Navigation("discount");
                });
#pragma warning restore 612, 618
        }
    }
}
