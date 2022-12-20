using SimpleSale.Application.DTOs;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _brandRepository.GetAllAsync();
        }

        public async Task<Brand> GetBrand(BrandCriteriaDto dto)
        {
            return await _brandRepository.GetByIdAsync(dto.Id);
        }

        public async Task<Brand> Create(Brand brand)
        {
            return await _brandRepository.AddAsync(brand);
        }

        public async Task Update(Brand brand)
        {
            await _brandRepository.UpdateAsync(brand);
        }

        public async Task Delete(Guid id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            await _brandRepository.DeleteAsync(brand);
        }
    }
}
