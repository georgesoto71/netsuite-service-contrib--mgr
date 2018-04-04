//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class PromotionCodeSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<PromotionCodeSearchRowBasic>
        {
            protected override Dictionary<string, Action<PromotionCodeSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<PromotionCodeSearchRowBasic>> {
                    { "code", r => r.@code = new [] { new SearchColumnStringField { customLabel = "code" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "discount", r => r.@discount = new [] { new SearchColumnStringField { customLabel = "discount" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isPublic", r => r.@isPublic = new [] { new SearchColumnBooleanField { customLabel = "isPublic" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                };
            }
        }
    }
}