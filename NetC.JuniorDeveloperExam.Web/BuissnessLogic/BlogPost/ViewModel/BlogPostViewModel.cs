using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer;


namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostViewModel
    {
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostContent { get; set; }


        public BlogPostViewModel(NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer.BlogPost BlogPost)
        {
            BlogPostId = BlogPost.Id;
            BlogPostTitle = BlogPost.Title;
            BlogPostContent = BlogPost.HtmlContent;
        }
    }
}