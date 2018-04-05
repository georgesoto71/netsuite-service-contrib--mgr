//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class TimeSheetSearchRowBasic
    {
        private static readonly Lazy<ColumnFactory> columnFactoryLoader = new Lazy<ColumnFactory>(() => new ColumnFactory());

        public override void SetColumns(string[] columnNames)
        {
            var factory = columnFactoryLoader.Value;
            for (int i = 0; i < columnNames.Length; i++)
            {
                factory.BuildColumn(this, columnNames[i]);
            }
        }

        class ColumnFactory:  ColumnFactory<TimeSheetSearchRowBasic>
        {
            protected override Dictionary<string, Action<TimeSheetSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<TimeSheetSearchRowBasic>> {
                    { "approvalStatus", r => r.@approvalStatus = new [] { new SearchColumnSelectField { customLabel = "approvalStatus" } } },
                    { "employee", r => r.@employee = new [] { new SearchColumnSelectField { customLabel = "employee" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "id", r => r.@id = new [] { new SearchColumnLongField { customLabel = "id" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "totalHours", r => r.@totalHours = new [] { new SearchColumnStringField { customLabel = "totalHours" } } },
                };
            }
        }
    }
}