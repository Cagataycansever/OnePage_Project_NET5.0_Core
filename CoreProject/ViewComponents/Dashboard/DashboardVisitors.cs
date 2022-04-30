using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class DashboardVisitors:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
