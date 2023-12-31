﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class BlogPostCombinedViewModel
    {
        public BlogPostViewModel BlogPost { get; set; }
        public List<CommentViewModel> Comments { get; set; }
        public CommentSubmitViewModel CommentSubmitViewModel { get; set; }

        public BlogPostCombinedViewModel(BlogPostViewModel bPVM , List<CommentViewModel> cVM) 
        { 
            BlogPost = bPVM;
            Comments = cVM.ToList();
            CommentSubmitViewModel = new CommentSubmitViewModel(bPVM.BlogPostId);
        }
    }
}