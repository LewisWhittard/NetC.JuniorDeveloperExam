using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostContainerViewModel
    {
        public List<BlogPostViewModel> BlogPosts { get; set; }

        public BlogPostContainerViewModel(List<BlogPostModel> bPM)
        {
            BlogPosts = new List<BlogPostViewModel>();

            foreach (var blogPost in bPM) 
            { 
                BlogPostViewModel bPVM = new BlogPostViewModel(blogPost);
                BlogPosts.Add(bPVM);
            }
        }
    }
}