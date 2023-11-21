using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Parts;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer;


namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostViewModel
    {
        public int BlogPostId { get; set; }
        public BlogPageComponent Title { get; set; }
        public BlogPageComponent Date {  get; set; }
        public List<BlogPageComponent> BlogPostContent { get; set; }


        public BlogPostViewModel(int BlogPostId)
        {
            BlogPageComponentsImporterTXT blogPageComponentsImporterTXT = new BlogPageComponentsImporterTXT();
            var AllContent = blogPageComponentsImporterTXT.ImportByBlogPostId(BlogPostId);
            Title = AllContent.Where(x => x.PCT == PageConponentType.Title).FirstOrDefault();
            Date = AllContent.Where(x => x.PCT == PageConponentType.Date).FirstOrDefault();
            BlogPostContent = AllContent.Where(x => x.PCT == PageConponentType.P || x.PCT == PageConponentType.H2 || x.PCT == PageConponentType.H3).ToList();
        }
    }
}