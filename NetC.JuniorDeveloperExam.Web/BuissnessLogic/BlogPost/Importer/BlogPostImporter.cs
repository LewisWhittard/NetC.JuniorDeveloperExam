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
        List<BlogPageComponent> ImportByBlogPostId(int BlogPostId);
    }

    public abstract class AbstractBlogPageComponentsImporter : IBlogPageComponentsImporter
    {
        public abstract List<BlogPageComponent> ImportByBlogPostId(int BlogPostId);
    }

    public class BlogPageComponentsImporterTXT : AbstractBlogPageComponentsImporter
    {

        public override List<BlogPageComponent> ImportByBlogPostId(int BlogPostId)
        {
            //replace with import method for text file
            string blogPostData =
            "<BlogPageComponentRow>" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>Test" +
            "<BlogPageComponentRow>" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>1" +
            "<BlogComponentData>Test"
            ;

            List<BlogPageComponent> blogPageComponents = SeprateBlogPageComponentRow(blogPostData, BlogPostId);
            blogPageComponents.First();
            return blogPageComponents;

        }

        public List<BlogPageComponent> SeprateBlogPageComponentRow(string data, int BlogPostId)
        {
            List<string> localData = data.Split(new string[] { "<BlogPageComponentRow>" }, StringSplitOptions.None).ToList();
            localData.RemoveAt(0);
            List<BlogPageComponent> toReturn = new List<BlogPageComponent>();

            foreach (var item in localData)
            {
                List<string> ComponentData = SeprateBlogComponentData(item);

                if (Convert.ToInt32(ComponentData[2]) == BlogPostId)
                {
                    BlogPageComponent bPC = new BlogPageComponent(ComponentData);
                    toReturn.Add(bPC);
                }
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