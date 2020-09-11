define("BaseOpportunityPage", ["BusinessRuleModule"],
	function(BusinessRuleModule) {
		return {
			entitySchemaName: "Opportunity",
			messages: {
			},
			attributes: {
			},
			methods: {
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "OpportunityLeadType",
					"values": {
						"layout": {
							"column": 5,
							"row": 3,
							"colSpan": 19
						},
						"bindTo": "LeadType",
						"contentType": Terrasoft.ContentType.ENUM
					},
					"parentName": "BantProfile",
					"propertyName": "items",
					"index": 4,
					"alias": {
						"name": "LeadType",
						"excludeProperties": ["layout"],
						"excludeOperations": ["remove", "move"]
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"LeadType": {
					"LeadTypeRequired": {
						"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						"property": BusinessRuleModule.enums.Property.REQUIRED,
						"conditions": [
							{
								"leftExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								},
								"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
								"rightExpression": {
									"type": BusinessRuleModule.enums.ValueType.CONSTANT,
									"value": true
								}
							}
						]
					}
				}
			}
		};
	});
