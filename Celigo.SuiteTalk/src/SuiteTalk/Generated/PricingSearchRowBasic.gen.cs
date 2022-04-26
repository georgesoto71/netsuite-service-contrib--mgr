
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class PricingSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<PricingSearchRowBasic>
        {
            protected override Dictionary<string, Action<PricingSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<PricingSearchRowBasic>> {
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "customer", r => r.@customer = new [] { new SearchColumnSelectField { customLabel = "customer" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "maximumQuantity", r => r.@maximumQuantity = new [] { new SearchColumnDoubleField { customLabel = "maximumQuantity" } } },
                    { "minimumQuantity", r => r.@minimumQuantity = new [] { new SearchColumnDoubleField { customLabel = "minimumQuantity" } } },
                    { "priceLevel", r => r.@priceLevel = new [] { new SearchColumnSelectField { customLabel = "priceLevel" } } },
                    { "quantityRange", r => r.@quantityRange = new [] { new SearchColumnStringField { customLabel = "quantityRange" } } },
                    { "saleUnit", r => r.@saleUnit = new [] { new SearchColumnSelectField { customLabel = "saleUnit" } } },
                    { "unitPrice", r => r.@unitPrice = new [] { new SearchColumnDoubleField { customLabel = "unitPrice" } } },
                };
            }
        }
    }
}