using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.LandingPages.Models
{
    public enum PageStatus
    {
        Draft = 0,
        Private = 1,
        Publish = 2,
    }

    public class LandingPageDTO
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public PageStatus Status { get; set; }
        public DateTime PublishOn { get; set; }
        public int Order { get; set; }
    }
}
