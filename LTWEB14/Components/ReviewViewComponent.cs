using LTWEB14.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;


namespace LTWEB14.Components
{
    [ViewComponent(Name = "ReviewView")]
    public class ReviewViewComponent : ViewComponent
    {
        private DataContext _context;
        public ReviewViewComponent(DataContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofReview = (from m in _context.Reviews
                                join n in _context.Customers on m.CustomerID equals n.CustomerID
                                where (m.Status == true && n.Status==true) select m).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofReview));
            

        }
    }
}