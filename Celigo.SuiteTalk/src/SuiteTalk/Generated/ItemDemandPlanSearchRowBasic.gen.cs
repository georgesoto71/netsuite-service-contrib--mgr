
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ItemDemandPlanSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<ItemDemandPlanSearchRowBasic>
        {
            protected override Dictionary<string, Action<ItemDemandPlanSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ItemDemandPlanSearchRowBasic>> {
                    { "alternateSourceItem", r => r.@alternateSourceItem = new [] { new SearchColumnSelectField { customLabel = "alternateSourceItem" } } },
                    { "analysisDuration", r => r.@analysisDuration = new [] { new SearchColumnLongField { customLabel = "analysisDuration" } } },
                    { "demandDate", r => r.@demandDate = new [] { new SearchColumnDateField { customLabel = "demandDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "projectionDuration", r => r.@projectionDuration = new [] { new SearchColumnLongField { customLabel = "projectionDuration" } } },
                    { "projectionInterval", r => r.@projectionInterval = new [] { new SearchColumnStringField { customLabel = "projectionInterval" } } },
                    { "projectionMethod", r => r.@projectionMethod = new [] { new SearchColumnStringField { customLabel = "projectionMethod" } } },
                    { "projectionStartDate", r => r.@projectionStartDate = new [] { new SearchColumnDateField { customLabel = "projectionStartDate" } } },
                    { "quantity", r => r.@quantity = new [] { new SearchColumnDoubleField { customLabel = "quantity" } } },
                    { "quantityUom", r => r.@quantityUom = new [] { new SearchColumnDoubleField { customLabel = "quantityUom" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "units", r => r.@units = new [] { new SearchColumnSelectField { customLabel = "units" } } },
                };
            }
        }
    }
}