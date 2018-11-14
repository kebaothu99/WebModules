using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Entities
{
    public class PostCategory
    {
        public int PostID { get; set; }
        public int CategoryID { get; set; }

        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}
