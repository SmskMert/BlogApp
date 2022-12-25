using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Contents { get; set; }
        public string PostUrl { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<PostCategory>? PostCategories { get; set; }
        public List<PostTag>? PostTags { get; set; }
    }
}
