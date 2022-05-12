
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ItemBinNumberSearchRowBasic
    {
        // TODO: Make this Lazy and Weak referenced so that it can be garbaged collected
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<ItemBinNumberSearchRowBasic>
        {
            protected override Dictionary<string, Action<ItemBinNumberSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ItemBinNumberSearchRowBasic>> {
                    { "binNumber", r => r.@binNumber = new [] { new SearchColumnSelectField { customLabel = "binNumber" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "quantityAvailable", r => r.@quantityAvailable = new [] { new SearchColumnDoubleField { customLabel = "quantityAvailable" } } },
                    { "quantityOnHand", r => r.@quantityOnHand = new [] { new SearchColumnDoubleField { customLabel = "quantityOnHand" } } },
                };
            }
        }
    }
}