using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LTWEB14.Components
{
    [ViewComponent(Name = "RecentBlog")]
    public class RecentBlogComponent : ViewComponent
    {
        private readonly DataContext _context;
        public RecentBlogComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofPost = (from p in _context.Blogs
                              where (p.IsActive == true)
                              select p).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofPost));
        }
    }
}
