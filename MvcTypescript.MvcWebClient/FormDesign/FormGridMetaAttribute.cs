using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class FormGridMetaAttribute : Attribute
    {

        public FormGridMetaAttribute()
        {

        }
        // This is a positional argument
        public FormGridMetaAttribute(int column, int row)
        {
            Column = column;
            Row = row;
        }

        public int Column { get; set; }
        public int Row { get; set; }
    }
}