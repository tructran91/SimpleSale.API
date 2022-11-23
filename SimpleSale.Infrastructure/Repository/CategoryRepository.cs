using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;

namespace SimpleSale.Infrastructure.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(SimpleSaleDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Category> GetCategoryWithProductsAsync(Guid categoryId)
        {
            //var spec = new CategoryWithProductsSpecification(categoryId);
            //var category = (await GetAsync(spec)).FirstOrDefault();
            return new Category();
        }
    }
}
