using Blog.Application.Categories.Models;
using Blog.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blog.Application.Categories.Queries
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryDTO>>
    {
        private readonly BlogContext _context;

        public GetCategoriesListQueryHandler(BlogContext context)
        {
            _context = context;
        }

        public Task<List<CategoryDTO>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            return _context.Categories.Select(c => new CategoryDTO()
            {
                ID = c.CategoryID,
                Name = c.CategoryName
            }).ToListAsync(cancellationToken);
        }
    }
}
