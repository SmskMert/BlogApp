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
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogApp_Context context) : base(context)
        {
        }
        private DbContext DbContext
        {
            get { return _context as BlogApp_Context; }
        }
    }
}
