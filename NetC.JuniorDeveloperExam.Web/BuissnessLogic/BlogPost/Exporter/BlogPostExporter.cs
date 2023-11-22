using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Exporter
{
    public interface IBlogPostExporter
    {
        void Export(BlogPostsContainer bPC);
    }

    public abstract class AbstractBlogPostExporter : IBlogPostExporter
    {
        public abstract void Export(BlogPostsContainer bPC);
    }

    public class BlogPostExporter : AbstractBlogPostExporter
    {
        public override void Export(BlogPostsContainer bPC)
        {
            string virtualPath = "~/App_Data/Blog-Posts.json";
            string physicalPath = HostingEnvironment.MapPath(virtualPath);
            string jsonContent = System.IO.File.ReadAllText(physicalPath);
            string updatedJson = JsonConvert.SerializeObject(bPC, Formatting.Indented);
            File.WriteAllText(physicalPath, updatedJson);
        }
    }
}