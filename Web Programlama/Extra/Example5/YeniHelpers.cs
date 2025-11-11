using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Basic.Helpers
{
    public static class YeniHelper
    {
        public static IHtmlContent YeniTextBox(this IHtmlHelper helpers, string name,string value)
        {
            return helpers.TextBox(name, value, new
            {
                @class = "form-control"
            });
        }    
    }
}
