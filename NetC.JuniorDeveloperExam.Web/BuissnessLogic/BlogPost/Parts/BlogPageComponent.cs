using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Parts
{
    public class BlogPageComponent
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public int PageOrderNumber { get; set; }
        public PageConponentType PCT { get; set; }
        public string Value { get; set; }

        public BlogPageComponent(List<string> data)
        {
            Id = Convert.ToInt32(data[0]);
            BlogPostId = Convert.ToInt32(data[1]);
            PageOrderNumber = Convert.ToInt32(data[2]);
            PageConponentType enumValue = (PageConponentType)Convert.ToInt32(data[3]);
            Value = data[4];
        }
    }

    public enum PageConponentType
    {
        Title = 0,
        P = 1,
        H2 = 2,
        H3 = 3,
        Date = 4

    }
}