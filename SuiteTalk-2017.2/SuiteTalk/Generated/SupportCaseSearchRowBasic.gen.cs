//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class SupportCaseSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<SupportCaseSearchRowBasic>
        {
            protected override Dictionary<string, Action<SupportCaseSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<SupportCaseSearchRowBasic>> {
                    { "assigned", r => r.@assigned = new [] { new SearchColumnSelectField { customLabel = "assigned" } } },
                    { "awaitingReply", r => r.@awaitingReply = new [] { new SearchColumnBooleanField { customLabel = "awaitingReply" } } },
                    { "caseNumber", r => r.@caseNumber = new [] { new SearchColumnStringField { customLabel = "caseNumber" } } },
                    { "category", r => r.@category = new [] { new SearchColumnSelectField { customLabel = "category" } } },
                    { "company", r => r.@company = new [] { new SearchColumnSelectField { customLabel = "company" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnSelectField { customLabel = "contact" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "customerStage", r => r.@customerStage = new [] { new SearchColumnEnumSelectField { customLabel = "customerStage" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "escalatee", r => r.@escalatee = new [] { new SearchColumnSelectField { customLabel = "escalatee" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "helpDesk", r => r.@helpDesk = new [] { new SearchColumnBooleanField { customLabel = "helpDesk" } } },
                    { "inboundEmail", r => r.@inboundEmail = new [] { new SearchColumnStringField { customLabel = "inboundEmail" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "issue", r => r.@issue = new [] { new SearchColumnSelectField { customLabel = "issue" } } },
                    { "issueNumber", r => r.@issueNumber = new [] { new SearchColumnStringField { customLabel = "issueNumber" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "lastMessageDate", r => r.@lastMessageDate = new [] { new SearchColumnDateField { customLabel = "lastMessageDate" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "lastReopenedDate", r => r.@lastReopenedDate = new [] { new SearchColumnDateField { customLabel = "lastReopenedDate" } } },
                    { "locked", r => r.@locked = new [] { new SearchColumnBooleanField { customLabel = "locked" } } },
                    { "module", r => r.@module = new [] { new SearchColumnSelectField { customLabel = "module" } } },
                    { "origin", r => r.@origin = new [] { new SearchColumnSelectField { customLabel = "origin" } } },
                    { "priority", r => r.@priority = new [] { new SearchColumnSelectField { customLabel = "priority" } } },
                    { "product", r => r.@product = new [] { new SearchColumnSelectField { customLabel = "product" } } },
                    { "profile", r => r.@profile = new [] { new SearchColumnSelectField { customLabel = "profile" } } },
                    { "serialNumber", r => r.@serialNumber = new [] { new SearchColumnStringField { customLabel = "serialNumber" } } },
                    { "stage", r => r.@stage = new [] { new SearchColumnEnumSelectField { customLabel = "stage" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "status", r => r.@status = new [] { new SearchColumnSelectField { customLabel = "status" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                };
            }
        }
    }
}