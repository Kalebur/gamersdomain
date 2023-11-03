using gamersdomain.Shared;

namespace gamersdomain.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
    }
}
