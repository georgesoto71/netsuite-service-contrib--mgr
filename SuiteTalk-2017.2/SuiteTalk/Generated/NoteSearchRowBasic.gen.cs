//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class NoteSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<NoteSearchRowBasic>
        {
            protected override Dictionary<string, Action<NoteSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<NoteSearchRowBasic>> {
                    { "author", r => r.@author = new [] { new SearchColumnSelectField { customLabel = "author" } } },
                    { "direction", r => r.@direction = new [] { new SearchColumnStringField { customLabel = "direction" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "note", r => r.@note = new [] { new SearchColumnStringField { customLabel = "note" } } },
                    { "noteDate", r => r.@noteDate = new [] { new SearchColumnDateField { customLabel = "noteDate" } } },
                    { "noteType", r => r.@noteType = new [] { new SearchColumnStringField { customLabel = "noteType" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                };
            }
        }
    }
}