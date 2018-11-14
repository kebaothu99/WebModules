using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            PostCategories = new HashSet<PostCategory>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<PostCategory> PostCategories { get; private set; }
    }
}
