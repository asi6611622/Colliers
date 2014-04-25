using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Xml.Linq;

namespace Utilitys
{
    public static class Utility
    {
        

       /*=======================================================cookie操作================================================================================= */
        public static void SetCookie(string cookieName,string cookieValue,DateTime expires)
        {
            HttpCookie cookie = new HttpCookie(cookieName);
            cookie.Value=cookieValue;
            cookie.Expires =expires;
            HttpContext.Current.Response.AppendCookie(cookie);
        }
        public  static string  GetCookie(string cookieName)
        {
            string cookieValue = string.Empty;
            string[] keys= HttpContext.Current.Request.Cookies.AllKeys;
            
            if (keys.Contains(cookieName))
            {
                cookieValue = HttpContext.Current.Request.Cookies[cookieName].Value;
            }
            return cookieValue;
        }
         /*=======================================================xml操作================================================================================= */
        public static void CreateXml(string path,string rootName)
        {
            XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8","yes"), new XElement(rootName));
            xdoc.Save(path);
        }

        public static void AddNode(string path,Func<XElement,bool> lambda)
        {
            //添加节点
            XElement xel = new XElement("node1",
                                        new XElement("node2", "node20 values"),
                                        new XElement("node2", "node21 values"),
                                        new XElement("node2", "node22 values")
                                        );
            xel.Save(path);
        }
        /*=======================================================cache操作================================================================================= */

        public static void SetCache(string key,object value,CacheDependency cd,DateTime dt ,TimeSpan ts)
        {
            Cache ch = HttpRuntime.Cache;
            ch.Insert(key, value, cd, dt, ts);
        }
        public static void SetCache(string key, object value, DateTime dt)
        {
            SetCache(key, value, null, dt, TimeSpan.Zero);
        }
        public static object GetCach(string key)
        {
            return null;
        }


    }
}
