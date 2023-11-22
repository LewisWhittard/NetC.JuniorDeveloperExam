using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class CommentBase
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }

    public class CommentViewModel : CommentBase
    {
        public CommentViewModel(Comment data)
        {
            Name = data.Name;
            Date = data.Date;
            EmailAddress = data.EmailAddress;
            Message = data.Message;
        }

    }

    public class CommentSubmitViewModel : CommentBase
    {
        public int BlogPostId { get; set; }

        public CommentSubmitViewModel(int blogPostId)
        {
            BlogPostId = blogPostId;
        }

        public void SetDateTime()
        {
            Date = DateTime.Now.ToString();
        }
    }
}