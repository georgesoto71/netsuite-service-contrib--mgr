//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class EmployeeSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<EmployeeSearchRowBasic>
        {
            protected override Dictionary<string, Action<EmployeeSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<EmployeeSearchRowBasic>> {
                    { "accountNumber", r => r.@accountNumber = new [] { new SearchColumnStringField { customLabel = "accountNumber" } } },
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "addressInternalId", r => r.@addressInternalId = new [] { new SearchColumnStringField { customLabel = "addressInternalId" } } },
                    { "addressLabel", r => r.@addressLabel = new [] { new SearchColumnStringField { customLabel = "addressLabel" } } },
                    { "addressPhone", r => r.@addressPhone = new [] { new SearchColumnStringField { customLabel = "addressPhone" } } },
                    { "alienNumber", r => r.@alienNumber = new [] { new SearchColumnStringField { customLabel = "alienNumber" } } },
                    { "allocation", r => r.@allocation = new [] { new SearchColumnDoubleField { customLabel = "allocation" } } },
                    { "altEmail", r => r.@altEmail = new [] { new SearchColumnStringField { customLabel = "altEmail" } } },
                    { "altName", r => r.@altName = new [] { new SearchColumnStringField { customLabel = "altName" } } },
                    { "altPhone", r => r.@altPhone = new [] { new SearchColumnStringField { customLabel = "altPhone" } } },
                    { "approvalLimit", r => r.@approvalLimit = new [] { new SearchColumnDoubleField { customLabel = "approvalLimit" } } },
                    { "approver", r => r.@approver = new [] { new SearchColumnSelectField { customLabel = "approver" } } },
                    { "attention", r => r.@attention = new [] { new SearchColumnStringField { customLabel = "attention" } } },
                    { "authWorkDate", r => r.@authWorkDate = new [] { new SearchColumnDateField { customLabel = "authWorkDate" } } },
                    { "baseWage", r => r.@baseWage = new [] { new SearchColumnDoubleField { customLabel = "baseWage" } } },
                   // NOTE: 'baseWageType' is unsupported as it's of type SearchEnumMultiSelectField, 
                   // which is not a SearchColumnField type. 
                    { "billAddress", r => r.@billAddress = new [] { new SearchColumnStringField { customLabel = "billAddress" } } },
                    { "billAddress1", r => r.@billAddress1 = new [] { new SearchColumnStringField { customLabel = "billAddress1" } } },
                    { "billAddress2", r => r.@billAddress2 = new [] { new SearchColumnStringField { customLabel = "billAddress2" } } },
                    { "billAddress3", r => r.@billAddress3 = new [] { new SearchColumnStringField { customLabel = "billAddress3" } } },
                    { "billAddressee", r => r.@billAddressee = new [] { new SearchColumnStringField { customLabel = "billAddressee" } } },
                    { "billAttention", r => r.@billAttention = new [] { new SearchColumnStringField { customLabel = "billAttention" } } },
                    { "billCity", r => r.@billCity = new [] { new SearchColumnStringField { customLabel = "billCity" } } },
                    { "billCountry", r => r.@billCountry = new [] { new SearchColumnEnumSelectField { customLabel = "billCountry" } } },
                    { "billCountryCode", r => r.@billCountryCode = new [] { new SearchColumnStringField { customLabel = "billCountryCode" } } },
                    { "billingClass", r => r.@billingClass = new [] { new SearchColumnSelectField { customLabel = "billingClass" } } },
                    { "billPhone", r => r.@billPhone = new [] { new SearchColumnStringField { customLabel = "billPhone" } } },
                    { "billState", r => r.@billState = new [] { new SearchColumnStringField { customLabel = "billState" } } },
                    { "billZipCode", r => r.@billZipCode = new [] { new SearchColumnStringField { customLabel = "billZipCode" } } },
                    { "birthDate", r => r.@birthDate = new [] { new SearchColumnDateField { customLabel = "birthDate" } } },
                    { "birthDay", r => r.@birthDay = new [] { new SearchColumnDateField { customLabel = "birthDay" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "class", r => r.@class = new [] { new SearchColumnSelectField { customLabel = "class" } } },
                    { "comments", r => r.@comments = new [] { new SearchColumnStringField { customLabel = "comments" } } },
                    { "compensationCurrency", r => r.@compensationCurrency = new [] { new SearchColumnEnumSelectField { customLabel = "compensationCurrency" } } },
                    { "concurrentWebServicesUser", r => r.@concurrentWebServicesUser = new [] { new SearchColumnBooleanField { customLabel = "concurrentWebServicesUser" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "defaultTaxReg", r => r.@defaultTaxReg = new [] { new SearchColumnStringField { customLabel = "defaultTaxReg" } } },
                    { "department", r => r.@department = new [] { new SearchColumnSelectField { customLabel = "department" } } },
                    { "eligibleForCommission", r => r.@eligibleForCommission = new [] { new SearchColumnBooleanField { customLabel = "eligibleForCommission" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "employeeStatus", r => r.@employeeStatus = new [] { new SearchColumnSelectField { customLabel = "employeeStatus" } } },
                    { "employeeType", r => r.@employeeType = new [] { new SearchColumnSelectField { customLabel = "employeeType" } } },
                    { "entityId", r => r.@entityId = new [] { new SearchColumnStringField { customLabel = "entityId" } } },
                    { "entityNumber", r => r.@entityNumber = new [] { new SearchColumnLongField { customLabel = "entityNumber" } } },
                    { "ethnicity", r => r.@ethnicity = new [] { new SearchColumnSelectField { customLabel = "ethnicity" } } },
                    { "expenseLimit", r => r.@expenseLimit = new [] { new SearchColumnDoubleField { customLabel = "expenseLimit" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "firstName", r => r.@firstName = new [] { new SearchColumnStringField { customLabel = "firstName" } } },
                    { "gender", r => r.@gender = new [] { new SearchColumnEnumSelectField { customLabel = "gender" } } },
                    { "giveAccess", r => r.@giveAccess = new [] { new SearchColumnBooleanField { customLabel = "giveAccess" } } },
                    { "globalSubscriptionStatus", r => r.@globalSubscriptionStatus = new [] { new SearchColumnEnumSelectField { customLabel = "globalSubscriptionStatus" } } },
                    { "hireDate", r => r.@hireDate = new [] { new SearchColumnDateField { customLabel = "hireDate" } } },
                    { "homePhone", r => r.@homePhone = new [] { new SearchColumnStringField { customLabel = "homePhone" } } },
                    { "i9Verified", r => r.@i9Verified = new [] { new SearchColumnBooleanField { customLabel = "i9Verified" } } },
                    { "image", r => r.@image = new [] { new SearchColumnSelectField { customLabel = "image" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isDefaultBilling", r => r.@isDefaultBilling = new [] { new SearchColumnBooleanField { customLabel = "isDefaultBilling" } } },
                    { "isDefaultShipping", r => r.@isDefaultShipping = new [] { new SearchColumnBooleanField { customLabel = "isDefaultShipping" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isJobResource", r => r.@isJobResource = new [] { new SearchColumnBooleanField { customLabel = "isJobResource" } } },
                    { "isSalesRep", r => r.@isSalesRep = new [] { new SearchColumnBooleanField { customLabel = "isSalesRep" } } },
                    { "isSupportRep", r => r.@isSupportRep = new [] { new SearchColumnBooleanField { customLabel = "isSupportRep" } } },
                    { "isTemplate", r => r.@isTemplate = new [] { new SearchColumnBooleanField { customLabel = "isTemplate" } } },
                    { "job", r => r.@job = new [] { new SearchColumnSelectField { customLabel = "job" } } },
                    { "laborCost", r => r.@laborCost = new [] { new SearchColumnDoubleField { customLabel = "laborCost" } } },
                    { "language", r => r.@language = new [] { new SearchColumnEnumSelectField { customLabel = "language" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "lastName", r => r.@lastName = new [] { new SearchColumnStringField { customLabel = "lastName" } } },
                    { "lastPaidDate", r => r.@lastPaidDate = new [] { new SearchColumnDateField { customLabel = "lastPaidDate" } } },
                    { "lastReviewDate", r => r.@lastReviewDate = new [] { new SearchColumnDateField { customLabel = "lastReviewDate" } } },
                    { "level", r => r.@level = new [] { new SearchColumnEnumSelectField { customLabel = "level" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "maritalStatus", r => r.@maritalStatus = new [] { new SearchColumnSelectField { customLabel = "maritalStatus" } } },
                    { "middleName", r => r.@middleName = new [] { new SearchColumnStringField { customLabel = "middleName" } } },
                    { "mobilePhone", r => r.@mobilePhone = new [] { new SearchColumnStringField { customLabel = "mobilePhone" } } },
                    { "nextReviewDate", r => r.@nextReviewDate = new [] { new SearchColumnDateField { customLabel = "nextReviewDate" } } },
                    { "offlineAccess", r => r.@offlineAccess = new [] { new SearchColumnBooleanField { customLabel = "offlineAccess" } } },
                    { "payFrequency", r => r.@payFrequency = new [] { new SearchColumnEnumSelectField { customLabel = "payFrequency" } } },
                    { "permChangeDate", r => r.@permChangeDate = new [] { new SearchColumnDateField { customLabel = "permChangeDate" } } },
                    { "permChangeLevel", r => r.@permChangeLevel = new [] { new SearchColumnStringField { customLabel = "permChangeLevel" } } },
                    { "permission", r => r.@permission = new [] { new SearchColumnEnumSelectField { customLabel = "permission" } } },
                    { "permissionChange", r => r.@permissionChange = new [] { new SearchColumnEnumSelectField { customLabel = "permissionChange" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "phoneticName", r => r.@phoneticName = new [] { new SearchColumnStringField { customLabel = "phoneticName" } } },
                    { "positionTitle", r => r.@positionTitle = new [] { new SearchColumnStringField { customLabel = "positionTitle" } } },
                    { "primaryEarningAmount", r => r.@primaryEarningAmount = new [] { new SearchColumnDoubleField { customLabel = "primaryEarningAmount" } } },
                    { "primaryEarningItem", r => r.@primaryEarningItem = new [] { new SearchColumnStringField { customLabel = "primaryEarningItem" } } },
                    { "primaryEarningType", r => r.@primaryEarningType = new [] { new SearchColumnStringField { customLabel = "primaryEarningType" } } },
                    { "purchaseOrderApprovalLimit", r => r.@purchaseOrderApprovalLimit = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderApprovalLimit" } } },
                    { "purchaseOrderApprover", r => r.@purchaseOrderApprover = new [] { new SearchColumnSelectField { customLabel = "purchaseOrderApprover" } } },
                    { "purchaseOrderLimit", r => r.@purchaseOrderLimit = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderLimit" } } },
                    { "releaseDate", r => r.@releaseDate = new [] { new SearchColumnDateField { customLabel = "releaseDate" } } },
                    { "residentStatus", r => r.@residentStatus = new [] { new SearchColumnSelectField { customLabel = "residentStatus" } } },
                    { "role", r => r.@role = new [] { new SearchColumnSelectField { customLabel = "role" } } },
                    { "roleChange", r => r.@roleChange = new [] { new SearchColumnStringField { customLabel = "roleChange" } } },
                    { "roleChangeAction", r => r.@roleChangeAction = new [] { new SearchColumnStringField { customLabel = "roleChangeAction" } } },
                    { "roleChangeDate", r => r.@roleChangeDate = new [] { new SearchColumnDateField { customLabel = "roleChangeDate" } } },
                    { "salesRole", r => r.@salesRole = new [] { new SearchColumnSelectField { customLabel = "salesRole" } } },
                    { "salutation", r => r.@salutation = new [] { new SearchColumnStringField { customLabel = "salutation" } } },
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
                    { "socialSecurityNumber", r => r.@socialSecurityNumber = new [] { new SearchColumnStringField { customLabel = "socialSecurityNumber" } } },
                    { "startDateTimeOffCalc", r => r.@startDateTimeOffCalc = new [] { new SearchColumnDateField { customLabel = "startDateTimeOffCalc" } } },
                    { "state", r => r.@state = new [] { new SearchColumnEnumSelectField { customLabel = "state" } } },
                    { "subscription", r => r.@subscription = new [] { new SearchColumnSelectField { customLabel = "subscription" } } },
                    { "subscriptionDate", r => r.@subscriptionDate = new [] { new SearchColumnDateField { customLabel = "subscriptionDate" } } },
                    { "subscriptionStatus", r => r.@subscriptionStatus = new [] { new SearchColumnBooleanField { customLabel = "subscriptionStatus" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "supervisor", r => r.@supervisor = new [] { new SearchColumnSelectField { customLabel = "supervisor" } } },
                    { "terminationCategory", r => r.@terminationCategory = new [] { new SearchColumnEnumSelectField { customLabel = "terminationCategory" } } },
                    { "terminationDetails", r => r.@terminationDetails = new [] { new SearchColumnStringField { customLabel = "terminationDetails" } } },
                    { "terminationReason", r => r.@terminationReason = new [] { new SearchColumnSelectField { customLabel = "terminationReason" } } },
                    { "terminationRegretted", r => r.@terminationRegretted = new [] { new SearchColumnEnumSelectField { customLabel = "terminationRegretted" } } },
                    { "timeApprover", r => r.@timeApprover = new [] { new SearchColumnSelectField { customLabel = "timeApprover" } } },
                    { "timeOffPlan", r => r.@timeOffPlan = new [] { new SearchColumnStringField { customLabel = "timeOffPlan" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "usePerquest", r => r.@usePerquest = new [] { new SearchColumnBooleanField { customLabel = "usePerquest" } } },
                    { "useTimeData", r => r.@useTimeData = new [] { new SearchColumnBooleanField { customLabel = "useTimeData" } } },
                    { "visaExpDate", r => r.@visaExpDate = new [] { new SearchColumnDateField { customLabel = "visaExpDate" } } },
                    { "visaType", r => r.@visaType = new [] { new SearchColumnSelectField { customLabel = "visaType" } } },
                    { "workCalendar", r => r.@workCalendar = new [] { new SearchColumnStringField { customLabel = "workCalendar" } } },
                    { "workplace", r => r.@workplace = new [] { new SearchColumnSelectField { customLabel = "workplace" } } },
                    { "zipCode", r => r.@zipCode = new [] { new SearchColumnStringField { customLabel = "zipCode" } } },
                };
            }
        }
    }
}