using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Dashboard
{
    public class DashboardStatistics2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Portfolio = c.Portfolios.Count();
            ViewBag.Service = c.Services.Count();
            ViewBag.Testimonial=c.Testimonials.Count();
            return View();
        }
    }
}
