
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class TaxTypeSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<TaxTypeSearchRowBasic>
        {
            protected override Dictionary<string, Action<TaxTypeSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<TaxTypeSearchRowBasic>> {
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "doesNotAddToTotal", r => r.@doesNotAddToTotal = new [] { new SearchColumnBooleanField { customLabel = "doesNotAddToTotal" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "nexus", r => r.@nexus = new [] { new SearchColumnSelectField { customLabel = "nexus" } } },
                    { "payablesAccount", r => r.@payablesAccount = new [] { new SearchColumnSelectField { customLabel = "payablesAccount" } } },
                    { "postToItemCost", r => r.@postToItemCost = new [] { new SearchColumnBooleanField { customLabel = "postToItemCost" } } },
                    { "receivablesAccount", r => r.@receivablesAccount = new [] { new SearchColumnSelectField { customLabel = "receivablesAccount" } } },
                    { "reverseCharge", r => r.@reverseCharge = new [] { new SearchColumnBooleanField { customLabel = "reverseCharge" } } },
                    { "taxInNetAmount", r => r.@taxInNetAmount = new [] { new SearchColumnBooleanField { customLabel = "taxInNetAmount" } } },
                };
            }
        }
    }
}