using HtmlAgilityPack;
using RequireJsNet;
using RequireJsNet.Configuration;
using RequireJsNet.Helpers;
using RequireJsNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient.Helpers
{
    public static class RequireJsHtmlHelpers
    {
        /// <summary>
        /// Setup RequireJS to be used in layouts
        /// </summary>
        /// <param name="html">
        /// Html helper.
        /// </param>
        /// <param name="config">
        /// Configuration object for various options.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString RenderRequireJsSetup(
            this HtmlHelper html,
            RequireRendererConfiguration config)
        {
            var result = RequireJsNet.RequireJsHtmlHelpers.RenderRequireJsSetup(html, config);
            var doc = new HtmlDocument();
            doc.LoadHtml(result.ToString());
            //doc.DocumentNode.SelectNodes()


            //return MvcHtmlString.Create(result);
            return result;
        }



    }
}