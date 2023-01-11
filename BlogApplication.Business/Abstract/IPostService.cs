using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Abstract
{
    public interface IPostService
    {
        Task CreateAsync(Post post);
        Task<Post> GetByIdAsync(int id);
        Task<List<Post>> GetAllAsync();
        void Update(Post post);
        void Delete(Post post);
        void DeleteById(int id);
        Task<List<Post>> GetPostsWithTagsAndCategory();
        Task<List<Post>> GetPostsByCategoryId(int id);
        Task<List<Post>> GetPostsByTagId(int id);
        Task<Post> GetPostByIdWithDetails(int id);
    }
}
