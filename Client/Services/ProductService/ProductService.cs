using gamersdomain.Shared;
using System.Net.Http.Json;

namespace gamersdomain.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Product>>("api/product");
            return result ?? new List<Product>();
        }
    }
}
