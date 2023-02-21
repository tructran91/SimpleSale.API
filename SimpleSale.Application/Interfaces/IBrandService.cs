using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface IBrandService
    {
        Task<List<Brand>> GetBrandsAsync();

        Task<Brand> GetBrandAsync(Guid id);

        Task<Brand> CreateAsync(Brand brand);

        Task UpdateAsync(Brand brand);

        Task DeleteAsync(Guid id);
    }
}
