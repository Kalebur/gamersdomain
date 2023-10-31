﻿using gamersdomain.Shared;

namespace gamersdomain.Client.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
    }
}
