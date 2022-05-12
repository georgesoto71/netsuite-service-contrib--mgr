
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ConsolidatedExchangeRateSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<ConsolidatedExchangeRateSearchRowBasic>
        {
            protected override Dictionary<string, Action<ConsolidatedExchangeRateSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ConsolidatedExchangeRateSearchRowBasic>> {
                    { "accountingBook", r => r.@accountingBook = new [] { new SearchColumnStringField { customLabel = "accountingBook" } } },
                    { "averageRate", r => r.@averageRate = new [] { new SearchColumnStringField { customLabel = "averageRate" } } },
                    { "closed", r => r.@closed = new [] { new SearchColumnBooleanField { customLabel = "closed" } } },
                    { "currentRate", r => r.@currentRate = new [] { new SearchColumnStringField { customLabel = "currentRate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fromCurrency", r => r.@fromCurrency = new [] { new SearchColumnStringField { customLabel = "fromCurrency" } } },
                    { "fromSubsidiary", r => r.@fromSubsidiary = new [] { new SearchColumnStringField { customLabel = "fromSubsidiary" } } },
                    { "historicalRate", r => r.@historicalRate = new [] { new SearchColumnStringField { customLabel = "historicalRate" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "periodEndDate", r => r.@periodEndDate = new [] { new SearchColumnDateField { customLabel = "periodEndDate" } } },
                    { "periodName", r => r.@periodName = new [] { new SearchColumnStringField { customLabel = "periodName" } } },
                    { "periodStartDate", r => r.@periodStartDate = new [] { new SearchColumnDateField { customLabel = "periodStartDate" } } },
                    { "toCurrency", r => r.@toCurrency = new [] { new SearchColumnStringField { customLabel = "toCurrency" } } },
                    { "toSubsidiary", r => r.@toSubsidiary = new [] { new SearchColumnStringField { customLabel = "toSubsidiary" } } },
                };
            }
        }
    }
}