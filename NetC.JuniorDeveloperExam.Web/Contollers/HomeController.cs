using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BlogPostImporterJson blogPostImporterJson = new BlogPostImporterJson();
            var data = blogPostImporterJson.ImportAll();
            BlogPostContainerViewModel bPCVM = new BlogPostContainerViewModel(data);
            return View(bPCVM);
        }


    }
}