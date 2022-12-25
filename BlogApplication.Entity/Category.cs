using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Entity
{
    public class Category: BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string CategoryUrl { get; set; }
        public List<PostCategory> PostCategories { get; set; }
    }
}
