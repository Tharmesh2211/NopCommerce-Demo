using Contracts;
using Entites.Data;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository_Pattern;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(optionsAction: options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDB")));
builder.Services.AddScoped<IParentCategory, ParentCategoryRepo>();
builder.Services.AddScoped<ICategory, CategoryRepo>();
builder.Services.AddScoped<IManufactures, ManufacturerRepo>();
builder.Services.AddScoped<IProduct, ProductRepo>();
builder.Services.AddScoped<ITax, TaxRepo>();
builder.Services.AddScoped<IShipping, ShippingRepo>();
builder.Services.AddScoped<IVendor, VendorRepo>();
builder.Services.AddScoped<IDiscounts, DiscountRepo>();
builder.Services.AddScoped<IRental, RentalRepo>();
builder.Services.AddScoped<IDownload, DownloadRepo>();
builder.Services.AddScoped<IGiftCard, GiftCardRepo>(); 
builder.Services.AddScoped<IInventory, InventoryRepo>();
builder.Services.AddScoped<ISEO, SEORepo>();
builder.Services.AddScoped<IRecurringProduct, RecurringProductRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
