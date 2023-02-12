using SimpleSale.Core.DTOs.Products;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetProductsAsync(ProductCriteriaDto criteria);
    }
}
