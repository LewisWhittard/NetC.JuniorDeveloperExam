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
            "<BlogComponentData>Title" +
            "<BlogComponentData><h1 class=\"mt-4\">Top 5 Considerations for a Content-First Design Approach</h1>" +
            
            "<BlogPageComponentRow>" +
            "<BlogComponentData>2" +
            "<BlogComponentData>1" +
            "<BlogComponentData>2" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><hr>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>3" +
            "<BlogComponentData>1" +
            "<BlogComponentData>3" +
            "<BlogComponentData>Date" +
            "<BlogComponentData><p>Posted on November 11, 2019</p>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>4" +
            "<BlogComponentData>1" +
            "<BlogComponentData>4" +
            "<BlogComponentData>Date" +
            "<BlogComponentData><img class=\"img-fluid rounded\" src=\"https://www.netconstruct.com/static/ae8188adb9e0f13c40fce50bd773bc51/a6b7d/Content-considerations.jpg\" alt=\"Top 5 Considerations for a Content-First Design Approach\">\r\n" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>5" +
            "<BlogComponentData>1" +
            "<BlogComponentData>5" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><hr>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>6" +
            "<BlogComponentData>1" +
            "<BlogComponentData>6" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>It was over two decades ago that Bill Gates declared&nbsp;‘Content is King’&nbsp;and the&nbsp;consensus&nbsp;still stands today&nbsp;with it&nbsp;arguably&nbsp;being&nbsp;the most important part of designing a website.&nbsp;&nbsp;</p><p>Content is essentially your&nbsp;UX.&nbsp;It&nbsp;encompasses&nbsp;the images, words, videos&nbsp;and&nbsp;data&nbsp;featured across your website.&nbsp;If the main purpose of your site is to share valuable and relevant content to engage your audience, then you should be&nbsp;considering your content&nbsp;long&nbsp;before embarking on&nbsp;a web project.&nbsp;All too often,&nbsp;businesses miss the opportunity to create impressive UX designs, instead waiting&nbsp;until the later stages of the project to sign off content which inevitably creates&nbsp;new challenges to overcome.&nbsp;&nbsp;</p>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>7" +
            "<BlogComponentData>1" +
            "<BlogComponentData>7" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>Having a research strategy in place that supports&nbsp;a content-first design approach should be at the top of your agenda.&nbsp;When&nbsp;businesses&nbsp;choose to design content-first,&nbsp;they&nbsp;are&nbsp;putting&nbsp;their&nbsp;valuable&nbsp;resources&nbsp;centre&nbsp;stage,&nbsp;conveying their brand&nbsp;through&nbsp;effective&nbsp;and&nbsp;engaging UX design.&nbsp;Throughout this blog, we will&nbsp;share&nbsp;our tips on how&nbsp;you can&nbsp;develop a content-first design approach.&nbsp;&nbsp;</p>\r\n" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>8" +
            "<BlogComponentData>1" +
            "<BlogComponentData>8" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h2><strong>How to develop a content-first design approach&nbsp;</strong>&nbsp;</h2>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>9" +
            "<BlogComponentData>1" +
            "<BlogComponentData>9" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>Content can no longer be an after-thought,&nbsp;but&nbsp;there’s no denying that&nbsp;generating content can be a tricky. To get you thinking along the right lines&nbsp;and help put pen to paper, follow our top tips:&nbsp;&nbsp;&nbsp;</p>\r\n" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>10" +
            "<BlogComponentData>1" +
            "<BlogComponentData>10" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Ask lots of questions</strong>&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>11" +
            "<BlogComponentData>1" +
            "<BlogComponentData>11" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>Generating content that successfully satisfies what your customers want to know requires a lot of research. Get into the habit of asking open-ended questions that answer the Who, What, Where, When, Why and How. Using this approach will allow you to delve deep and gain an understanding of what your website should&nbsp;include&nbsp;to&nbsp;build a considered site map.&nbsp;&nbsp;</p></h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>12" +
            "<BlogComponentData>1" +
            "<BlogComponentData>12" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Consider your Information Architecture&nbsp;(IA)</strong>&nbsp;</h3>\r\n</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>13" +
            "<BlogComponentData>1" +
            "<BlogComponentData>13" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>How your&nbsp;content is organised and divided across the website is a crucial aspect of UX design.&nbsp;Without effective sorting, most users would be completely lost when navigating&nbsp;a&nbsp;site&nbsp;and there’s no point having&nbsp;memorable features if they can’t be found!&nbsp;Use card sorting exercises, tree tests, user journey mapping&nbsp;and user flow diagrams to&nbsp;form&nbsp;an understanding of how&nbsp;best&nbsp;to display your content in a logical and accessible way.&nbsp;&nbsp;&nbsp;</p>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>14" +
            "<BlogComponentData>1" +
            "<BlogComponentData>14" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Conduct&nbsp;qualitative and&nbsp;quantitative&nbsp;research</strong>&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>15" +
            "<BlogComponentData>1" +
            "<BlogComponentData>15" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>Although Google Analytics is extremely useful, it doesn’t hold all the answers.&nbsp;Google&nbsp;Analytics is great at telling you&nbsp;<em>what</em>&nbsp;your users are doing, but it doesn’t give you&nbsp;the&nbsp;insight into&nbsp;<em>why</em>&nbsp;they’re doing it. Qualitative one-to-one user interviews is an effective method of really getting to grips with&nbsp;your user needs&nbsp;to&nbsp;understand&nbsp;why they do what they do.&nbsp;User&nbsp;testing also falls into this category.&nbsp;Seeing a user navigate through your website on a mobile phone&nbsp;in day to day life&nbsp;can give you great insight&nbsp;for&nbsp;UX design&nbsp;in terms of&nbsp;context and situation.&nbsp;</p>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>16" +
            "<BlogComponentData>1" +
            "<BlogComponentData>16" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Align your content strategy with long-term business goals</strong>&nbsp;&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>17" +
            "<BlogComponentData>1" +
            "<BlogComponentData>17" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Align your content strategy with long-term business goals</strong>&nbsp;&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>18" +
            "<BlogComponentData>1" +
            "<BlogComponentData>18" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><p>Before beginning your web project,&nbsp;it’s important to understand the goals of the project and the pain points you are trying to solve.&nbsp;Include all the necessary stakeholders within this&nbsp;research&nbsp;to gain a comprehensive understanding of these insights&nbsp;before embarking on your web design project.&nbsp;&nbsp;</p>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>19" +
            "<BlogComponentData>1" +
            "<BlogComponentData>19" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Content first, design second</strong>&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>20" +
            "<BlogComponentData>1" +
            "<BlogComponentData>20" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><strong>Content first, design second</strong>&nbsp;</h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>21" +
            "<BlogComponentData>1" +
            "<BlogComponentData>21" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><p>Avoid designing&nbsp;content boxes across your website and trying to squeeze the content into these boxes.&nbsp;When designing a new website, it may seem&nbsp;counter&nbsp;intuitive&nbsp;to begin with a page of words&nbsp;rather than a&nbsp;design mock-up. But, it’s important to remember that Lorem Ipsum isn’t going to help anyone either.&nbsp;Begin with the content your users&nbsp;need&nbsp;and then design out from&nbsp;there.&nbsp;Capturing&nbsp;the content&nbsp;and its structure can be done in many ways;&nbsp;we like to build content models&nbsp;based on IA site maps and qualitative user testing such as card sorting&nbsp;and user journey mapping.&nbsp;&nbsp;</p></h3>" +


            "<BlogPageComponentRow>" +
            "<BlogComponentData>21" +
            "<BlogComponentData>1" +
            "<BlogComponentData>21" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><h3><p>By&nbsp;using a content-first&nbsp;design&nbsp;approach, you can&nbsp;understand what content needs to fit&nbsp;into your website&nbsp;design.&nbsp;Analysing your website’s content needs in the early stages or,&nbsp;even better, prior to the project beginning,&nbsp;can effectively&nbsp;inform and shape all touch points ultimately generating an optimised&nbsp;result&nbsp;with reduced time delays and constraints&nbsp;along the way. If you&nbsp;have a web project in mind and need help&nbsp;on how to get started,&nbsp;<a href=\"https://www.netconstruct.co.uk/contact/\">get in touch</a>&nbsp;with the team today.&nbsp;&nbsp;&nbsp;</p></h3>" +

            "<BlogPageComponentRow>" +
            "<BlogComponentData>2" +
            "<BlogComponentData>1" +
            "<BlogComponentData>2" +
            "<BlogComponentData>Content" +
            "<BlogComponentData><hr>";

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