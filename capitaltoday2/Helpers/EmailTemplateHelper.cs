using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace capitaltoday2.Helpers
{
    public class EmailTemplateHelper
    {
        public static string GetTemplate(string name)
        {
            string filepath = System.Web.HttpContext.Current.Server.MapPath("\\content\\emails\\" + name + ".htm");
            string content = string.Empty;

            using (var stream = new StreamReader(filepath))
            {
                content = stream.ReadToEnd();
            }
            return content;
        }
    }
}