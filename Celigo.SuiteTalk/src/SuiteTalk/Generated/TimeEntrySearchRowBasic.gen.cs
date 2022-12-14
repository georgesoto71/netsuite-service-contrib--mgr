
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class TimeEntrySearchRowBasic
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

        class ColumnFactory:  ColumnFactory<TimeEntrySearchRowBasic>
        {
            protected override Dictionary<string, Action<TimeEntrySearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<TimeEntrySearchRowBasic>> {
                    { "approvalStatus", r => r.@approvalStatus = new [] { new SearchColumnSelectField { customLabel = "approvalStatus" } } },
                    { "billingClass", r => r.@billingClass = new [] { new SearchColumnSelectField { customLabel = "billingClass" } } },
                    { "billingStatus", r => r.@billingStatus = new [] { new SearchColumnStringField { customLabel = "billingStatus" } } },
                    { "break", r => r.@break = new [] { new SearchColumnStringField { customLabel = "break" } } },
                    { "caseTaskEvent", r => r.@caseTaskEvent = new [] { new SearchColumnSelectField { customLabel = "caseTaskEvent" } } },
                    { "class", r => r.@class = new [] { new SearchColumnSelectField { customLabel = "class" } } },
                    { "classNoHierarchy", r => r.@classNoHierarchy = new [] { new SearchColumnSelectField { customLabel = "classNoHierarchy" } } },
                    { "customer", r => r.@customer = new [] { new SearchColumnSelectField { customLabel = "customer" } } },
                    { "date", r => r.@date = new [] { new SearchColumnDateField { customLabel = "date" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "department", r => r.@department = new [] { new SearchColumnSelectField { customLabel = "department" } } },
                    { "departmentNoHierarchy", r => r.@departmentNoHierarchy = new [] { new SearchColumnSelectField { customLabel = "departmentNoHierarchy" } } },
                    { "durationDecimal", r => r.@durationDecimal = new [] { new SearchColumnDoubleField { customLabel = "durationDecimal" } } },
                    { "employee", r => r.@employee = new [] { new SearchColumnSelectField { customLabel = "employee" } } },
                    { "endTime", r => r.@endTime = new [] { new SearchColumnDateField { customLabel = "endTime" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "hours", r => r.@hours = new [] { new SearchColumnStringField { customLabel = "hours" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isBillable", r => r.@isBillable = new [] { new SearchColumnBooleanField { customLabel = "isBillable" } } },
                    { "isExempt", r => r.@isExempt = new [] { new SearchColumnBooleanField { customLabel = "isExempt" } } },
                    { "isProductive", r => r.@isProductive = new [] { new SearchColumnBooleanField { customLabel = "isProductive" } } },
                    { "isUtilized", r => r.@isUtilized = new [] { new SearchColumnBooleanField { customLabel = "isUtilized" } } },
                    { "item", r => r.@item = new [] { new SearchColumnStringField { customLabel = "item" } } },
                    { "lastModified", r => r.@lastModified = new [] { new SearchColumnDateField { customLabel = "lastModified" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "locationNoHierarchy", r => r.@locationNoHierarchy = new [] { new SearchColumnSelectField { customLabel = "locationNoHierarchy" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "nextApprover", r => r.@nextApprover = new [] { new SearchColumnSelectField { customLabel = "nextApprover" } } },
                    { "paidExternally", r => r.@paidExternally = new [] { new SearchColumnBooleanField { customLabel = "paidExternally" } } },
                    { "payItem", r => r.@payItem = new [] { new SearchColumnSelectField { customLabel = "payItem" } } },
                    { "payrollDate", r => r.@payrollDate = new [] { new SearchColumnDateField { customLabel = "payrollDate" } } },
                    { "rate", r => r.@rate = new [] { new SearchColumnDoubleField { customLabel = "rate" } } },
                    { "startTime", r => r.@startTime = new [] { new SearchColumnDateField { customLabel = "startTime" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnStringField { customLabel = "subsidiary" } } },
                    { "subsidiaryNoHierarchy", r => r.@subsidiaryNoHierarchy = new [] { new SearchColumnStringField { customLabel = "subsidiaryNoHierarchy" } } },
                    { "timeSheet", r => r.@timeSheet = new [] { new SearchColumnStringField { customLabel = "timeSheet" } } },
                    { "type", r => r.@type = new [] { new SearchColumnEnumSelectField { customLabel = "type" } } },
                };
            }
        }
    }
}