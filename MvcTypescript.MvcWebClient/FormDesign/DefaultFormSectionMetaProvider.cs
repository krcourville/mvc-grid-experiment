using System;
using MvcTypescript.MvcWebClient.FormDesign;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    public class DefaultFormSectionMetaProvider : IFormSectionMetaProvider
    {
        public int GetTotalColumns()
        {
            return 2;
        }
    }
}