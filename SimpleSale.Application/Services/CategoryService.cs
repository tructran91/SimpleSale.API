using AutoMapper;
using SimpleSale.Application.DTOs.Brands;
using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Application.Exceptions;
using SimpleSale.Application.Extensions;
using SimpleSale.Application.Interfaces;
using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;

namespace SimpleSale.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            var categoriesDto = new List<CategoryDto>();

            foreach (var category in categories)
            {
                var categoryDto = new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    DisplayName = category.Name,
                    Slug = category.Slug,
                    MetaTitle = category.MetaTitle,
                    MetaKeywords = category.MetaKeywords,
                    MetaDescription = category.MetaDescription,
                    Description = category.Description,
                    IncludeInMenu = category.IncludeInMenu,
                    IsPublished = category.IsPublished,
                    DisplayOrder = category.DisplayOrder,
                    ParentId = category.ParentId,
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

        public async Task<CategoryDto> GetCategoryAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> CreateAsync(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            category.Slug = category.Name.Slugify();

            var createdCategory = await _categoryRepository.AddAsync(category);
            return _mapper.Map<CategoryDto>(createdCategory);
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            var editCategory = await _categoryRepository.GetByIdAsync(categoryDto.Id.Value);
            if (editCategory == null)
                throw new NotFoundException("Category could not be loaded.");

            _mapper.Map<CategoryDto, Category>(categoryDto, editCategory);
            editCategory.Slug = editCategory.Name.Slugify();

            await _categoryRepository.UpdateAsync(editCategory);
        }
    }
}
