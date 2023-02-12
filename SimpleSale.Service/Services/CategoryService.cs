using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Interfaces;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryResponseDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            var categoriesDto = new List<CategoryResponseDto>();

            foreach (var category in categories)
            {
                var categoryDto = new CategoryResponseDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    DisplayName = category.Name,
                    MetaTitle = category.MetaTitle,
                    MetaKeywords = category.MetaKeywords,
                    MetaDescription = category.MetaDescription,
                    Description = category.Description,
                    IncludeInMenu = category.IncludeInMenu,
                    IsPublished = category.IsPublished,
                    DisplayOrder = category.DisplayOrder,
                    ParentId= category.ParentId,
                };

                var parentCategory = category.Parent;
                while (parentCategory != null)
                {
                    categoryDto.DisplayName = $"{parentCategory.Name} >> {categoryDto.DisplayName}";
                    parentCategory = parentCategory.Parent;
                }

                categoriesDto.Add(categoryDto);
            }

            return categoriesDto.OrderBy(x => x.DisplayName).ToList();
        }

        public async Task<Category> GetCategoryAsync(Guid id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> CreateAsync(Category brand)
        {
            return await _categoryRepository.AddAsync(brand);
        }

        public async Task UpdateAsync(Category brand)
        {
            await _categoryRepository.UpdateAsync(brand);
        }

        public async Task DeleteAsync(Guid id)
        {
            var brand = await _categoryRepository.GetByIdAsync(id);
            if (brand != null)
            {
                await _categoryRepository.DeleteAsync(brand);
            }
        }
    }
}
