using BlogApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data.Abstract
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
    }
}
