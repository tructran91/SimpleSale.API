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

        public ProductService(IProductRepository productRepository, IAppLogger<ProductService> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Product>> GetProductList()
        {
            return await _productRepository.GetProductListAsync();
        }

        public async Task<Product> GetProductById(Guid productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetProductByName(string productName)
        {
            return await _productRepository.GetProductByNameAsync(productName);
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(Guid categoryId)
        {
            return await _productRepository.GetProductByCategoryAsync(categoryId);
        }

        public async Task<Product> Create(Product product)
        {
            await ValidateProductIfExist(product);

            var newEntity = await _productRepository.AddAsync(product);
            _logger.LogInformation($"Entity successfully added - AspnetRunAppService");

            return newEntity;
        }

        public async Task Update(Product product)
        {
            ValidateProductIfNotExist(product);

            var editProduct = await _productRepository.GetByIdAsync(product.Id);
            if (editProduct == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await _productRepository.UpdateAsync(editProduct);
            _logger.LogInformation($"Entity successfully updated - AspnetRunAppService");
        }

        public async Task Delete(Product product)
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
