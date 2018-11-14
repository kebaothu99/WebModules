using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.Blog.Infrastructure
{
    public abstract class BasePageModel : PageModel
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ?? (_mediator = (IMediator) HttpContext.RequestServices.GetService(typeof(IMediator)));
    }
}
