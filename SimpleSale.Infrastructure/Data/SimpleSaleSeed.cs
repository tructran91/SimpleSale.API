using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Infrastructure.Data
{
    public class SimpleSaleSeed
    {
        public static async Task SeedAsync(SimpleSaleDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(GetPreconfiguredCategories());
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(GetPreconfiguredProducts());
                await context.SaveChangesAsync();
            }
        }

        private static IEnumerable<Category> GetPreconfiguredCategories()
        {
            return new List<Category>()
            {
                new Category() { Id = Guid.Parse("8ac51586-431d-4642-8435-5926cb6c04f4"), Name = "Phone"},
                new Category() { Id = Guid.Parse("6e688a5b-c6f0-43b1-a2df-0aa8f824d57e"), Name = "TV"}
            };
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>();
        }
    }
}
