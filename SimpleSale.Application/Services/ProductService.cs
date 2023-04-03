using AutoMapper;
using SimpleSale.Application.Common;
using SimpleSale.Application.DTOs;
using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Application.DTOs.Products;
using SimpleSale.Application.Exceptions;
using SimpleSale.Application.Extensions;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    // TODO : add validation , authorization, logging, exception handling etc. -- cross cutting activities in here.
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IAppLogger<ProductService> _logger;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IAppLogger<ProductService> logger, IMapper mapper)
        {
            _productRepository = productRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<PaginatedData<ProductDto>> QueryProductsAsync(ProductCriteriaDto criteria)
        {
            var products = _productRepository.GetAsync(t => t.Name.ToLower().Contains(criteria.SearchKeyword.ToLower()),
                criteria.SortDirection == SortDirection.Ascending ? t => t.OrderBy(criteria.SortColumn) : t => t.OrderByDescending(criteria.SortColumn), null,
                criteria.PageNumber, criteria.PageSize);

            var numberOfProducts = _productRepository.CountAsync(t => t.Name.ToLower().Contains(criteria.SearchKeyword.ToLower()));

            Task.WhenAll(products, numberOfProducts);

            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products.Result);

            return new PaginatedData<ProductDto>(productsDto, numberOfProducts.Result);
        }

        public async Task<ProductDto> GetProductAsync(Guid productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            var editedProduct = await _productRepository.GetAsync(t => t.Slug == productDto.Name.Slugify());
            if (editedProduct != null)
                throw new DuplicateException();

            var product = _mapper.Map<Product>(productDto);
            product.Slug = product.Name.Slugify();

            var createdProduct = await _productRepository.AddAsync(product);
            return _mapper.Map<ProductDto>(createdProduct);
        }

        public async Task UpdateAsync(Product product)
        {
            ValidateProductIfNotExist(product);

            var editProduct = await _productRepository.GetByIdAsync(product.Id);
            if (editProduct == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await _productRepository.UpdateAsync(editProduct);
            _logger.LogInformation($"Entity successfully updated - AspnetRunAppService");
        }

        public async Task DeleteAsync(Product product)
        {
            ValidateProductIfNotExist(product);
            var deletedProduct = await _productRepository.GetByIdAsync(product.Id);
            if (deletedProduct == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await _productRepository.DeleteAsync(deletedProduct);
            _logger.LogInformation($"Entity successfully deleted - AspnetRunAppService");
        }

        private async Task ValidateProductIfExist(Product product)
        {
            var existingEntity = await _productRepository.GetByIdAsync(product.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{product.ToString()} with this id already exists");
        }

        private void ValidateProductIfNotExist(Product product)
        {
            var existingEntity = _productRepository.GetByIdAsync(product.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{product.ToString()} with this id is not exists");
        }
    }
}
