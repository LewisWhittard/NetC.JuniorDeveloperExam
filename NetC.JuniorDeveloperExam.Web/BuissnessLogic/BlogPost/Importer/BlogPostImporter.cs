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
    }

    public abstract class AbstractBlogPostImporter : IBlogPostImporter
    {
        public abstract List<BlogPostModel> ImportAll();
        public abstract BlogPostModel ImportByBlogPostId(int BlogPostId);
    }

    public class BlogPostImporterJson : AbstractBlogPostImporter
    {
        public override List<BlogPostModel> ImportAll()
        {
            string virtualPath = "~/App_Data/Blog-Posts.json";
            string physicalPath = HostingEnvironment.MapPath(virtualPath);
            // Read the JSON file
            string jsonContent = System.IO.File.ReadAllText(physicalPath);
            // Deserialize the JSON content into a list of BlogPost
            var blogPostsContainer = JsonConvert.DeserializeObject<BlogPostsContainer>(jsonContent);
            //List<BlogPageComponent> blogPageComponents = SeprateBlogPageComponentRow(blogPostData);
            List<BlogPostModel> blogPosts = blogPostsContainer.BlogPosts;
            return blogPosts;

        }

        public override BlogPostModel ImportByBlogPostId(int BlogPostId)
        {
            var localData = ImportAll().Where(x => x.Id == BlogPostId).FirstOrDefault();
            return localData;

        }
    }

  

 
    

    
}
