using Blog.Application.Categories.Models;
using Blog.Application.Tags.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Posts.Models
{
    public enum PostStatus
    {
        Draft = 0,
        Private = 1,
        Publish = 2,
    }

    public enum PostFormat
    {
        Standard = 1,
        Aside = 2,
        Image = 3,
        Video = 4,
        Quote = 5,
        Link = 6,
        Gallery = 7,
        Audio = 8
    }

    public class PostDetailDTO
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Excerpt { get; set; }
        public PostStatus Status { get; set; }
        public PostFormat Format { get; set; }
        public DateTime PublishOn { get; set; }

        public ICollection<CategoryDTO> Categories { get; set; }
        public ICollection<TagDTO> Tags { get; set; }
    }
}
