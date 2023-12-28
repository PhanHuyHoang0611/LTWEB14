using Microsoft.AspNetCore.Mvc;
using LTWEB14.Models;

namespace LTWEB14.Views.Shared.Components
{
    [ViewComponent(Name ="Blog")]
    public class BlogComponent : ViewComponent
    {
        private readonly DataContext _context;
        public BlogComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofBlog = (from b in _context.Blogs
                              where b.IsActive == true
                              
                              select b).Take(4).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofBlog));
        }
    }
}
