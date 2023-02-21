using Microsoft.EntityFrameworkCore;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;

namespace SimpleSale.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(SimpleSaleDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _dbContext.Categories.ToListAsync();
        }
    }
}
