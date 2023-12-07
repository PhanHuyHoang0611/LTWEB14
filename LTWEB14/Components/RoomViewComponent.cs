using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;


namespace LTWEB14.Components
{
    [ViewComponent(Name = "RoomView")]
    public class RoomViewComponent : ViewComponent
    {
        private DataContext _context;
        public RoomViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofRoom = (from m in _context.Rooms where (m.Status == true) select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofRoom));
        }
    }
}