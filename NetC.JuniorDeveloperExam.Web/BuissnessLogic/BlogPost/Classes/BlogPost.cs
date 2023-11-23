using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes
{
    public class BlogPostModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string HtmlContent { get; set; }
        public List<Comment> Comments { get; set; }

        public void AddComment(Comment comment)
        {
            if (Comments == null)
            {
                Comments = new List<Comment>();
            }
            Comments.Add(comment);
        }
    }
}