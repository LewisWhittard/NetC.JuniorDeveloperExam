using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;
using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Classes;


namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer
{
    public interface IBlogPostImporter
    {
        List<BlogPostModel> ImportAll();
        BlogPostModel ImportByBlogPostId(int BlogPostId);
        BlogPostsContainer ImportContainer();

    }

    public abstract class AbstractBlogPostImporter : IBlogPostImporter
    {
        public abstract List<BlogPostModel> ImportAll();
        public abstract BlogPostModel ImportByBlogPostId(int BlogPostId);
        public abstract BlogPostsContainer ImportContainer();
    }

    public class BlogPostImporterJson : AbstractBlogPostImporter
    {
        public override List<BlogPostModel> ImportAll()
        {
            string virtualPath = "~/App_Data/Blog-Posts.json";
            string physicalPath = HostingEnvironment.MapPath(virtualPath);
            string jsonContent = System.IO.File.ReadAllText(physicalPath);
            var blogPostsContainer = JsonConvert.DeserializeObject<BlogPostsContainer>(jsonContent);
            List<BlogPostModel> blogPosts = blogPostsContainer.BlogPosts;
            return blogPosts;

        }

        public override BlogPostsContainer ImportContainer()
        {
            string virtualPath = "~/App_Data/Blog-Posts.json";
            string physicalPath = HostingEnvironment.MapPath(virtualPath);
            string jsonContent = System.IO.File.ReadAllText(physicalPath);
            var blogPostsContainer = JsonConvert.DeserializeObject<BlogPostsContainer>(jsonContent);
            return blogPostsContainer;

        }

        public override BlogPostModel ImportByBlogPostId(int BlogPostId)
        {
            var localData = ImportAll().Where(x => x.Id == BlogPostId).FirstOrDefault();
            return localData;

        }
    }

  

 
    

    
}
