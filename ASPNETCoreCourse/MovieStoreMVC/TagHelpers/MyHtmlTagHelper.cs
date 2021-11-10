using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.TagHelpers
{
    public static class MyHtmlTagHelper
    {
        public static IHtmlContent HelloWorldWithHTML(this IHtmlHelper htmlHelper)
        {
            return new HtmlString("<strong>Hello World</strong>");
        }

        public static string HelloWorldString(this IHtmlHelper htmlHelper)
        {
            return "<strong>Hello World</strong>";
        }

        public static IHtmlContent HelloWorldWithName(this IHtmlHelper htmlHelper, string name)
        {
            TagBuilder span = new TagBuilder("span");
            span.InnerHtml.Append("Hello " + name + "!");


            //<br />
            TagBuilder br = new TagBuilder("br")
            {
                TagRenderMode = TagRenderMode.SelfClosing
            };

            string result;

            using (StringWriter writer = new StringWriter())
            {
                span.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                br.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);

                result = writer.ToString();
            }

            return new HtmlString(result);
        }


    }
}
