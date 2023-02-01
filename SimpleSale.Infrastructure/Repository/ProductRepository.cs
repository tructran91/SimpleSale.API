using Microsoft.EntityFrameworkCore;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;

namespace SimpleSale.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SimpleSaleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
