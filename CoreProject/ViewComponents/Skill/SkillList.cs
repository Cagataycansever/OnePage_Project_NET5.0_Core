using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skillManager = new SkillManager(new EFSkillDAL());
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
