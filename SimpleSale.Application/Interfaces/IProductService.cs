using SimpleSale.Application.DTOs.Products;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> QueryProductsAsync(ProductCriteriaDto criteria);
        Task<Product> GetProductAsync(Guid productId);
        Task<Product> CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
