using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;

namespace SimpleSale.Infrastructure.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(SimpleSaleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
