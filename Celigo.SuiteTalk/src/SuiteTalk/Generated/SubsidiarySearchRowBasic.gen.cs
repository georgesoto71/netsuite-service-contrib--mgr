
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class SubsidiarySearchRowBasic
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

        class ColumnFactory:  ColumnFactory<SubsidiarySearchRowBasic>
        {
            protected override Dictionary<string, Action<SubsidiarySearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<SubsidiarySearchRowBasic>> {
                    { "accountingBook", r => r.@accountingBook = new [] { new SearchColumnSelectField { customLabel = "accountingBook" } } },
                    { "accountingBookCurrency", r => r.@accountingBookCurrency = new [] { new SearchColumnSelectField { customLabel = "accountingBookCurrency" } } },
                    { "address1", r => r.@address1 = new [] { new SearchColumnStringField { customLabel = "address1" } } },
                    { "address2", r => r.@address2 = new [] { new SearchColumnStringField { customLabel = "address2" } } },
                    { "address3", r => r.@address3 = new [] { new SearchColumnStringField { customLabel = "address3" } } },
                    { "anonymousCustomerInboundEmail", r => r.@anonymousCustomerInboundEmail = new [] { new SearchColumnStringField { customLabel = "anonymousCustomerInboundEmail" } } },
                    { "anonymousCustomerOnlineForms", r => r.@anonymousCustomerOnlineForms = new [] { new SearchColumnStringField { customLabel = "anonymousCustomerOnlineForms" } } },
                    { "caseAssignmentTemplate", r => r.@caseAssignmentTemplate = new [] { new SearchColumnStringField { customLabel = "caseAssignmentTemplate" } } },
                    { "caseAutomaticClosureTemplate", r => r.@caseAutomaticClosureTemplate = new [] { new SearchColumnStringField { customLabel = "caseAutomaticClosureTemplate" } } },
                    { "caseCopyEmployeeTemplate", r => r.@caseCopyEmployeeTemplate = new [] { new SearchColumnStringField { customLabel = "caseCopyEmployeeTemplate" } } },
                    { "caseCreationTemplate", r => r.@caseCreationTemplate = new [] { new SearchColumnStringField { customLabel = "caseCreationTemplate" } } },
                    { "caseEscalationTemplate", r => r.@caseEscalationTemplate = new [] { new SearchColumnStringField { customLabel = "caseEscalationTemplate" } } },
                    { "caseUpdateTemplate", r => r.@caseUpdateTemplate = new [] { new SearchColumnStringField { customLabel = "caseUpdateTemplate" } } },
                    { "city", r => r.@city = new [] { new SearchColumnStringField { customLabel = "city" } } },
                    { "companyNameForSupportMessages", r => r.@companyNameForSupportMessages = new [] { new SearchColumnStringField { customLabel = "companyNameForSupportMessages" } } },
                    { "country", r => r.@country = new [] { new SearchColumnEnumSelectField { customLabel = "country" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "effectiveFrom", r => r.@effectiveFrom = new [] { new SearchColumnDateField { customLabel = "effectiveFrom" } } },
                    { "email", r => r.@email = new [] { new SearchColumnStringField { customLabel = "email" } } },
                    { "employeeCaseUpdateTemplate", r => r.@employeeCaseUpdateTemplate = new [] { new SearchColumnStringField { customLabel = "employeeCaseUpdateTemplate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "fax", r => r.@fax = new [] { new SearchColumnStringField { customLabel = "fax" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isElimination", r => r.@isElimination = new [] { new SearchColumnBooleanField { customLabel = "isElimination" } } },
                    { "isInactive", r => r.@isInactive = new [] { new SearchColumnBooleanField { customLabel = "isInactive" } } },
                    { "legalName", r => r.@legalName = new [] { new SearchColumnStringField { customLabel = "legalName" } } },
                    { "mainSupportEmailAddress", r => r.@mainSupportEmailAddress = new [] { new SearchColumnStringField { customLabel = "mainSupportEmailAddress" } } },
                    { "name", r => r.@name = new [] { new SearchColumnStringField { customLabel = "name" } } },
                    { "nameNoHierarchy", r => r.@nameNoHierarchy = new [] { new SearchColumnStringField { customLabel = "nameNoHierarchy" } } },
                    { "nexus", r => r.@nexus = new [] { new SearchColumnSelectField { customLabel = "nexus" } } },
                    { "phone", r => r.@phone = new [] { new SearchColumnStringField { customLabel = "phone" } } },
                    { "purchaseOrderAmount", r => r.@purchaseOrderAmount = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderAmount" } } },
                    { "purchaseOrderQuantity", r => r.@purchaseOrderQuantity = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderQuantity" } } },
                    { "purchaseOrderQuantityDiff", r => r.@purchaseOrderQuantityDiff = new [] { new SearchColumnDoubleField { customLabel = "purchaseOrderQuantityDiff" } } },
                    { "receiptAmount", r => r.@receiptAmount = new [] { new SearchColumnDoubleField { customLabel = "receiptAmount" } } },
                    { "receiptQuantity", r => r.@receiptQuantity = new [] { new SearchColumnDoubleField { customLabel = "receiptQuantity" } } },
                    { "receiptQuantityDiff", r => r.@receiptQuantityDiff = new [] { new SearchColumnDoubleField { customLabel = "receiptQuantityDiff" } } },
                    { "state", r => r.@state = new [] { new SearchColumnStringField { customLabel = "state" } } },
                    { "taxEngine", r => r.@taxEngine = new [] { new SearchColumnSelectField { customLabel = "taxEngine" } } },
                    { "taxIdNum", r => r.@taxIdNum = new [] { new SearchColumnStringField { customLabel = "taxIdNum" } } },
                    { "taxRegistrationNumber", r => r.@taxRegistrationNumber = new [] { new SearchColumnStringField { customLabel = "taxRegistrationNumber" } } },
                    { "tranPrefix", r => r.@tranPrefix = new [] { new SearchColumnStringField { customLabel = "tranPrefix" } } },
                    { "url", r => r.@url = new [] { new SearchColumnStringField { customLabel = "url" } } },
                    { "validUntil", r => r.@validUntil = new [] { new SearchColumnDateField { customLabel = "validUntil" } } },
                    { "zip", r => r.@zip = new [] { new SearchColumnStringField { customLabel = "zip" } } },
                };
            }
        }
    }
}