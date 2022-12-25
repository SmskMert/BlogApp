using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Business.Abstract
{
    public interface ICategoryService
    {
        Task CreateAsync(Category category);
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        void Update(Category category);
        void Delete(Category category);
        void DeleteById(int id);
    }
}
