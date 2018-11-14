using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Application.LandingPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.Blog.Pages.Admin.LandingPages
{
    public class IndexModel : PageModel
    {
        public List<LandingPageDTO> LandingPages { get; set; } = new List<LandingPageDTO>();

        public void OnGet()
        {
        }
    }
}