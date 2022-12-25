using BlogApplication.Business.Abstract;
using BlogApplication.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class BlogController : ControllerBase
    {
        private readonly IPostService _postManager;

        public BlogController(IPostService postManager)
        {
            _postManager = postManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllPosts()
        {
            var posts = await _postManager.GetAllAsync();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetPostById(int id)
        {

            var post = await _postManager.GetByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            await _postManager.CreateAsync(post);
            return CreatedAtAction(nameof(CreatePost), new { id = post.Id }, post);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePost(int id, Post post)
        {
           if(id != post.Id)
            {
                return BadRequest();
            }
            var existingPost = await _postManager.GetByIdAsync(id);

            if (existingPost is null)
            {
                return NotFound();
            }
            existingPost.Summary = post.Summary;
            existingPost.Title = post.Title;
            existingPost.PostUrl = post.PostUrl;
            _postManager.Update(existingPost);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await _postManager.GetByIdAsync(id);
            if (post is null)
            {
                return NotFound();
            }
            _postManager.DeleteById(id);
            return NoContent();
        }
    }
}
