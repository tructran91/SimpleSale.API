using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<Brand>> GetBrandsAsync()
        {
            return await _brandRepository.GetAllAsync();
        }

        public async Task<Brand> GetBrandAsync(Guid id)
        {
            return await _brandRepository.GetByIdAsync(id);
        }

        public async Task<Brand> CreateAsync(Brand brand)
        {
            return await _brandRepository.AddAsync(brand);
        }

        public async Task UpdateAsync(Brand brand)
        {
            await _brandRepository.UpdateAsync(brand);
        }

        public async Task DeleteAsync(Guid id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            if (brand != null)
            {
                await _brandRepository.DeleteAsync(brand);
            }
        }
    }
}
