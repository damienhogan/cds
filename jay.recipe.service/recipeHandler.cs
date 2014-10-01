using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Newtonsoft.Json;
using jay.recipe.common.Service;

namespace jay.recipe.service
{
    public class RecipeHandler : IHttpHandler
    {
        /// <summary>
        /// Contrustor for handler
        /// </summary>
        public RecipeHandler()
        {

        }
        /// <summary>
        /// From IHttpHandler interface, not a reusable handler
        /// </summary>
        public bool IsReusable
        {
            get { return false; }
        }
        /// <summary>
        /// From IHttpHandler
        /// </summary>
        /// <param name="context">The http context passed by the web server</param>
        public void ProcessRequest(HttpContext context)
        {
            //string type = context.Request.Url.GetLeftPart
            string content = getContentBody(context);
            SortedDictionary<string, string> parm = getQueryParams(context);
            Hashtable cmd = Newtonsoft.Json.JsonConvert.DeserializeObject<Hashtable>(content);
            if (!parm.ContainsKey("type"))
            {
                throw new InvalidOperationException("No type provided");
            }
            try
            {
                IService svc = ServiceFactory.createInstance(parm["type"]);
                svc.executeService(cmd, context.Response.Output);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(String.Format("Unable to create type {0}"));
            }
            
            
        }


        private string getContentBody(HttpContext context)
        {
            string ret = string.Empty;
            using (var reader = new StreamReader(context.Request.InputStream))
            {
                ret = reader.ReadToEnd();
            }
          
            return ret;
        }

        private SortedDictionary<string, string> getQueryParams(HttpContext context)
        {
            string[] parts = context.Request.Url.Query.Split('&');
            SortedDictionary<string, string> param = new SortedDictionary<string, string>();
            foreach (string p in parts) {
                string[] kp = p.Split('=');
                if (kp.Length != 1) {
                    throw new InvalidOperationException("Invalid query string");
                }
                param[kp[0]] = Uri.UnescapeDataString(kp[1]);
            }
            return param;

        }
    }
}
