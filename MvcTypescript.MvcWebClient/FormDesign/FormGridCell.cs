using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    public class FormGridCell
    {
        private FormGridCell() { }

        public FormGridCell(ModelMetadata modelMetadata)
        {
            this.Meta = modelMetadata;
        }

        public ModelMetadata Meta { get; private set; }

        public string LabelText
        {
            get
            {
                if (Meta == null)
                {
                    return null;
                }

                return string.Format(
                    "{0}{1}",
                    Meta.DisplayName,
                    Meta.IsRequired ? "*" : string.Empty
                );
            }
        }

        public string PropertyName
        {
            get
            {
                return Meta != null ? Meta.PropertyName : "empty";
            }
        }

        public static FormGridCell Empty
        {
            get
            {
                return new FormGridCell();
            }
        }

    }
}