using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleSale.API;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;
using SimpleSale.Infrastructure.Logging;
using SimpleSale.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add Infrastructure Layer
builder.Services.AddDbContext<SimpleSaleDbContext>(c =>
    c.UseSqlServer(builder.Configuration.GetConnectionString("SaleConnection")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

// Add Application Layer
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IBrandService, BrandService>();

// Add Web Layer
builder.Services.AddAutoMapper(typeof(MappingProfiles));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Sale API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var aspnetRunContext = scope.ServiceProvider.GetRequiredService<SimpleSaleDbContext>();
    SimpleSaleSeed.SeedAsync(aspnetRunContext).Wait();
}

app.Run();
