using Microsoft.EntityFrameworkCore;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Infrastructure.Data
{
    public class SimpleSaleDbContext : DbContext
    {
        public SimpleSaleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
