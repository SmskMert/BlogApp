﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Entity
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public int ParentComment { get; set; }
        public string PostedBy { get; set; }
        public int? PostId { get; set; }
        public Post Post { get; set; }
    }
}
