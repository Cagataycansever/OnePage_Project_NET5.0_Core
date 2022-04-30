using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Dashboard
{
    public class DashboardToDoListPanel:ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDAL());

        public IViewComponentResult Invoke()
        {
            var values = toDoListManager.TGetList();
            return View(values);
        }
    }
}
