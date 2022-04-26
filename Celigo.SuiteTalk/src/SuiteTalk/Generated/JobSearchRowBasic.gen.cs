
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class JobSearchRowBasic
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

        class ColumnFactory:  ColumnFactory<JobSearchRowBasic>
        {
            protected override Dictionary<string, Action<JobSearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<JobSearchRowBasic>> {
                    { "accountNumber", r => r.@accountNumber = new [] { new SearchColumnStringField { customLabel = "accountNumber" } } },
                    { "actualTime", r => r.@actualTime = new [] { new SearchColumnDoubleField { customLabel = "actualTime" } } },
                    { "address", r => r.@address = new [] { new SearchColumnStringField { customLabel = "address" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "addressee", r => r.@addressee = new [] { new SearchColumnStringField { customLabel = "addressee" } } },
                    { "addressInternalId", r => r.@addressInternalId = new [] { new SearchColumnStringField { customLabel = "addressInternalId" } } },
                    { "addressLabel", r => r.@addressLabel = new [] { new SearchColumnStringField { customLabel = "addressLabel" } } },
                    { "addressPhone", r => r.@addressPhone = new [] { new SearchColumnStringField { customLabel = "addressPhone" } } },
                    { "allocatePayrollExpenses", r => r.@allocatePayrollExpenses = new [] { new SearchColumnBooleanField { customLabel = "allocatePayrollExpenses" } } },
                    { "allowAllResourcesForTasks", r => r.@allowAllResourcesForTasks = new [] { new SearchColumnBooleanField { customLabel = "allowAllResourcesForTasks" } } },
                    { "allowExpenses", r => r.@allowExpenses = new [] { new SearchColumnBooleanField { customLabel = "allowExpenses" } } },
                    { "allowTime", r => r.@allowTime = new [] { new SearchColumnBooleanField { customLabel = "allowTime" } } },
                    { "altContact", r => r.@altContact = new [] { new SearchColumnStringField { customLabel = "altContact" } } },
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
                    { "billingRateCard", r => r.@billingRateCard = new [] { new SearchColumnSelectField { customLabel = "billingRateCard" } } },
                    { "billingSchedule", r => r.@billingSchedule = new [] { new SearchColumnSelectField { customLabel = "billingSchedule" } } },
                    { "billPhone", r => r.@billPhone = new [] { new SearchColumnStringField { customLabel = "billPhone" } } },
                    { "billState", r => r.@billState = new [] { new SearchColumnStringField { customLabel = "billState" } } },
                    { "billZipCode", r => r.@billZipCode = new [] { new SearchColumnStringField { customLabel = "billZipCode" } } },
                    { "calculatedEndDate", r => r.@calculatedEndDate = new [] { new SearchColumnDateField { customLabel = "calculatedEndDate" } } },
                    { "calculatedEndDateBaseline", r => r.@calculatedEndDateBaseline = new [] { new SearchColumnDateField { customLabel = "calculatedEndDateBaseline" } } },
                    { "calculatedStartDate", r => r.@calculatedStartDate = new [] { new SearchColumnDateField { customLabel = "calculatedStartDate" } } },
                    { "category", r => r.@category = new [] { new SearchColumnSelectField { customLabel = "category" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "comments", r => r.@comments = new [] { new SearchColumnStringField { customLabel = "comments" } } },
                    { "companyName", r => r.@companyName = new [] { new SearchColumnStringField { customLabel = "companyName" } } },
                    { "contact", r => r.@contact = new [] { new SearchColumnStringField { customLabel = "contact" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "countryCode", r => r.@countryCode = new [] { new SearchColumnStringField { customLabel = "countryCode" } } },
                    { "customer", r => r.@customer = new [] { new SearchColumnSelectField { customLabel = "customer" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "defaultTaxReg", r => r.@defaultTaxReg = new [] { new SearchColumnStringField { customLabel = "defaultTaxReg" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "endDate", r => r.@endDate = new [] { new SearchColumnDateField { customLabel = "endDate" } } },
                    { "entityId", r => r.@entityId = new [] { new SearchColumnStringField { customLabel = "entityId" } } },
                    { "entityNumber", r => r.@entityNumber = new [] { new SearchColumnLongField { customLabel = "entityNumber" } } },
                    { "entityStatus", r => r.@entityStatus = new [] { new SearchColumnSelectField { customLabel = "entityStatus" } } },
                    { "estimatedCost", r => r.@estimatedCost = new [] { new SearchColumnDoubleField { customLabel = "estimatedCost" } } },
                    { "estimatedGrossProfit", r => r.@estimatedGrossProfit = new [] { new SearchColumnDoubleField { customLabel = "estimatedGrossProfit" } } },
                    { "estimatedGrossProfitPercent", r => r.@estimatedGrossProfitPercent = new [] { new SearchColumnDoubleField { customLabel = "estimatedGrossProfitPercent" } } },
                    { "estimatedLaborCost", r => r.@estimatedLaborCost = new [] { new SearchColumnDoubleField { customLabel = "estimatedLaborCost" } } },
                    { "estimatedLaborCostBaseline", r => r.@estimatedLaborCostBaseline = new [] { new SearchColumnDoubleField { customLabel = "estimatedLaborCostBaseline" } } },
                    { "estimatedLaborRevenue", r => r.@estimatedLaborRevenue = new [] { new SearchColumnDoubleField { customLabel = "estimatedLaborRevenue" } } },
                    { "estimatedRevenue", r => r.@estimatedRevenue = new [] { new SearchColumnDoubleField { customLabel = "estimatedRevenue" } } },
                    { "estimatedTime", r => r.@estimatedTime = new [] { new SearchColumnDoubleField { customLabel = "estimatedTime" } } },
                    { "estimatedTimeOverride", r => r.@estimatedTimeOverride = new [] { new SearchColumnDoubleField { customLabel = "estimatedTimeOverride" } } },
                    { "estimatedTimeOverrideBaseline", r => r.@estimatedTimeOverrideBaseline = new [] { new SearchColumnDoubleField { customLabel = "estimatedTimeOverrideBaseline" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "globalSubscriptionStatus", r => r.@globalSubscriptionStatus = new [] { new SearchColumnEnumSelectField { customLabel = "globalSubscriptionStatus" } } },
                    { "image", r => r.@image = new [] { new SearchColumnSelectField { customLabel = "image" } } },
                    { "includeCrmTasksInTotals", r => r.@includeCrmTasksInTotals = new [] { new SearchColumnBooleanField { customLabel = "includeCrmTasksInTotals" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isDefaultBilling", r => r.@isDefaultBilling = new [] { new SearchColumnBooleanField { customLabel = "isDefaultBilling" } } },
                    { "isDefaultShipping", r => r.@isDefaultShipping = new [] { new SearchColumnBooleanField { customLabel = "isDefaultShipping" } } },
                    { "isExemptTime", r => r.@isExemptTime = new [] { new SearchColumnBooleanField { customLabel = "isExemptTime" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "isProductiveTime", r => r.@isProductiveTime = new [] { new SearchColumnBooleanField { customLabel = "isProductiveTime" } } },
                    { "isUtilizedTime", r => r.@isUtilizedTime = new [] { new SearchColumnBooleanField { customLabel = "isUtilizedTime" } } },
                    { "jobBillingType", r => r.@jobBillingType = new [] { new SearchColumnEnumSelectField { customLabel = "jobBillingType" } } },
                    { "jobItem", r => r.@jobItem = new [] { new SearchColumnSelectField { customLabel = "jobItem" } } },
                    { "jobPrice", r => r.@jobPrice = new [] { new SearchColumnDoubleField { customLabel = "jobPrice" } } },
                    { "jobResource", r => r.@jobResource = new [] { new SearchColumnSelectField { customLabel = "jobResource" } } },
                    { "jobResourceRole", r => r.@jobResourceRole = new [] { new SearchColumnSelectField { customLabel = "jobResourceRole" } } },
                    { "language", r => r.@language = new [] { new SearchColumnEnumSelectField { customLabel = "language" } } },
                    { "lastBaselineDate", r => r.@lastBaselineDate = new [] { new SearchColumnDateField { customLabel = "lastBaselineDate" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "level", r => r.@level = new [] { new SearchColumnEnumSelectField { customLabel = "level" } } },
                    { "limitTimeToAssignees", r => r.@limitTimeToAssignees = new [] { new SearchColumnBooleanField { customLabel = "limitTimeToAssignees" } } },
                    { "materializeTime", r => r.@materializeTime = new [] { new SearchColumnBooleanField { customLabel = "materializeTime" } } },
                    { "percentComplete", r => r.@percentComplete = new [] { new SearchColumnDoubleField { customLabel = "percentComplete" } } },
                    { "percentTimeComplete", r => r.@percentTimeComplete = new [] { new SearchColumnDoubleField { customLabel = "percentTimeComplete" } } },
                    { "permission", r => r.@permission = new [] { new SearchColumnEnumSelectField { customLabel = "permission" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "phoneticName", r => r.@phoneticName = new [] { new SearchColumnStringField { customLabel = "phoneticName" } } },
                    { "plannedWork", r => r.@plannedWork = new [] { new SearchColumnDoubleField { customLabel = "plannedWork" } } },
                    { "plannedWorkBaseline", r => r.@plannedWorkBaseline = new [] { new SearchColumnDoubleField { customLabel = "plannedWorkBaseline" } } },
                    { "projectedEndDate", r => r.@projectedEndDate = new [] { new SearchColumnDateField { customLabel = "projectedEndDate" } } },
                    { "projectedEndDateBaseline", r => r.@projectedEndDateBaseline = new [] { new SearchColumnDateField { customLabel = "projectedEndDateBaseline" } } },
                    { "projectExpenseType", r => r.@projectExpenseType = new [] { new SearchColumnSelectField { customLabel = "projectExpenseType" } } },
                    { "projectManager", r => r.@projectManager = new [] { new SearchColumnSelectField { customLabel = "projectManager" } } },
                    { "revRecForecastRule", r => r.@revRecForecastRule = new [] { new SearchColumnSelectField { customLabel = "revRecForecastRule" } } },
                    { "scheduledEndDate", r => r.@scheduledEndDate = new [] { new SearchColumnDateField { customLabel = "scheduledEndDate" } } },
                    { "schedulingMethod", r => r.@schedulingMethod = new [] { new SearchColumnEnumSelectField { customLabel = "schedulingMethod" } } },
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
                    { "sourceServiceItemFromRateCard", r => r.@sourceServiceItemFromRateCard = new [] { new SearchColumnBooleanField { customLabel = "sourceServiceItemFromRateCard" } } },
                    { "startDate", r => r.@startDate = new [] { new SearchColumnDateField { customLabel = "startDate" } } },
                    { "startDateBaseline", r => r.@startDateBaseline = new [] { new SearchColumnDateField { customLabel = "startDateBaseline" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "subscription", r => r.@subscription = new [] { new SearchColumnSelectField { customLabel = "subscription" } } },
                    { "subscriptionDate", r => r.@subscriptionDate = new [] { new SearchColumnDateField { customLabel = "subscriptionDate" } } },
                    { "subscriptionStatus", r => r.@subscriptionStatus = new [] { new SearchColumnBooleanField { customLabel = "subscriptionStatus" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "timeApproval", r => r.@timeApproval = new [] { new SearchColumnSelectField { customLabel = "timeApproval" } } },
                    { "timeRemaining", r => r.@timeRemaining = new [] { new SearchColumnDoubleField { customLabel = "timeRemaining" } } },
                    { "usePercentCompleteOverride", r => r.@usePercentCompleteOverride = new [] { new SearchColumnBooleanField { customLabel = "usePercentCompleteOverride" } } },
                    { "zipCode", r => r.@zipCode = new [] { new SearchColumnStringField { customLabel = "zipCode" } } },
                };
            }
        }
    }
}