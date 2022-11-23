using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAppLogger<CategoryService> _logger;

        public CategoryService(ICategoryRepository categoryRepository, IAppLogger<CategoryService> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<Category>> GetCategoryList()
        {
            var category = await _categoryRepository.GetAllAsync();
            return category;
        }

    }
}
