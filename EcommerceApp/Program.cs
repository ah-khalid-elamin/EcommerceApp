using EcommerceApp.Models;
using EcommerceApp.Services;
using EcommerceApp.Services.ProductsServices;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  //location of the exe file
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = configurationBuilder.Build();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DBContext>(opt =>
    opt.UseSqlServer(configuration.GetConnectionString("ECommerceDB")));

//Services
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProductServices, ProductServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
