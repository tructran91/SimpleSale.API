using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategoriesAsync();

        Task<CategoryDto> GetCategoryAsync(Guid id);

        Task<CategoryDto> CreateCategoryAsync(CategoryDto categoryDto);

        Task UpdateCategoryAsync(CategoryDto categoryDto);
    }
}
