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
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(BlogApp_Context context) : base(context)
        {
        }

        private BlogApp_Context DbContext
        {
            get { return _context as BlogApp_Context; }
        }

        public async Task<string> GetTagNameById(int id)
        {
            return await DbContext.Tags.Where(t => t.Id == id).Select(t => t.Title).FirstOrDefaultAsync();
        }
    }
}
