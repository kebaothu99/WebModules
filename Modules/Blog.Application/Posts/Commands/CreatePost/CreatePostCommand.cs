using Blog.Application.Posts.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Excerpt { get; set; }
        public PostStatus Status { get; set; }
        public PostFormat Format { get; set; }
        public DateTime PublishOn { get; set; }

        public ICollection<int> CategoryIDs { get; set; }
        public ICollection<int> TagIDs { get; set; }
    }
}
