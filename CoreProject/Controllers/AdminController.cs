using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialTopnav()
        {
            return PartialView();
        }
        public PartialViewResult AdminSidebar()
        {
            return PartialView();
        }
    }
}
