//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class UsageSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<UsageSearchRowBasic>
        {
            protected override Dictionary<string, Action<UsageSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<UsageSearchRowBasic>> {
                    { "customer", r => r.@customer = new [] { new SearchColumnSelectField { customLabel = "customer" } } },
                    { "date", r => r.@date = new [] { new SearchColumnDateField { customLabel = "date" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "quantity", r => r.@quantity = new [] { new SearchColumnDoubleField { customLabel = "quantity" } } },
                    { "subscription", r => r.@subscription = new [] { new SearchColumnSelectField { customLabel = "subscription" } } },
                    { "subscriptionLine", r => r.@subscriptionLine = new [] { new SearchColumnSelectField { customLabel = "subscriptionLine" } } },
                    { "subscriptionPlan", r => r.@subscriptionPlan = new [] { new SearchColumnSelectField { customLabel = "subscriptionPlan" } } },
                };
            }
        }
    }
}