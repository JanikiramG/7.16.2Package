define("LeadPageV2", ["BusinessRuleModule", "LeadConfigurationConst"],
	function(BusinessRuleModule, LeadConfigurationConst) {
		return {
			entitySchemaName: "Lead",
			attributes: {
				"OpportunityOrOrder": {
					"caption": {"bindTo": "Resources.Strings.OpportunityOrOrderCaption"},
					"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
					"multiLookupColumns": ["Opportunity", "Order"]
				}
			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "Order"
				},
				{
					"operation": "remove",
					"name": "Opportunity"
				},
				{
					"operation": "merge",
					"name": "AnnualRevenue",
					"values": {
						"layout": {
							"column": 12,
							"row": 0,
							"colSpan": 12
						}
					}
				},
				{
					"operation": "merge",
					"name": "SalesOwner",
					"values": {
						"caption": {"bindTo": "Resources.Strings.DealOwnerCaption"}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "OpportunityOrOrder",
					"values": {
						"markerValue": {"bindTo": "Resources.Strings.OpportunityOrOrderCaption"},
						"caption": {"bindTo": "Resources.Strings.OpportunityOrOrderCaption"},
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 12
						},
						"contentType": Terrasoft.ContentType.LOOKUP,
						"bindTo": "OpportunityOrOrder"
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"OpportunityOrOrder": {
					"EnabledOpportunityOrOrderForQualifyStatus": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.ENABLED,
						"conditions": [{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "QualifyStatus"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": LeadConfigurationConst.LeadConst.QualifyStatus.TransferForSale
							}
						}, {
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "QualifyStatus"
							},
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": LeadConfigurationConst.LeadConst.QualifyStatus.WaitingForSale
							}
						}]
					}
				},
				"Opportunity": {
					"FilterOpportunityrByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "Account",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "QualifiedAccount"
					}
				},
				"Order": {
					"FilterOrderByAccount": {
						"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
						"autocomplete": true,
						"baseAttributePatch": "Account",
						"comparisonType": Terrasoft.ComparisonType.EQUAL,
						"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
						"attribute": "QualifiedAccount"
					}
				},
				"MeetingDate": {
					"VisibleMeetingDateByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				},
				"DecisionDate": {
					"VisibleDecisionDateDateByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				},
				"OpportunityDepartment": {
					"VisibleOpportunityDepartmentByOpportunityr": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.VISIBLE,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									"attribute": "Opportunity"
								},
								"comparisonType": Terrasoft.core.enums.ComparisonType.IS_NOT_NULL
							}
						]
					}
				}
			}
		};
	});
