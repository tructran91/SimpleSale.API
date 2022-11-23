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

        public async Task<IEnumerable<Product>> GetProductListAsync()
        {
            //var spec = new ProductWithCategorySpecification();
            //return await GetAsync(spec);

            // second way
            return await GetAllAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
            //var spec = new ProductWithCategorySpecification(productName);
            //return await GetAsync(spec);

            // second way
            return await GetAsync(x => x.Name.ToLower().Contains(productName.ToLower()));

            // third way
            //return await _dbContext.Products
            //    .Where(x => x.ProductName.Contains(productName))
            //    .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(Guid categoryId)
        {
            return await _dbContext.Products
                .ToListAsync();
        }
    }
}
