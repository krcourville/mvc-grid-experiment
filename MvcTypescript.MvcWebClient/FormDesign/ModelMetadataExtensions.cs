using MvcTypescript.MvcWebClient.FormDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient
{
    public static class ModelMetadataExtensions
    {
        public static bool IsFormSection(this ModelMetadata metaData)
        {
            return metaData.AdditionalValues.ContainsKey(FormDesignValues.FormSectionMeta);
        }

        public static IFormSectionMetaProvider GetFormSectionMeta(this ModelMetadata metaData)
        {
            if (metaData.AdditionalValues.ContainsKey(FormDesignValues.FormSectionMeta))
            {
                return (IFormSectionMetaProvider)metaData.AdditionalValues[FormDesignValues.FormSectionMeta];
            }

            return new DefaultFormSectionMetaProvider();

        }

        public static FormGridMetaAttribute GetGrid(this ModelMetadata metaData)
        {
            if (metaData.AdditionalValues.ContainsKey(FormDesignValues.FormGridMeta))
            {
                return (FormGridMetaAttribute)metaData.AdditionalValues[FormDesignValues.FormGridMeta];
            }
            else
            {
                throw new NotSupportedException(string.Format(
                    "Properties without a grid value are not supported. Fix property: {0} on class {1}",
                    metaData.PropertyName,
                    metaData.Container != null ? metaData.Container.GetType().Name : "UNKNOWN"
                ));
            }
        }

        public static IEnumerable<FormGrid> ToFormGrids(this ModelMetadata metaData)
        {
            foreach (var prop in metaData.Properties)
            {
                if (prop.IsFormSection())
                {
                    yield return prop.ToFormGrid();
                }

                foreach (var item in prop.Properties)
                {
                    if (prop.IsFormSection())
                    {
                        yield return prop.ToFormGrid();
                    }
                }
            }
        }

        public static FormGrid ToFormGrid(this ModelMetadata formSectionMetadata)
        {
            return FormGrid.FromFormSectionMetadata(formSectionMetadata);
        }
    }
}