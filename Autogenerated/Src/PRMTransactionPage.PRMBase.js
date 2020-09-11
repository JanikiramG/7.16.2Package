define("PRMTransactionPage", ["BusinessRuleModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "PRMTransaction",
		attributes: {},
		methods: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "TransactionType",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 0},
					"enabled": {
						"bindTo": "isNewMode"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Fund",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"layout": {"column": 0, "row": 1},
					"enabled": {
						"bindTo": "isNewMode"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Amount",
				"values": {
					"layout": {"column": 0, "row": 2},
					"enabled": {
						"bindTo": "isNewMode"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "Header",
				"propertyName": "items",
				"name": "Description",
				"values": {
					"layout": {"column": 0, "row": 4, "rowSpan": 3},
					"contentType": Terrasoft.ContentType.LONG_TEXT
				}
			}
		],/**SCHEMA_DIFF*/
		rules: {
			"Fund": {
				"FilteringFundByPartnership": {
					ruleType: BusinessRuleModule.enums.RuleType.FILTRATION,
					baseAttributePatch: "Partnership.Id",
					comparisonType: Terrasoft.ComparisonType.EQUAL,
					type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
					attribute: "Partnership"
				}
			}
		}
	};
});
