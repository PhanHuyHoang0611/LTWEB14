using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LTWEB14.Components
{
		[ViewComponent(Name = "BlogView")]
	public class BlogViewComponent :ViewComponent

	{

		private DataContext _context;
		public BlogViewComponent(DataContext context)
		{
			_context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync()
			{
			var b = await _context.Blogs
							.Where(b => b.IsActive == true)
							.Take(4)
							.ToListAsync();
				return await Task.FromResult((IViewComponentResult)View("Default" , b));
			}
		
	}
}
