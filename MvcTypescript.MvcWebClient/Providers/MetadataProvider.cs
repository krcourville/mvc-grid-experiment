using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Humanizer;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MvcTypescript.MvcWebClient.FormDesign;

namespace MvcTypescript.MvcWebClient.Providers
{
    public class MetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(
            IEnumerable<Attribute> attributes,
            Type containerType,
            Func<object> modelAccessor,
            Type modelType,
            string propertyName)
        {
            var propertyAttributes = attributes.ToList();
            var modelMetadata = base.CreateMetadata(propertyAttributes, containerType, modelAccessor, modelType, propertyName);

            if (IsTransformRequired(modelMetadata, propertyAttributes))
                modelMetadata.DisplayName = modelMetadata.PropertyName.Humanize(LetterCasing.Title);

            HandleAttribute<FormSectionMetaProviderAttribute>(attributes, a =>
            {
                var provider = Activator.CreateInstance(a.ProviderType) as IFormSectionMetaProvider;
                if (provider != null)
                {
                    modelMetadata.AdditionalValues.Add(FormDesignValues.FormSectionMeta, provider);
                }
            });
            HandleAttribute<FormGridMetaAttribute>(attributes, a =>
            {
                modelMetadata.AdditionalValues.Add(FormDesignValues.FormGridMeta, a);
            });
            HandleAttribute<IconAttribute>(attributes, a =>
            {
                modelMetadata.AdditionalValues.Add(FormDesignValues.FormIconUrl, a.Url);
            });

            return modelMetadata;
        }

        private static bool HandleAttribute<T>(IEnumerable<Attribute> attributes, Action<T> callback) where T : Attribute
        {
            foreach (var item in attributes)
            {
                if (item is T)
                {
                    callback((T)item);
                    return true;
                }
            }

            return false;
        }

        private static bool IsTransformRequired(ModelMetadata modelMetadata, IList<Attribute> propertyAttributes)
        {
            if (string.IsNullOrEmpty(modelMetadata.PropertyName))
                return false;

            if (propertyAttributes.OfType<DisplayNameAttribute>().Any())
                return false;

            if (propertyAttributes.OfType<DisplayAttribute>().Any())
                return false;

            return true;
        }
    }
}