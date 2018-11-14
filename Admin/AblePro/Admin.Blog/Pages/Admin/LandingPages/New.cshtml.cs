using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.LandingPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Blog.Pages.Admin.LandingPages
{
    public class NewModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public LandingPageDTO PageDetail { get; set; } = new LandingPageDTO();

        public void OnGet()
        {
        }
    }
}