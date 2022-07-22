using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Business;
using ProjectTracker.Dtos.Requests;

namespace ProjectTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetCategories();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateCategoryRequest createCategoryRequest)
        {
            if (ModelState.IsValid)
            {
                var id = await _categoryService.CreateCategory(createCategoryRequest);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = id }, null);
            }
            return BadRequest(ModelState);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetCategory(id);
            return Ok(category);
        }

    }
}
