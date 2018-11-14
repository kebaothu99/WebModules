using Blog.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Entities
{
    public class Post
    {
        public Post()
        {
            PostCategories = new HashSet<PostCategory>();
            PostTags = new HashSet<PostTag>();
        }
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Excerpt { get; set; }
        public PostStatus Status { get; set; }
        public PostFormat Format { get; set; }
        public DateTime PublishOn { get; set; }

        //public ICollection<Category> Categories { get; private set; }
        //public ICollection<Tag> Tags { get; private set; }
        public ICollection<PostCategory> PostCategories { get; private set; }
        public ICollection<PostTag> PostTags { get; private set; }
    }
}
