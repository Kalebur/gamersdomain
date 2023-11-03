using System.Net.Http.Json;

namespace gamersdomain.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Category>> GetAllCategories()
        {
            var result = await _http.GetFromJsonAsync<List<Category>>("api/category");
            return result!;
        }
    }
}
