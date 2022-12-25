using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Abstract
{
    public interface ICommentService
    {
        Task CreateAsync(Comment comment);
        Task<Comment> GetByIdAsync(int id);
        Task<List<Comment>> GetAllAsync();
        void Update(Comment comment);
        void Delete(Comment comment);
        void DeleteById(int id);
    }
}
