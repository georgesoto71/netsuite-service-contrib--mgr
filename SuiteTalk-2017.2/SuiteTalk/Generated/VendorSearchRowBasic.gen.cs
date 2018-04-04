//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class VendorSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<VendorSearchRowBasic>
        {
            protected override Dictionary<string, Action<VendorSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<VendorSearchRowBasic>> {
                    { "accountNumber", r => r.@accountNumber = new [] { new SearchColumnStringField { customLabel = "accountNumber" } } },
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "addressInternalId", r => r.@addressInternalId = new [] { new SearchColumnStringField { customLabel = "addressInternalId" } } },
                    { "addressLabel", r => r.@addressLabel = new [] { new SearchColumnStringField { customLabel = "addressLabel" } } },
                    { "addressPhone", r => r.@addressPhone = new [] { new SearchColumnStringField { customLabel = "addressPhone" } } },
                    { "altContact", r => r.@altContact = new [] { new SearchColumnStringField { customLabel = "altContact" } } },
                    { "altEmail", r => r.@altEmail = new [] { new SearchColumnStringField { customLabel = "altEmail" } } },
                    { "altName", r => r.@altName = new [] { new SearchColumnStringField { customLabel = "altName" } } },
                    { "altPhone", r => r.@altPhone = new [] { new SearchColumnStringField { customLabel = "altPhone" } } },
                    { "attention", r => r.@attention = new [] { new SearchColumnStringField { customLabel = "attention" } } },
                    { "balance", r => r.@balance = new [] { new SearchColumnDoubleField { customLabel = "balance" } } },
                    { "billAddress", r => r.@billAddress = new [] { new SearchColumnStringField { customLabel = "billAddress" } } },
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
                    { "category", r => r.@category = new [] { new SearchColumnSelectField { customLabel = "category" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "comments", r => r.@comments = new [] { new SearchColumnStringField { customLabel = "comments" } } },
                    { "companyName", r => r.@companyName = new [] { new SearchColumnStringField { customLabel = "companyName" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnStringField { customLabel = "contact" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "creditLimit", r => r.@creditLimit = new [] { new SearchColumnDoubleField { customLabel = "creditLimit" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "currentExchangeRate", r => r.@currentExchangeRate = new [] { new SearchColumnDoubleField { customLabel = "currentExchangeRate" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "eligibleForCommission", r => r.@eligibleForCommission = new [] { new SearchColumnBooleanField { customLabel = "eligibleForCommission" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "emailPreference", r => r.@emailPreference = new [] { new SearchColumnEnumSelectField { customLabel = "emailPreference" } } },
                    { "emailTransactions", r => r.@emailTransactions = new [] { new SearchColumnBooleanField { customLabel = "emailTransactions" } } },
                    { "entityId", r => r.@entityId = new [] { new SearchColumnStringField { customLabel = "entityId" } } },
                    { "entityNumber", r => r.@entityNumber = new [] { new SearchColumnLongField { customLabel = "entityNumber" } } },
                    { "expenseAccount", r => r.@expenseAccount = new [] { new SearchColumnSelectField { customLabel = "expenseAccount" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "faxTransactions", r => r.@faxTransactions = new [] { new SearchColumnBooleanField { customLabel = "faxTransactions" } } },
                    { "firstName", r => r.@firstName = new [] { new SearchColumnStringField { customLabel = "firstName" } } },
                    { "fxBalance", r => r.@fxBalance = new [] { new SearchColumnDoubleField { customLabel = "fxBalance" } } },
                    { "fxUnbilledOrders", r => r.@fxUnbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "fxUnbilledOrders" } } },
                    { "giveAccess", r => r.@giveAccess = new [] { new SearchColumnBooleanField { customLabel = "giveAccess" } } },
                    { "globalSubscriptionStatus", r => r.@globalSubscriptionStatus = new [] { new SearchColumnEnumSelectField { customLabel = "globalSubscriptionStatus" } } },
                    { "hasDuplicates", r => r.@hasDuplicates = new [] { new SearchColumnBooleanField { customLabel = "hasDuplicates" } } },
                    { "homePhone", r => r.@homePhone = new [] { new SearchColumnStringField { customLabel = "homePhone" } } },
                    { "image", r => r.@image = new [] { new SearchColumnSelectField { customLabel = "image" } } },
                    { "incoterm", r => r.@incoterm = new [] { new SearchColumnSelectField { customLabel = "incoterm" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "is1099Eligible", r => r.@is1099Eligible = new [] { new SearchColumnBooleanField { customLabel = "is1099Eligible" } } },
                    { "isDefaultBilling", r => r.@isDefaultBilling = new [] { new SearchColumnBooleanField { customLabel = "isDefaultBilling" } } },
                    { "isDefaultShipping", r => r.@isDefaultShipping = new [] { new SearchColumnBooleanField { customLabel = "isDefaultShipping" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isJobResourceVend", r => r.@isJobResourceVend = new [] { new SearchColumnBooleanField { customLabel = "isJobResourceVend" } } },
                    { "isPerson", r => r.@isPerson = new [] { new SearchColumnBooleanField { customLabel = "isPerson" } } },
                    { "laborCost", r => r.@laborCost = new [] { new SearchColumnDoubleField { customLabel = "laborCost" } } },
                    { "language", r => r.@language = new [] { new SearchColumnEnumSelectField { customLabel = "language" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "lastName", r => r.@lastName = new [] { new SearchColumnStringField { customLabel = "lastName" } } },
                    { "level", r => r.@level = new [] { new SearchColumnEnumSelectField { customLabel = "level" } } },
                    { "middleName", r => r.@middleName = new [] { new SearchColumnStringField { customLabel = "middleName" } } },
                    { "mobilePhone", r => r.@mobilePhone = new [] { new SearchColumnStringField { customLabel = "mobilePhone" } } },
                    { "payablesAccount", r => r.@payablesAccount = new [] { new SearchColumnSelectField { customLabel = "payablesAccount" } } },
                    { "pec", r => r.@pec = new [] { new SearchColumnStringField { customLabel = "pec" } } },
                    { "permission", r => r.@permission = new [] { new SearchColumnEnumSelectField { customLabel = "permission" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "phoneticName", r => r.@phoneticName = new [] { new SearchColumnStringField { customLabel = "phoneticName" } } },
                    { "printOnCheckAs", r => r.@printOnCheckAs = new [] { new SearchColumnStringField { customLabel = "printOnCheckAs" } } },
                    { "printTransactions", r => r.@printTransactions = new [] { new SearchColumnBooleanField { customLabel = "printTransactions" } } },
                    { "purchaseOrderAmount", r => r.@purchaseOrderAmount = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderAmount" } } },
                    { "purchaseOrderQuantity", r => r.@purchaseOrderQuantity = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderQuantity" } } },
                    { "purchaseOrderQuantityDiff", r => r.@purchaseOrderQuantityDiff = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderQuantityDiff" } } },
                    { "receiptAmount", r => r.@receiptAmount = new [] { new SearchColumnDoubleField { customLabel = "receiptAmount" } } },
                    { "receiptQuantity", r => r.@receiptQuantity = new [] { new SearchColumnDoubleField { customLabel = "receiptQuantity" } } },
                    { "receiptQuantityDiff", r => r.@receiptQuantityDiff = new [] { new SearchColumnDoubleField { customLabel = "receiptQuantityDiff" } } },
                    { "salutation", r => r.@salutation = new [] { new SearchColumnStringField { customLabel = "salutation" } } },
                    { "shipAddress", r => r.@shipAddress = new [] { new SearchColumnStringField { customLabel = "shipAddress" } } },
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
                    { "taxIdNum", r => r.@taxIdNum = new [] { new SearchColumnStringField { customLabel = "taxIdNum" } } },
                    { "terms", r => r.@terms = new [] { new SearchColumnSelectField { customLabel = "terms" } } },
                    { "timeApprover", r => r.@timeApprover = new [] { new SearchColumnSelectField { customLabel = "timeApprover" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "unbilledOrders", r => r.@unbilledOrders = new [] { new SearchColumnDoubleField { customLabel = "unbilledOrders" } } },
                    { "url", r => r.@url = new [] { new SearchColumnStringField { customLabel = "url" } } },
                    { "vatRegNumber", r => r.@vatRegNumber = new [] { new SearchColumnStringField { customLabel = "vatRegNumber" } } },
                    { "workCalendar", r => r.@workCalendar = new [] { new SearchColumnSelectField { customLabel = "workCalendar" } } },
                    { "zipCode", r => r.@zipCode = new [] { new SearchColumnStringField { customLabel = "zipCode" } } },
                };
            }
        }
    }
}