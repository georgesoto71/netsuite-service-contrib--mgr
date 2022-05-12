
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class TaskSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<TaskSearchRowBasic>
        {
            protected override Dictionary<string, Action<TaskSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<TaskSearchRowBasic>> {
                    { "accessLevel", r => r.@accessLevel = new [] { new SearchColumnStringField { customLabel = "accessLevel" } } },
                    { "actualTime", r => r.@actualTime = new [] { new SearchColumnDoubleField { customLabel = "actualTime" } } },
                    { "assigned", r => r.@assigned = new [] { new SearchColumnSelectField { customLabel = "assigned" } } },
                    { "company", r => r.@company = new [] { new SearchColumnSelectField { customLabel = "company" } } },
                    { "completedDate", r => r.@completedDate = new [] { new SearchColumnDateField { customLabel = "completedDate" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnSelectField { customLabel = "contact" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "dueDate", r => r.@dueDate = new [] { new SearchColumnDateField { customLabel = "dueDate" } } },
                    { "estimatedTime", r => r.@estimatedTime = new [] { new SearchColumnDoubleField { customLabel = "estimatedTime" } } },
                    { "estimatedTimeOverride", r => r.@estimatedTimeOverride = new [] { new SearchColumnDoubleField { customLabel = "estimatedTimeOverride" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isJobSummaryTask", r => r.@isJobSummaryTask = new [] { new SearchColumnBooleanField { customLabel = "isJobSummaryTask" } } },
                    { "isJobTask", r => r.@isJobTask = new [] { new SearchColumnBooleanField { customLabel = "isJobTask" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "markdone", r => r.@markdone = new [] { new SearchColumnStringField { customLabel = "markdone" } } },
                    { "message", r => r.@message = new [] { new SearchColumnStringField { customLabel = "message" } } },
                    { "milestone", r => r.@milestone = new [] { new SearchColumnSelectField { customLabel = "milestone" } } },
                    { "order", r => r.@order = new [] { new SearchColumnLongField { customLabel = "order" } } },
                    { "owner", r => r.@owner = new [] { new SearchColumnSelectField { customLabel = "owner" } } },
                    { "percentComplete", r => r.@percentComplete = new [] { new SearchColumnDoubleField { customLabel = "percentComplete" } } },
                    { "percentTimeComplete", r => r.@percentTimeComplete = new [] { new SearchColumnDoubleField { customLabel = "percentTimeComplete" } } },
                    { "priority", r => r.@priority = new [] { new SearchColumnEnumSelectField { customLabel = "priority" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "startTime", r => r.@startTime = new [] { new SearchColumnStringField { customLabel = "startTime" } } },
                    { "status", r => r.@status = new [] { new SearchColumnEnumSelectField { customLabel = "status" } } },
                    { "timeRemaining", r => r.@timeRemaining = new [] { new SearchColumnDoubleField { customLabel = "timeRemaining" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "transaction", r => r.@transaction = new [] { new SearchColumnSelectField { customLabel = "transaction" } } },
                };
            }
        }
    }
}