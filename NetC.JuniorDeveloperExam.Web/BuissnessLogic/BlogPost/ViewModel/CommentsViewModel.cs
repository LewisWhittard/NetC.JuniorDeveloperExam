using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.ViewModel
{
    public class CommentViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }

        public CommentViewModel(Comment data)
        {
            Name = data.Name;
            Date = data.Date;
            EmailAddress = data.EmailAddress;
            Message = data.Message;
        }

    }
}