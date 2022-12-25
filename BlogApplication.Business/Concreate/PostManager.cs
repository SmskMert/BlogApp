using BlogApplication.Business.Abstract;
using BlogApplication.Data.Abstract;
using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Concreate
{
    public class PostManager : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostManager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task CreateAsync(Post post)
        {
            await _postRepository.CreateAsync(post);
        }

        public void Delete(Post post)
        {
            _postRepository.Delete(post);
        }

        public void DeleteById(int id)
        {
            _postRepository.DeleteById(id);
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _postRepository.GetAllAsync();
        }

        public async Task<Post> GetByIdAsync(int id)
        {
            return await _postRepository.GetByIdAsync(id);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
