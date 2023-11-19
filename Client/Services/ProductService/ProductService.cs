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

        public async Task<string> AddProduct(Product product)
        {
            var result = await _http.PostAsJsonAsync("api/product", product);
            return result.ToString();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _http.GetFromJsonAsync<List<Product>>("api/product");
            return result ?? new List<Product>();
        }

        public async Task<Product> GetProductById(int productId)
        {
            var result = await _http.GetFromJsonAsync<Product>($"api/product/{productId}");
            return result!;
        }

        public async Task<List<Product>> GetProductsByCategory(string category)
        {
            var result = await _http.GetFromJsonAsync<List<Product>>($"api/product/category/{category}");
            return result ?? new List<Product>();
        }
    }
}
