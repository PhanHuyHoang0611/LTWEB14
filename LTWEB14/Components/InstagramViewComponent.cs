using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;


namespace LTWEB14.Components
{
    [ViewComponent(Name = "InstagramView")]
    public class InstagramViewComponent : ViewComponent
    {
        private DataContext _context;
        public InstagramViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofInstagram = (from m in _context.Instagrams where (m.Status == true) select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofInstagram));
        }
    }
}