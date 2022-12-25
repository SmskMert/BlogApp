using BlogApplication.Business.Abstract;
using BlogApplication.Data.Abstract;
using BlogApplication.Data.Concrete.EFCore;
using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Concreate
{
    public class CommentManager: ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task CreateAsync(Comment comment)
        {
            await _commentRepository.CreateAsync(comment);
        }
        public async Task<Comment> GetByIdAsync(int id)
        {
           return await _commentRepository.GetByIdAsync(id);
        }
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _commentRepository.GetAllAsync();
        }
        public  void Update(Comment comment)
        {
            _commentRepository.Update(comment);
        }
        public void Delete(Comment comment)
        {
            _commentRepository.Delete(comment);
        }
        public void DeleteById(int id)
        {
            _commentRepository.DeleteById(id);
        }
    }
}
