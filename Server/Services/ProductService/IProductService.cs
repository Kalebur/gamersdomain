using gamersdomain.Shared;

namespace gamersdomain.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task AddProduct(Product product);
    }
}
