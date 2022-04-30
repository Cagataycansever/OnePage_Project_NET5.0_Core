using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featuremanager = new FeatureManager(new EFFeatureDAL());

        public IViewComponentResult Invoke()
        {
            var values=featuremanager.TGetList();
            return View(values);
        }
    }
}
