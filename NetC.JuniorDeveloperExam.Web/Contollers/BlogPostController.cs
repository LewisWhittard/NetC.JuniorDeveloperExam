using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Contollers
{
    public class BlogPostController : Controller
    {
        // GET: BlogPage
        public ActionResult Index()
        {
            BlogPageComponentsImporterTXT bPCIT = new BlogPageComponentsImporterTXT();
            BlogPostViewModel bPVM = new BlogPostViewModel(1);
            return View(bPVM);
        }
    }
}