//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class FairValuePriceSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<FairValuePriceSearchRowBasic>
        {
            protected override Dictionary<string, Action<FairValuePriceSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<FairValuePriceSearchRowBasic>> {
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fairValue", r => r.@fairValue = new [] { new SearchColumnDoubleField { customLabel = "fairValue" } } },
                    { "fairValueFormula", r => r.@fairValueFormula = new [] { new SearchColumnSelectField { customLabel = "fairValueFormula" } } },
                    { "fairValueRangePolicy", r => r.@fairValueRangePolicy = new [] { new SearchColumnEnumSelectField { customLabel = "fairValueRangePolicy" } } },
                    { "highValue", r => r.@highValue = new [] { new SearchColumnDoubleField { customLabel = "highValue" } } },
                    { "highValuePercent", r => r.@highValuePercent = new [] { new SearchColumnDoubleField { customLabel = "highValuePercent" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isVsoePrice", r => r.@isVsoePrice = new [] { new SearchColumnBooleanField { customLabel = "isVsoePrice" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "itemRevenueCategory", r => r.@itemRevenueCategory = new [] { new SearchColumnSelectField { customLabel = "itemRevenueCategory" } } },
                    { "lowValue", r => r.@lowValue = new [] { new SearchColumnDoubleField { customLabel = "lowValue" } } },
                    { "lowValuePercent", r => r.@lowValuePercent = new [] { new SearchColumnDoubleField { customLabel = "lowValuePercent" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "units", r => r.@units = new [] { new SearchColumnSelectField { customLabel = "units" } } },
                    { "unitsType", r => r.@unitsType = new [] { new SearchColumnSelectField { customLabel = "unitsType" } } },
                };
            }
        }
    }
}