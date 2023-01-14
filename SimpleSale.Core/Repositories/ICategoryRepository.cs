using SimpleSale.Core.Entities.Catalog;

namespace SimpleSale.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<List<Category>> GetCategoriesAsync();
    }
}
