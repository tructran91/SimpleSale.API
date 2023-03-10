using Microsoft.EntityFrameworkCore;
using SimpleSale.Application;
using SimpleSale.Application.Interfaces;
using SimpleSale.Application.Services;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;
using SimpleSale.Infrastructure.Logging;
using SimpleSale.Infrastructure.Repositories;

namespace SimpleSale.API.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCorsAllowAny(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new() { Title = "Sale API", Version = "v1" });
            });
        }

        public static void AddLayerForApp(this WebApplicationBuilder builder)
        {
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
            builder.Services.AddAutoMapper(typeof(ModelMappingProfiles));
            builder.Services.AddAutoMapper(typeof(DtoMappingProfile));
        }
    }
}
