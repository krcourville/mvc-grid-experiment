using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcTypescript.MvcWebClient.FormDesign
{
    public class FormGridRow
    {
        private IFormSectionMetaProvider formSectionMeta;

        public FormGridRow(IFormSectionMetaProvider formSectionMeta, ICollection<GriddedPropertyMetadata> items)
        {
            this.formSectionMeta = formSectionMeta;
            LoadCells(items);
        }

        public ICollection<FormGridCell> Cells { get; private set; }

        private void LoadCells(ICollection<GriddedPropertyMetadata> items)
        {
            //TODO: support spanning multiple columns
            var dupe = items.GroupBy(g => g.Grid.Column)
                .SelectMany(g => g.Skip(1))
                .FirstOrDefault();
            if (dupe != null)
            {
                throw new InvalidOperationException(string.Format("Found duplicate grid: {0}", dupe));
            }

            var lookup = items.ToDictionary(d => d.Grid.Column, d => d.Property);
            Cells = Enumerable.Range(1, formSectionMeta.GetTotalColumns())
                .Select(i => lookup.ContainsKey(i)
                    ? new FormGridCell(lookup[i])
                    : FormGridCell.Empty
                )
                .ToList();
        }

    }
}