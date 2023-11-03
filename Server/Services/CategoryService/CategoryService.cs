using gamersdomain.Server.Data;
using gamersdomain.Shared;
using Microsoft.EntityFrameworkCore;

namespace gamersdomain.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<List<Category>> GetAllCategories()
        {
            var response = await _dataContext.Categories.ToListAsync();
            return response;
        }
    }
}
