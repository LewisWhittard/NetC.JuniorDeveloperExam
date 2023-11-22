using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes
{
    public class Comment
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }
}