using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;


namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostViewModel
    {
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostContent { get; set; }
        public string blogPostDate { get; set; }


        public BlogPostViewModel(BlogPostModel BlogPost)
        {
            BlogPostId = BlogPost.Id;
            BlogPostTitle = BlogPost.Title;
            blogPostDate = BlogPost.Date.ToString();
            BlogPostContent = BlogPost.HtmlContent;
        }
    }
}