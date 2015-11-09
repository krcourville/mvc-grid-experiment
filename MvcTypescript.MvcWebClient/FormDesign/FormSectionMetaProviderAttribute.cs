using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class FormSectionMetaProviderAttribute : Attribute
    {
        // This is a positional argument
        public FormSectionMetaProviderAttribute(Type providerType)
        {
            this.ProviderType = providerType;
        }
        public Type ProviderType { get; private set; }
    }
}