using BlogApplication.Business.Abstract;
using BlogApplication.Business.Concreate;
using BlogApplication.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.API.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllCategories()
        {
            var categories = await _categoryManager.GetAllAsync();
            return Ok(categories);
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<string>> GetCategoryNameById(int id)
        {
            var tagName = await _categoryManager.GetCategoryNameById(id);
            return Ok(tagName);
        }

    }
}
