using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    public class FormGrid
    {
        public ICollection<FormGridRow> Rows { get; private set; }

        public static FormGrid FromFormSectionMetadata(ModelMetadata formSectionMetadata)
        {
            return new FormGrid(formSectionMetadata);
        }

        private FormGrid(ModelMetadata formSectionMetadata)
        {
            Rows = formSectionMetadata.Properties.Select(s => new GriddedPropertyMetadata
            {
                Property = s,
                Grid = s.GetGrid()
            })
            .OrderBy(o => o.Grid.Row)
            .ThenBy(o => o.Grid.Column)
            .GroupBy(o => o.Grid.Row)
            .Select(o => new FormGridRow(formSectionMetadata.GetFormSectionMeta(), o.ToList()))
            .ToList();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var row in Rows)
            {
                sb.AppendFormat("{0}\n", string.Join("|", row.Cells.Select(cell => cell.LabelText)));
            }
            return sb.ToString();
        }

    }
}