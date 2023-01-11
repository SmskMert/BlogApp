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
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task CreateAsync(Category category)
        {
            await _categoryRepository.CreateAsync(category);
        }
        public async Task<Category> GetByIdAsync(int id)
        {
           return await _categoryRepository.GetByIdAsync(id);
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }
        public  void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }
        public void DeleteById(int id)
        {
            _categoryRepository.DeleteById(id);
        }

        public async Task<string> GetCategoryNameById(int id)
        {
            return await _categoryRepository.GetCategoryNameById(id);
        }
    }
}
