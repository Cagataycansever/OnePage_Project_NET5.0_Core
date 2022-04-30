using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.Skills = c.Skills.Count();
            ViewBag.MessagesFalse = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.MessagesAll = c.Messages.Count();
            ViewBag.Experiences = c.Experiences.Count();
            return View();
        }
    }
}
