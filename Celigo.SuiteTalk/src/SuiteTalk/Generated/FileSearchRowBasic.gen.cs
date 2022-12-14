
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class FileSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<FileSearchRowBasic>
        {
            protected override Dictionary<string, Action<FileSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<FileSearchRowBasic>> {
                    { "availableWithoutLogin", r => r.@availableWithoutLogin = new [] { new SearchColumnBooleanField { customLabel = "availableWithoutLogin" } } },
                    { "created", r => r.@created = new [] { new SearchColumnDateField { customLabel = "created" } } },
                    { "dateViewed", r => r.@dateViewed = new [] { new SearchColumnDateField { customLabel = "dateViewed" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "documentSize", r => r.@documentSize = new [] { new SearchColumnLongField { customLabel = "documentSize" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fileType", r => r.@fileType = new [] { new SearchColumnEnumSelectField { customLabel = "fileType" } } },
                    { "folder", r => r.@folder = new [] { new SearchColumnSelectField { customLabel = "folder" } } },
                    { "hits", r => r.@hits = new [] { new SearchColumnLongField { customLabel = "hits" } } },
                    { "hostedPath", r => r.@hostedPath = new [] { new SearchColumnStringField { customLabel = "hostedPath" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isAvailable", r => r.@isAvailable = new [] { new SearchColumnBooleanField { customLabel = "isAvailable" } } },
                    { "modified", r => r.@modified = new [] { new SearchColumnDateField { customLabel = "modified" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "owner", r => r.@owner = new [] { new SearchColumnSelectField { customLabel = "owner" } } },
                    { "url", r => r.@url = new [] { new SearchColumnStringField { customLabel = "url" } } },
                };
            }
        }
    }
}