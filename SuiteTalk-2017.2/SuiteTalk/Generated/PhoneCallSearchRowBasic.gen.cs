//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class PhoneCallSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<PhoneCallSearchRowBasic>
        {
            protected override Dictionary<string, Action<PhoneCallSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<PhoneCallSearchRowBasic>> {
                    { "accessLevel", r => r.@accessLevel = new [] { new SearchColumnStringField { customLabel = "accessLevel" } } },
                    { "assigned", r => r.@assigned = new [] { new SearchColumnSelectField { customLabel = "assigned" } } },
                    { "company", r => r.@company = new [] { new SearchColumnSelectField { customLabel = "company" } } },
                    { "completedDate", r => r.@completedDate = new [] { new SearchColumnDateField { customLabel = "completedDate" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnSelectField { customLabel = "contact" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "markdone", r => r.@markdone = new [] { new SearchColumnStringField { customLabel = "markdone" } } },
                    { "message", r => r.@message = new [] { new SearchColumnStringField { customLabel = "message" } } },
                    { "owner", r => r.@owner = new [] { new SearchColumnSelectField { customLabel = "owner" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "priority", r => r.@priority = new [] { new SearchColumnEnumSelectField { customLabel = "priority" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "startTime", r => r.@startTime = new [] { new SearchColumnDateField { customLabel = "startTime" } } },
                    { "status", r => r.@status = new [] { new SearchColumnEnumSelectField { customLabel = "status" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "transaction", r => r.@transaction = new [] { new SearchColumnSelectField { customLabel = "transaction" } } },
                };
            }
        }
    }
}