using AutoMapper;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.Exceptions;
using SimpleSale.Application.Extensions;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<List<BrandDto>> GetBrandsAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            return _mapper.Map<List<BrandDto>>(brands);
        }

        public async Task<BrandDto> GetBrandAsync(Guid id)
        {
            var brand = await _brandRepository.GetByIdAsync(id);
            return _mapper.Map<BrandDto>(brand);
        }

        public async Task<BrandDto> CreateAsync(BrandDto brandDto)
        {
            var brand = _mapper.Map<Brand>(brandDto);
            brand.Slug = brand.Name.Slugify();

            var createdBrand = await _brandRepository.AddAsync(brand);
            return _mapper.Map<BrandDto>(createdBrand);
        }

        public async Task UpdateAsync(BrandDto brandDto)
        {
            var editBrand = await _brandRepository.GetByIdAsync(brandDto.Id.Value);
            if (editBrand == null)
                throw new NotFoundException("Brand could not be loaded.");

            _mapper.Map<BrandDto, Brand>(brandDto, editBrand);
            editBrand.Slug = editBrand.Name.Slugify();

            await _brandRepository.UpdateAsync(editBrand);
        }
    }
}
