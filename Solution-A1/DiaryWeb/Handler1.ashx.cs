using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace DiaryWeb
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            // read the path of tamplet file
            string filePath = context.Request.MapPath("SettingPage.html");
            // read the file
            string fileContent = File.ReadAllText(filePath);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}