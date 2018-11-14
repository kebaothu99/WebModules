using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Entities
{
    public class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public int TagID { get; set; }
        public string TagName { get; set; }

        public ICollection<PostTag> PostTags { get; private set; }
    }
}
