using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface IBrandService
    {
        Task<List<BrandDto>> GetBrandsAsync();

        Task<BrandDto> GetBrandAsync(Guid id);

        Task<BrandDto> CreateAsync(BrandDto brand);

        Task UpdateAsync(BrandDto brand);
    }
}
