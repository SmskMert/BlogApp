using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data.Abstract
{
    public interface IPostRepository: IGenericRepository<Post>
    {
        Task<List<Post>> GetPostsWithTagsAndCategory();
        Task<List<Post>> GetPostsByCategoryId(int id);
        Task<List<Post>> GetPostsByTagId(int id);
        Task<Post> GetPostsByIdWithDetails(int id);
    }
}
