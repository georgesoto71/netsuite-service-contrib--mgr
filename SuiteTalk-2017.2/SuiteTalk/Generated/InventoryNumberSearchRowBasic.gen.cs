//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class InventoryNumberSearchRowBasic
    {
        private static readonly Lazy<ColumnFactory> meta = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public void SetColumns(string[] columnNames)
        {
            var factory = meta.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<InventoryNumberSearchRowBasic>
        {
            protected override Dictionary<string, Action<InventoryNumberSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<InventoryNumberSearchRowBasic>> {
                    { "expirationDate", r => r.@expirationDate = new [] { new SearchColumnDateField { customLabel = "expirationDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "inventoryNumber", r => r.@inventoryNumber = new [] { new SearchColumnStringField { customLabel = "inventoryNumber" } } },
                    { "isonhand", r => r.@isonhand = new [] { new SearchColumnBooleanField { customLabel = "isonhand" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "quantityavailable", r => r.@quantityavailable = new [] { new SearchColumnDoubleField { customLabel = "quantityavailable" } } },
                    { "quantityintransit", r => r.@quantityintransit = new [] { new SearchColumnDoubleField { customLabel = "quantityintransit" } } },
                    { "quantityonhand", r => r.@quantityonhand = new [] { new SearchColumnDoubleField { customLabel = "quantityonhand" } } },
                    { "quantityonorder", r => r.@quantityonorder = new [] { new SearchColumnDoubleField { customLabel = "quantityonorder" } } },
                };
            }
        }
    }
}