using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Abstract
{
    public interface ITagService
    {
        Task CreateAsync(Tag tag);
        Task<Tag> GetByIdAsync(int id);
        Task<List<Tag>> GetAllAsync();
        void Update(Tag tag);
        void Delete(Tag tag);
        void DeleteById(int id);
        Task<string> GetTagNameById(int id);
    }
}
