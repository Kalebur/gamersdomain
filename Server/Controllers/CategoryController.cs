using gamersdomain.Server.Services.CategoryService;
using gamersdomain.Server.Data;
using gamersdomain.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gamersdomain.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }
    }
}
