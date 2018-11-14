﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Entities
{
    public class PostTag
    {
        public int PostID { get; set; }
        public int TagID { get; set; }

        public Post Post { get; set; }
        public Tag Tag { get; set; }
    }
}
