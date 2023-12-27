using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LTWEB14.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext? _context;
        private DataContext? context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/blog-{slug}-{id:long}.html", Name ="Details")]
        public IActionResult Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var blog = _context.Blogs
                .FirstOrDefault(m => (m.BlogID == id)&&(m.IsActive == true));
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}