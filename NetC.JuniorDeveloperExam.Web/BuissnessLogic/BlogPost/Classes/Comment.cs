using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes
{
    public class Comment
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public Comment()
        {

        }

        public Comment(CommentSubmitViewModel data)
        {
            Name = data.Name;
            Date = data.Date;
            EmailAddress = data.EmailAddress;
            Message = data.Message; 
        }
    }
}