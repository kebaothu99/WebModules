using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Blog.Infrastructure;
using Blog.Application.Categories.Queries;
using Blog.Application.Posts.Commands.CreatePost;
using Blog.Application.Posts.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.Blog.Pages.Admin.Posts
{
    public class NewModel : BasePageModel
    {

        [BindProperty]
        public PostDetailDTO PostDetail { get; set; } = new PostDetailDTO();

        [BindProperty]
        public IEnumerable<int> CategoryIDs { get; set; }
        public List<SelectListItem> Categories { get; private set; } = new List<SelectListItem>();
        [BindProperty]
        public IEnumerable<int> TagIDs { get; set; }
        public List<SelectListItem> Tags { get; } = new List<SelectListItem>();

        public async Task<IActionResult> OnGet()
        {
            var categoryDTOs = await Mediator.Send(new GetCategoriesListQuery());

            categoryDTOs.ForEach(c =>
            {
                Categories.Add(new SelectListItem()
                {
                    Text = c.Name,
                    Value = c.ID.ToString()
                });
            });

            return Page();
        }

        public async Task<IActionResult> OnPost(CreatePostCommand command)
        {
            var productId = await Mediator.Send(command);

            return RedirectToPage("./Index");
        }
    }
}