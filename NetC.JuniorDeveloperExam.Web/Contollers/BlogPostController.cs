using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Exporter;
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
            BlogPostImporterJson bPCIT = new BlogPostImporterJson();
            var result = bPCIT.ImportByBlogPostId(1);
            BlogPostViewModel blogPostViewModel = new BlogPostViewModel(result);
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();
            foreach (var item in result.Comments)
            {
                CommentViewModel cVM = new CommentViewModel(item);
                commentViewModels.Add(cVM);
            }

            BlogPostCombinedViewModel bPCVM = new BlogPostCombinedViewModel(blogPostViewModel,commentViewModels);
            return View(bPCVM);
        }

        public ActionResult PostNewComment(int BlogPostId, string name, string dateTime, string email, string message)
        {
            BlogPostImporterJson bPCIT = new BlogPostImporterJson();
            var blogPost = bPCIT.ImportByBlogPostId(BlogPostId);
            Comment comment = new Comment(name,dateTime,email,message);
            blogPost.AddComment(comment);
            var ContainerResult = bPCIT.ImportContainer();
            ContainerResult.updateBlogPostsContainer(blogPost);
            BlogPostExporter bPE = new BlogPostExporter();
            bPE.Export(ContainerResult);
            return View();
        }
    }
}