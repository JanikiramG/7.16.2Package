define("AccountPageV2", [], function() {
	return {
		entitySchemaName: "Account",
		details: /**SCHEMA_DETAILS*/{
			Opportunities: {
				schemaName: "OpportunityDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Account"
				},
				useRelationship: true
			}
		}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "HistoryTabContainer",
				"propertyName": "items",
				"name": "Opportunities",
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
