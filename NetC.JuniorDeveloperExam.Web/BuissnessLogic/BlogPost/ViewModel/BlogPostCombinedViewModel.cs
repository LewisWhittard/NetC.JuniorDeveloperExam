using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostCombinedViewModel
    {
        public BlogPostViewModel BlogPost { get; set; }
        public List<CommentViewModel> Comment { get; set; }

        public BlogPostCombinedViewModel(BlogPostViewModel bPVM , List<CommentViewModel> cVM) 
        { 
            BlogPost = bPVM;
            Comment = cVM.ToList();
        }
    }
}