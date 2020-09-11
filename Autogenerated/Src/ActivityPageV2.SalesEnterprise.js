define("ActivityPageV2", [],
	function() {
		return {
			entitySchemaName: "Activity",
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "Lead",
					"values": {
						"layout": { "column": 12, "row": 2, "colSpan": 12 }
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
