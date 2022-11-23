using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoryList();
    }
}
