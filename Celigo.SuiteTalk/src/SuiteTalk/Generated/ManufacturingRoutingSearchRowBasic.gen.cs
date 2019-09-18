//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class ManufacturingRoutingSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<ManufacturingRoutingSearchRowBasic>
        {
            protected override Dictionary<string, Action<ManufacturingRoutingSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<ManufacturingRoutingSearchRowBasic>> {
                    { "autoCalculateLag", r => r.@autoCalculateLag = new [] { new SearchColumnBooleanField { customLabel = "autoCalculateLag" } } },
                    { "billOfMaterials", r => r.@billOfMaterials = new [] { new SearchColumnSelectField { customLabel = "billOfMaterials" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isDefault", r => r.@isDefault = new [] { new SearchColumnBooleanField { customLabel = "isDefault" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "item", r => r.@item = new [] { new SearchColumnSelectField { customLabel = "item" } } },
                    { "lagAmount", r => r.@lagAmount = new [] { new SearchColumnDoubleField { customLabel = "lagAmount" } } },
                    { "lagType", r => r.@lagType = new [] { new SearchColumnEnumSelectField { customLabel = "lagType" } } },
                    { "lagUnits", r => r.@lagUnits = new [] { new SearchColumnStringField { customLabel = "lagUnits" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "manufacturingCostTemplate", r => r.@manufacturingCostTemplate = new [] { new SearchColumnSelectField { customLabel = "manufacturingCostTemplate" } } },
                    { "manufacturingWorkCenter", r => r.@manufacturingWorkCenter = new [] { new SearchColumnSelectField { customLabel = "manufacturingWorkCenter" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "operationName", r => r.@operationName = new [] { new SearchColumnStringField { customLabel = "operationName" } } },
                    { "operationYield", r => r.@operationYield = new [] { new SearchColumnDoubleField { customLabel = "operationYield" } } },
                    { "runRate", r => r.@runRate = new [] { new SearchColumnDoubleField { customLabel = "runRate" } } },
                    { "sequence", r => r.@sequence = new [] { new SearchColumnLongField { customLabel = "sequence" } } },
                    { "setupTime", r => r.@setupTime = new [] { new SearchColumnDoubleField { customLabel = "setupTime" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                };
            }
        }
    }
}