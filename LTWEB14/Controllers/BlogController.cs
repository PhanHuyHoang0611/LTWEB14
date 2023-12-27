using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LTWEB14.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataContext _context;
        public BlogController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("/blog-{slug}-{id:long}.html", Name = "Details")]
        public IActionResult Details(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var blog = _context.Blogs.FirstOrDefault(m => (m.BlogID == id) && (m.IsActive == true));
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
    }
}
