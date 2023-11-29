using gamersdomain.Server.Data;
using gamersdomain.Shared;
using Microsoft.EntityFrameworkCore;

namespace gamersdomain.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public async Task AddProduct(Product product)
        {
            await _dataContext.Products.AddAsync(product);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }

        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _dataContext.Products
                .FromSql($"SELECT * FROM Products WHERE ProductId={id}")
                .ToListAsync();
            if (product is null || product.Count == 0)
            {
                response.Success = false;
                response.Message = $"No product matches ID: {id}";
            }
            else
            {
                response.Data = product.First();
            }
            return response;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryName)
        {
            var response = await _dataContext.Products
                .Where(p => p.Category!.Name.ToLower() == categoryName.ToLower())
                .ToListAsync();
            return response;
        }
    }
}
