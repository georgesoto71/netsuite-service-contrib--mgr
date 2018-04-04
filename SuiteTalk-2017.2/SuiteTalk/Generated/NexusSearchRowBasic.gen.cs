//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class NexusSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<NexusSearchRowBasic>
        {
            protected override Dictionary<string, Action<NexusSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<NexusSearchRowBasic>> {
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "description", r => r.@description = new [] { new SearchColumnStringField { customLabel = "description" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "parentNexus", r => r.@parentNexus = new [] { new SearchColumnSelectField { customLabel = "parentNexus" } } },
                    { "state", r => r.@state = new [] { new SearchColumnSelectField { customLabel = "state" } } },
                    { "taxAgency", r => r.@taxAgency = new [] { new SearchColumnSelectField { customLabel = "taxAgency" } } },
                };
            }
        }
    }
}