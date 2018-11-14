using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Blog.Persistence;
using System.Threading.Tasks;
using System.Threading;
using Blog.Domain.Entities;

namespace Blog.Application.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly BlogContext _context;

        public CreatePostCommandHandler(BlogContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var entity = new Post
            {
                Title = request.Title,
                Slug = request.Slug,
                Keywords = request.Keywords,
                Description = request.Description,
                Content = request.Slug,
                Excerpt = request.Excerpt,
                Format = (Domain.Enumerations.PostFormat) request.Format,
                PublishOn = request.PublishOn,
                Status = (Domain.Enumerations.PostStatus) request.Status,
            };

            _context.Posts.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.PostID;
        }
    }
}
