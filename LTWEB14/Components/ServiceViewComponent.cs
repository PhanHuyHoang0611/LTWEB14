using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;


namespace LTWEB14.Components
{
    [ViewComponent(Name = "ServiceView")]
    public class ServiceViewComponent : ViewComponent
    {
        private DataContext _context;
        public ServiceViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofService = (from m in _context.Services where (m.Status == true)  select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofService));
        }
    }
}