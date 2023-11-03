using gamersdomain.Shared;

namespace gamersdomain.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryName);
        Task AddProduct(Product product);
    }
}
