namespace gamersdomain.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
    }
}
