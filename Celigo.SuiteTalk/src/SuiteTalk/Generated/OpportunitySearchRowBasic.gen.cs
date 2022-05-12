
//~ Generated by SearchStubs/SearchRowBasic

using System;
using System.Collections.Generic;

namespace SuiteTalk
{
    partial class OpportunitySearchRowBasic
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

        class ColumnFactory:  ColumnFactory<OpportunitySearchRowBasic>
        {
            protected override Dictionary<string, Action<OpportunitySearchRowBasic>> InitializeColumnBuilders()
            {
                return new Dictionary<string, Action<OpportunitySearchRowBasic>> {
                    { "actionItem", r => r.@actionItem = new [] { new SearchColumnStringField { customLabel = "actionItem" } } },
                    { "availableOffline", r => r.@availableOffline = new [] { new SearchColumnBooleanField { customLabel = "availableOffline" } } },
                    { "buyingReason", r => r.@buyingReason = new [] { new SearchColumnStringField { customLabel = "buyingReason" } } },
                    { "buyingTimeFrame", r => r.@buyingTimeFrame = new [] { new SearchColumnStringField { customLabel = "buyingTimeFrame" } } },
                    { "class", r => r.@class = new [] { new SearchColumnSelectField { customLabel = "class" } } },
                    { "closeDate", r => r.@closeDate = new [] { new SearchColumnDateField { customLabel = "closeDate" } } },
                    { "competitor", r => r.@competitor = new [] { new SearchColumnSelectField { customLabel = "competitor" } } },
                    { "contribution", r => r.@contribution = new [] { new SearchColumnDoubleField { customLabel = "contribution" } } },
                    { "contributionPrimary", r => r.@contributionPrimary = new [] { new SearchColumnDoubleField { customLabel = "contributionPrimary" } } },
                    { "currency", r => r.@currency = new [] { new SearchColumnSelectField { customLabel = "currency" } } },
                    { "custType", r => r.@custType = new [] { new SearchColumnStringField { customLabel = "custType" } } },
                    { "dateCreated", r => r.@dateCreated = new [] { new SearchColumnDateField { customLabel = "dateCreated" } } },
                    { "daysOpen", r => r.@daysOpen = new [] { new SearchColumnLongField { customLabel = "daysOpen" } } },
                    { "daysToClose", r => r.@daysToClose = new [] { new SearchColumnLongField { customLabel = "daysToClose" } } },
                    { "decisionMaker", r => r.@decisionMaker = new [] { new SearchColumnSelectField { customLabel = "decisionMaker" } } },
                    { "department", r => r.@department = new [] { new SearchColumnSelectField { customLabel = "department" } } },
                    { "entity", r => r.@entity = new [] { new SearchColumnSelectField { customLabel = "entity" } } },
                    { "entityStatus", r => r.@entityStatus = new [] { new SearchColumnSelectField { customLabel = "entityStatus" } } },
                    { "estimatedBudget", r => r.@estimatedBudget = new [] { new SearchColumnDoubleField { customLabel = "estimatedBudget" } } },
                    { "expectedCloseDate", r => r.@expectedCloseDate = new [] { new SearchColumnDateField { customLabel = "expectedCloseDate" } } },
                    { "externalId", r => r.@externalId = new [] { new SearchColumnSelectField { customLabel = "externalId" } } },
                    { "forecastType", r => r.@forecastType = new [] { new SearchColumnEnumSelectField { customLabel = "forecastType" } } },
                    { "foreignProjectedAmount", r => r.@foreignProjectedAmount = new [] { new SearchColumnDoubleField { customLabel = "foreignProjectedAmount" } } },
                    { "foreignRangeHigh", r => r.@foreignRangeHigh = new [] { new SearchColumnDoubleField { customLabel = "foreignRangeHigh" } } },
                    { "foreignRangeLow", r => r.@foreignRangeLow = new [] { new SearchColumnDoubleField { customLabel = "foreignRangeLow" } } },
                    { "fxTranCostEstimate", r => r.@fxTranCostEstimate = new [] { new SearchColumnDoubleField { customLabel = "fxTranCostEstimate" } } },
                    { "internalId", r => r.@internalId = new [] { new SearchColumnSelectField { customLabel = "internalId" } } },
                    { "isBudgetApproved", r => r.@isBudgetApproved = new [] { new SearchColumnBooleanField { customLabel = "isBudgetApproved" } } },
                    { "lastModifiedDate", r => r.@lastModifiedDate = new [] { new SearchColumnDateField { customLabel = "lastModifiedDate" } } },
                    { "leadSource", r => r.@leadSource = new [] { new SearchColumnSelectField { customLabel = "leadSource" } } },
                    { "location", r => r.@location = new [] { new SearchColumnSelectField { customLabel = "location" } } },
                    { "memo", r => r.@memo = new [] { new SearchColumnStringField { customLabel = "memo" } } },
                    { "partner", r => r.@partner = new [] { new SearchColumnSelectField { customLabel = "partner" } } },
                    { "partnerContribution", r => r.@partnerContribution = new [] { new SearchColumnDoubleField { customLabel = "partnerContribution" } } },
                    { "partnerRole", r => r.@partnerRole = new [] { new SearchColumnSelectField { customLabel = "partnerRole" } } },
                    { "partnerTeamMember", r => r.@partnerTeamMember = new [] { new SearchColumnSelectField { customLabel = "partnerTeamMember" } } },
                    { "period", r => r.@period = new [] { new SearchColumnStringField { customLabel = "period" } } },
                    { "probability", r => r.@probability = new [] { new SearchColumnDoubleField { customLabel = "probability" } } },
                    { "projAltSalesAmt", r => r.@projAltSalesAmt = new [] { new SearchColumnDoubleField { customLabel = "projAltSalesAmt" } } },
                    { "projectedTotal", r => r.@projectedTotal = new [] { new SearchColumnDoubleField { customLabel = "projectedTotal" } } },
                    { "rangeHigh", r => r.@rangeHigh = new [] { new SearchColumnDoubleField { customLabel = "rangeHigh" } } },
                    { "rangeHighAlt", r => r.@rangeHighAlt = new [] { new SearchColumnDoubleField { customLabel = "rangeHighAlt" } } },
                    { "rangeLow", r => r.@rangeLow = new [] { new SearchColumnDoubleField { customLabel = "rangeLow" } } },
                    { "rangeLowAlt", r => r.@rangeLowAlt = new [] { new SearchColumnDoubleField { customLabel = "rangeLowAlt" } } },
                    { "salesReadiness", r => r.@salesReadiness = new [] { new SearchColumnStringField { customLabel = "salesReadiness" } } },
                    { "salesRep", r => r.@salesRep = new [] { new SearchColumnSelectField { customLabel = "salesRep" } } },
                    { "salesTeamMember", r => r.@salesTeamMember = new [] { new SearchColumnSelectField { customLabel = "salesTeamMember" } } },
                    { "salesTeamRole", r => r.@salesTeamRole = new [] { new SearchColumnSelectField { customLabel = "salesTeamRole" } } },
                    { "status", r => r.@status = new [] { new SearchColumnEnumSelectField { customLabel = "status" } } },
                    { "subsidiary", r => r.@subsidiary = new [] { new SearchColumnSelectField { customLabel = "subsidiary" } } },
                    { "taxPeriod", r => r.@taxPeriod = new [] { new SearchColumnSelectField { customLabel = "taxPeriod" } } },
                    { "title", r => r.@title = new [] { new SearchColumnStringField { customLabel = "title" } } },
                    { "total", r => r.@total = new [] { new SearchColumnDoubleField { customLabel = "total" } } },
                    { "tranCostEstimate", r => r.@tranCostEstimate = new [] { new SearchColumnDoubleField { customLabel = "tranCostEstimate" } } },
                    { "tranDate", r => r.@tranDate = new [] { new SearchColumnDateField { customLabel = "tranDate" } } },
                    { "tranEstGrossProfit", r => r.@tranEstGrossProfit = new [] { new SearchColumnDoubleField { customLabel = "tranEstGrossProfit" } } },
                    { "tranEstGrossProfitPct", r => r.@tranEstGrossProfitPct = new [] { new SearchColumnDoubleField { customLabel = "tranEstGrossProfitPct" } } },
                    { "tranFxEstGrossProfit", r => r.@tranFxEstGrossProfit = new [] { new SearchColumnDoubleField { customLabel = "tranFxEstGrossProfit" } } },
                    { "tranId", r => r.@tranId = new [] { new SearchColumnStringField { customLabel = "tranId" } } },
                    { "weightedTotal", r => r.@weightedTotal = new [] { new SearchColumnDoubleField { customLabel = "weightedTotal" } } },
                    { "winLossReason", r => r.@winLossReason = new [] { new SearchColumnSelectField { customLabel = "winLossReason" } } },
                    { "wonBy", r => r.@wonBy = new [] { new SearchColumnSelectField { customLabel = "wonBy" } } },
                };
            }
        }
    }
}