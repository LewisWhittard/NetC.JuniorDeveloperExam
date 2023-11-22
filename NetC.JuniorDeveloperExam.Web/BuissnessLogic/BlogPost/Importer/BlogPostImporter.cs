using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;


namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer
{
    public interface IBlogPageComponentsImporter
    {
        List<BlogPost> ImportAll();
        BlogPost ImportByBlogPostId(int BlogPostId);
    }

    public abstract class AbstractBlogPageComponentsImporter : IBlogPageComponentsImporter
    {
        public abstract List<BlogPost> ImportAll();
        public abstract BlogPost ImportByBlogPostId(int BlogPostId);
    }

    public class BlogPostJsonImporter : AbstractBlogPageComponentsImporter
    {
        public override List<BlogPost> ImportAll()
        {
            string virtualPath = "~/App_Data/Blog-Posts.json";
            string physicalPath = HostingEnvironment.MapPath(virtualPath);
            // Read the JSON file
            string jsonContent = System.IO.File.ReadAllText(physicalPath);
            // Deserialize the JSON content into a list of BlogPost
            var blogPostsContainer = JsonConvert.DeserializeObject<BlogPostsContainer>(jsonContent);
            //List<BlogPageComponent> blogPageComponents = SeprateBlogPageComponentRow(blogPostData);
            List<BlogPost> blogPosts = blogPostsContainer.BlogPosts;

            return blogPosts;

        }

        public override BlogPost ImportByBlogPostId(int BlogPostId)
        {
            var localData = ImportAll().Where(x => x.Id == BlogPostId).FirstOrDefault();
            return localData;

        }
    }

    [JsonObject]
    public class BlogPost
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string HtmlContent { get; set; }
        public List<Comment> Comments { get; set; }
    }
    [JsonObject]
    public class Comment
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string EmailAddress { get; set; }
        public string Message { get; set; }
    }

    public class BlogPostsContainer
    {
        public List<BlogPost> BlogPosts { get; set; }
    }
}
