using SimpleSale.Application.DTOs.Categories;
using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryResponseDto>> GetCategoriesAsync();

        Task<Category> GetCategoryAsync(Guid id);

        Task<Category> CreateAsync(Category brand);

        Task UpdateAsync(Category brand);

        Task DeleteAsync(Guid id);
    }
}
