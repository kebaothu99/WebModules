using Blog.Application.Categories.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.Categories.Queries
{
    public class GetCategoriesListQuery : IRequest<List<CategoryDTO>>
    {
    }
}
