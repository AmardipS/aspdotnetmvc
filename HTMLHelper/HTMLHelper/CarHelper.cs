using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// HTMLHelper Class
namespace HTMLHelper
{
    public class CarHelper
    {
        public  static HtmlString showHeading(string heading)
        {
            string htmlString = String.Format("<h1>{0}</h1>", heading);
            return new HtmlString(htmlString);
        }

        public static HtmlString showSubHeading(string subHeading)
        {
            string htmlString = string.Format("<h3>{0}</h3>", subHeading);
            return new HtmlString(htmlString);
        }
    }
}