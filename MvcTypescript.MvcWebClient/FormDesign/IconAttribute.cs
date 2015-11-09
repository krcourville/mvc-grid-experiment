using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    public class IconAttribute : Attribute
    {
        public IconAttribute(string url)
        {
            Url = url;
        }
        public string Url { get; private set; }
    }
}