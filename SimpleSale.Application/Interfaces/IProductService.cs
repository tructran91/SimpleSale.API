using SimpleSale.Application.Common;
using SimpleSale.Application.DTOs.Products;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface IProductService
    {
        Task<PaginatedData<ProductDto>> QueryProductsAsync(ProductCriteriaDto criteria);

        Task<ProductDto> GetProductAsync(Guid productId);

        Task<ProductDto> CreateProductAsync(ProductDto product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);
    }
}
