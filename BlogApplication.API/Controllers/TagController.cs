using BlogApplication.Business.Abstract;
using BlogApplication.Business.Concreate;
using BlogApplication.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.API.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class TagController : ControllerBase
    {
        private readonly ITagService _tagManager;

        public TagController(ITagService tagManager)
        {
            _tagManager = tagManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllTags()
        {
            var tags = await _tagManager.GetAllAsync();
            return Ok(tags);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<string>> GetTagNameById(int id)
        {
            var tagName = await _tagManager.GetTagNameById(id);

            return Ok(tagName);
        }

    }
}
