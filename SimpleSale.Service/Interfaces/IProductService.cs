using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductList();
        Task<Product> GetProductById(Guid productId);
        Task<IEnumerable<Product>> GetProductByName(string productName);
        Task<IEnumerable<Product>> GetProductByCategory(Guid categoryId);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
