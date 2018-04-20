//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class SolutionSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<SolutionSearchRowBasic>
        {
            protected override Dictionary<string, Action<SolutionSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<SolutionSearchRowBasic>> {
                    { "assigned", r => r.@assigned = new [] { new SearchColumnSelectField { customLabel = "assigned" } } },
                    { "caseCount", r => r.@caseCount = new [] { new SearchColumnLongField { customLabel = "caseCount" } } },
                    { "createdDate", r => r.@createdDate = new [] { new SearchColumnDateField { customLabel = "createdDate" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "displayOnline", r => r.@displayOnline = new [] { new SearchColumnBooleanField { customLabel = "displayOnline" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "message", r => r.@message = new [] { new SearchColumnStringField { customLabel = "message" } } },
                    { "previewref", r => r.@previewref = new [] { new SearchColumnStringField { customLabel = "previewref" } } },
                    { "solutionCode", r => r.@solutionCode = new [] { new SearchColumnStringField { customLabel = "solutionCode" } } },
                    { "status", r => r.@status = new [] { new SearchColumnEnumSelectField { customLabel = "status" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                };
            }
        }
    }
}