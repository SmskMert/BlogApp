﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Entity
{
    public class Tag: BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string TagUrl { get; set; }
       public List<PostTag> PostTags { get; set; }
    }
}
