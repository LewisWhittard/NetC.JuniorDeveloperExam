using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes
{
    public class BlogPostsContainer
    {
        public List<BlogPostModel> BlogPosts { get; set; }

        public void updateBlogPostsContainer(BlogPostModel bPC)
        {
            BlogPosts = BlogPosts.Where(x => x.Id != bPC.Id).ToList();
            BlogPosts.Add(bPC);
        }
    }
}