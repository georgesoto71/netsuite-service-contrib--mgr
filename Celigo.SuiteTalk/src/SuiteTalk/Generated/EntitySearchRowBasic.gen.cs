
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class EntitySearchRowBasic
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

        class ColumnFactory:  ColumnFactory<EntitySearchRowBasic>
        {
            protected override Dictionary<string, Action<EntitySearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<EntitySearchRowBasic>> {
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "addressInternalId", r => r.@addressInternalId = new [] { new SearchColumnStringField { customLabel = "addressInternalId" } } },
                    { "addressLabel", r => r.@addressLabel = new [] { new SearchColumnStringField { customLabel = "addressLabel" } } },
                    { "addressPhone", r => r.@addressPhone = new [] { new SearchColumnStringField { customLabel = "addressPhone" } } },
                    { "altEmail", r => r.@altEmail = new [] { new SearchColumnStringField { customLabel = "altEmail" } } },
                    { "altName", r => r.@altName = new [] { new SearchColumnStringField { customLabel = "altName" } } },
                    { "altPhone", r => r.@altPhone = new [] { new SearchColumnStringField { customLabel = "altPhone" } } },
                    { "attention", r => r.@attention = new [] { new SearchColumnStringField { customLabel = "attention" } } },
                    { "billAddress1", r => r.@billAddress1 = new [] { new SearchColumnStringField { customLabel = "billAddress1" } } },
                    { "billAddress2", r => r.@billAddress2 = new [] { new SearchColumnStringField { customLabel = "billAddress2" } } },
                    { "billAddress3", r => r.@billAddress3 = new [] { new SearchColumnStringField { customLabel = "billAddress3" } } },
                    { "billAddressee", r => r.@billAddressee = new [] { new SearchColumnStringField { customLabel = "billAddressee" } } },
                    { "billAttention", r => r.@billAttention = new [] { new SearchColumnStringField { customLabel = "billAttention" } } },
                    { "billCity", r => r.@billCity = new [] { new SearchColumnStringField { customLabel = "billCity" } } },
                    { "billCountry", r => r.@billCountry = new [] { new SearchColumnEnumSelectField { customLabel = "billCountry" } } },
                    { "billCountryCode", r => r.@billCountryCode = new [] { new SearchColumnStringField { customLabel = "billCountryCode" } } },
                    { "billPhone", r => r.@billPhone = new [] { new SearchColumnStringField { customLabel = "billPhone" } } },
                    { "billState", r => r.@billState = new [] { new SearchColumnStringField { customLabel = "billState" } } },
                    { "billZipCode", r => r.@billZipCode = new [] { new SearchColumnStringField { customLabel = "billZipCode" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "comments", r => r.@comments = new [] { new SearchColumnStringField { customLabel = "comments" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "defaultTaxReg", r => r.@defaultTaxReg = new [] { new SearchColumnStringField { customLabel = "defaultTaxReg" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "entityId", r => r.@entityId = new [] { new SearchColumnStringField { customLabel = "entityId" } } },
                    { "entityNumber", r => r.@entityNumber = new [] { new SearchColumnLongField { customLabel = "entityNumber" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "globalSubscriptionStatus", r => r.@globalSubscriptionStatus = new [] { new SearchColumnEnumSelectField { customLabel = "globalSubscriptionStatus" } } },
                    { "image", r => r.@image = new [] { new SearchColumnSelectField { customLabel = "image" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isDefaultBilling", r => r.@isDefaultBilling = new [] { new SearchColumnBooleanField { customLabel = "isDefaultBilling" } } },
                    { "isDefaultShipping", r => r.@isDefaultShipping = new [] { new SearchColumnBooleanField { customLabel = "isDefaultShipping" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "language", r => r.@language = new [] { new SearchColumnEnumSelectField { customLabel = "language" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "level", r => r.@level = new [] { new SearchColumnEnumSelectField { customLabel = "level" } } },
                    { "permission", r => r.@permission = new [] { new SearchColumnEnumSelectField { customLabel = "permission" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "phoneticName", r => r.@phoneticName = new [] { new SearchColumnStringField { customLabel = "phoneticName" } } },
                    { "shipAddress1", r => r.@shipAddress1 = new [] { new SearchColumnStringField { customLabel = "shipAddress1" } } },
                    { "shipAddress2", r => r.@shipAddress2 = new [] { new SearchColumnStringField { customLabel = "shipAddress2" } } },
                    { "shipAddress3", r => r.@shipAddress3 = new [] { new SearchColumnStringField { customLabel = "shipAddress3" } } },
                    { "shipAddressee", r => r.@shipAddressee = new [] { new SearchColumnStringField { customLabel = "shipAddressee" } } },
                    { "shipAttention", r => r.@shipAttention = new [] { new SearchColumnStringField { customLabel = "shipAttention" } } },
                    { "shipCity", r => r.@shipCity = new [] { new SearchColumnStringField { customLabel = "shipCity" } } },
                    { "shipCountry", r => r.@shipCountry = new [] { new SearchColumnEnumSelectField { customLabel = "shipCountry" } } },
                    { "shipCountryCode", r => r.@shipCountryCode = new [] { new SearchColumnStringField { customLabel = "shipCountryCode" } } },
                    { "shipPhone", r => r.@shipPhone = new [] { new SearchColumnStringField { customLabel = "shipPhone" } } },
                    { "shipState", r => r.@shipState = new [] { new SearchColumnStringField { customLabel = "shipState" } } },
                    { "shipZip", r => r.@shipZip = new [] { new SearchColumnStringField { customLabel = "shipZip" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "subscription", r => r.@subscription = new [] { new SearchColumnSelectField { customLabel = "subscription" } } },
                    { "subscriptionDate", r => r.@subscriptionDate = new [] { new SearchColumnDateField { customLabel = "subscriptionDate" } } },
                    { "subscriptionStatus", r => r.@subscriptionStatus = new [] { new SearchColumnBooleanField { customLabel = "subscriptionStatus" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "type", r => r.@type = new [] { new SearchColumnEnumSelectField { customLabel = "type" } } },
                    { "zipCode", r => r.@zipCode = new [] { new SearchColumnStringField { customLabel = "zipCode" } } },
                };
            }
        }
    }
}