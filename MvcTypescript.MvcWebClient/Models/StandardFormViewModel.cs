using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTypescript.MvcWebClient.Models
{
    public class StandardFormViewModel
    {
        public StandardFormViewModel(object data)
        {
            Data = data;
        }

        public string Title { get; set; }
        public object Data { get; set; }
        public string Instructions { get; internal set; }
        public string ReturnUrl { get; internal set; }
        public string ReturnText { get; internal set; }
    }
}