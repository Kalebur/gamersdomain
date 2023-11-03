using gamersdomain.Server.Services.ProductService;
using gamersdomain.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gamersdomain.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var result = await _productService.GetAllProducts();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Product product)
        {
            await _productService.AddProduct(product);
            return Ok("Product added!");
        }

        [HttpGet("category/{categoryName}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryName)
        {
            var result = await _productService.GetProductsByCategory(categoryName);
            return Ok(result);
        }
    }
}
