using NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.BuissnessLogic.BlogPost.Importer
{
    public interface IBlogPageComponentsImporter
    {
        List<BlogPageComponent> ImportAll();
        List<BlogPageComponent> ImportByBlogPostId(int BlogPostId);
    }

    public abstract class AbstractBlogPageComponentsImporter : IBlogPageComponentsImporter
    {
        public abstract List<BlogPageComponent> ImportAll();
        public abstract List<BlogPageComponent> ImportByBlogPostId(int BlogPostId);
    }

    public class BlogPageComponentsImporterTXT : AbstractBlogPageComponentsImporter
    {
        public override List<BlogPageComponent> ImportAll()
        {
            //replace with import method for text file
            string blogPostData =
            "<BlogPageComponentRow>" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>H1" +
            "<BlogComponentData><h1 class=\"mt-4\">Top 5 Considerations for a Content-First Design Approach</h1>" +
            
            "<BlogPageComponentRow>" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>HR" +
            "<BlogComponentData><hr>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>Date" +
            "<BlogComponentData><p>Posted on November 11, 2019</p>"
            ;

            List<BlogPageComponent> blogPageComponents = SeprateBlogPageComponentRow(blogPostData);
            return blogPageComponents;

        }

        public override List<BlogPageComponent> ImportByBlogPostId(int BlogPostId)
        {
            var localData = ImportAll().Where(x => x.BlogPostId == BlogPostId).ToList();
            return localData;

        }

        public List<BlogPageComponent> SeprateBlogPageComponentRow(string data)
        {
            List<string> localData = data.Split(new string[] { "<BlogPageComponentRow>" }, StringSplitOptions.None).ToList();
            localData.RemoveAt(0);
            List<BlogPageComponent> toReturn = new List<BlogPageComponent>();

            foreach (var item in localData)
            {
                List<string> ComponentData = SeprateBlogComponentData(item);
                BlogPageComponent bPC = new BlogPageComponent(ComponentData);
                toReturn.Add(bPC);
            }

            return toReturn;
        }

        public List<string> SeprateBlogComponentData(string data)
        {
            List<string> localData = data.Split(new string[] {"<BlogComponentData>"}, StringSplitOptions.None).ToList();
            localData.RemoveAt(0);
            return localData;   
        }

    }
}