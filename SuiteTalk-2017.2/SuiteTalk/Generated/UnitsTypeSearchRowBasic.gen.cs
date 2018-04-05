//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class UnitsTypeSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<UnitsTypeSearchRowBasic>
        {
            protected override Dictionary<string, Action<UnitsTypeSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<UnitsTypeSearchRowBasic>> {
                    { "abbreviation", r => r.@abbreviation = new [] { new SearchColumnStringField { customLabel = "abbreviation" } } },
                    { "baseUnit", r => r.@baseUnit = new [] { new SearchColumnBooleanField { customLabel = "baseUnit" } } },
                    { "conversionRate", r => r.@conversionRate = new [] { new SearchColumnStringField { customLabel = "conversionRate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isInActive", r => r.@isInActive = new [] { new SearchColumnBooleanField { customLabel = "isInActive" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "pluralAbbreviation", r => r.@pluralAbbreviation = new [] { new SearchColumnStringField { customLabel = "pluralAbbreviation" } } },
                    { "pluralName", r => r.@pluralName = new [] { new SearchColumnStringField { customLabel = "pluralName" } } },
                    { "unitName", r => r.@unitName = new [] { new SearchColumnStringField { customLabel = "unitName" } } },
                };
            }
        }
    }
}