using BlogApplication.Data.Abstract;
using BlogApplication.Data.EFCore.Concrete;
using BlogApplication.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data.Concrete.EFCore
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogApp_Context context) : base(context)
        {
        }
        private BlogApp_Context DbContext
        {
            get { return _context as BlogApp_Context; }
        }

        public async Task<List<Post>> GetPostsByCategoryId(int id)
        {
            var posts = await DbContext.Posts
               .Include(p => p.PostCategories.Where(pc => pc.CategoryId == id))
               .Where(p => p.PostCategories.Any(pc => pc.CategoryId == id))
               .Include(p => p.PostCategories).ThenInclude(pc => pc.Category)
               .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
               .ToListAsync();

            return posts;
        }

        public async Task<Post> GetPostsByIdWithDetails(int id)
        {
            var post = await DbContext.Posts.Where(p => p.Id == id)
               .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
               .Include(p => p.PostCategories).ThenInclude(pc => pc.Category)
               .FirstOrDefaultAsync();

            return post;
        }

        public async Task<List<Post>> GetPostsByTagId(int id)
        {
            var posts = await DbContext.Posts
                .Include(p => p.PostTags)
                .Where(p => p.PostTags.Any(pt => pt.TagId == id))
                .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
                .Include(p => p.PostCategories).ThenInclude(pc => pc.Category)
                .ToListAsync();

            return posts;
        }

        public async Task<List<Post>> GetPostsWithTagsAndCategory()
        {
            var posts = await DbContext.Posts
                .Include(p => p.PostTags).ThenInclude(pt => pt.Tag)
                .Include(p => p.PostCategories).ThenInclude(pc => pc.Category)
                .ToListAsync();

            return posts;
        }
    }
}
