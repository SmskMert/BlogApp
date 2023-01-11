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
    public class TagManager: ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagManager(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task CreateAsync(Tag tag)
        {
            await _tagRepository.CreateAsync(tag);
        }

        public void Delete(Tag tag)
        {
            _tagRepository.Delete(tag);
        }

        public void DeleteById(int id)
        {
           _tagRepository.DeleteById(id);
        }

        public async Task<List<Tag>> GetAllAsync()
        {
            return await _tagRepository.GetAllAsync();
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            return await _tagRepository.GetByIdAsync(id);
        }

        public async Task<string> GetTagNameById(int id)
        {
            return await _tagRepository.GetTagNameById(id);
        }

        public void Update(Tag tag)
        {
            _tagRepository.Update(tag);
        }
    }
}
