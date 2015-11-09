using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTypescript.MvcWebClient
{
    public class RenderHelper
    {
        public static string RenderAppVersion()
        {
            //
            // TODO: use file hash of generated script
            // http://blogs.iis.net/robert_mcmurray/simple-utility-to-calculate-file-hashes
            return "0";
        }
    }
}