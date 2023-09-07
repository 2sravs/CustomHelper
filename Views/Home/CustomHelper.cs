using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CustomHelper.Views.Home
{
    public class CustomHelper.View.Home
    {
        public static HtmlString File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());
        }
    }
}

namespace CustomHelper
{
    class MvcHtmlString : HtmlString
    {
        public MvcHtmlString(string? value) : base(value)
        {
        }
    }
}