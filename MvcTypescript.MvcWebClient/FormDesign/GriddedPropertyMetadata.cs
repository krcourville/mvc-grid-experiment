using System.Web.Mvc;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    public class GriddedPropertyMetadata
    {
        public FormGridMetaAttribute Grid { get; set; }
        public ModelMetadata Property { get; set; }

        public override string ToString()
        {
            if( Grid == null || Property == null)
            {
                return null;
            }

            return string.Format(
                "Property={0}.{1}, Row={2}, Column={3}",
                Property.ContainerType != null ? Property.ContainerType.Name : "Unknown",
                Property.DisplayName,
                Grid.Row,
                Grid.Column
            );
        }
    }
}