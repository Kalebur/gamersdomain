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
        public async Task<List<Product>> GetAllProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }
    }
}
