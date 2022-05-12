
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class AddressSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<AddressSearchRowBasic>
        {
            protected override Dictionary<string, Action<AddressSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<AddressSearchRowBasic>> {
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "attention", r => r.@attention = new [] { new SearchColumnStringField { customLabel = "attention" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "override", r => r.@override = new [] { new SearchColumnBooleanField { customLabel = "override" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "zip", r => r.@zip = new [] { new SearchColumnStringField { customLabel = "zip" } } },
                };
            }
        }
    }
}