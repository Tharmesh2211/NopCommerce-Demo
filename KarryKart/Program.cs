using Contracts;
using Entites.Data;
using Entites.Models;
using Entites.Models.Customer;
using KarryKart.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository_Pattern;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(optionsAction: options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDB")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]!))
    };
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(optionsAction: options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectDB")));
builder.Services.AddScoped<IParentCategory, ParentCategoryRepository>();
builder.Services.AddScoped<ICategory, CategoryRepository>();
builder.Services.AddScoped<IManufactures, ManufacturerRepository>();
builder.Services.AddScoped<IProduct, ProductRepository>();
builder.Services.AddScoped<ITax, TaxRepository>();
builder.Services.AddScoped<IShipping, ShippingRepository>();
builder.Services.AddScoped<IVendor, VendorRepository>();
builder.Services.AddScoped<IDiscounts, DiscountRepository>();
builder.Services.AddScoped<IRental, RentalRepository>();
builder.Services.AddScoped<IDownload, DownloadRepo>();
builder.Services.AddScoped<IGiftCard, GiftCardRepository>(); 
builder.Services.AddScoped<IInventory, InventoryRepository>();
builder.Services.AddScoped<ISEO, SEORepository>();
builder.Services.AddScoped<IRecurringProduct, RecurringProductRepository>();
builder.Services.AddScoped<ICartAndWishlist, CartAndWishlistRepository>();
builder.Services.AddScoped<ICustomerRoleService, CustomerRoleRepository>();
builder.Services.AddScoped<IOrders, OrderRepository>();
builder.Services.AddScoped<IStockSubscriptions, StockSubscriptionsRepository>();
builder.Services.AddScoped<IOnlineCustomer, OnlineCustomerRepository>();
builder.Services.AddScoped<IRewardPointservices, RewardPointRepository>();
builder.Services.AddScoped<IAddress, AddressRepository>();
builder.Services.AddScoped<ICustomerInfo, CustomerInfoRepository>();

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
