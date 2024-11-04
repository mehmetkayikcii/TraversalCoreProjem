using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
         public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            //ViewBag.Image.1=featureManager.get
            return View();
        }
    }
}
