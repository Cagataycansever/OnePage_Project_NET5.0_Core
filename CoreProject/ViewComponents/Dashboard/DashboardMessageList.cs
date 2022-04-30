
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class DashboardMessageList:ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EFUserMessageDAL());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
