define("ActivityMiniPage", ["BusinessRuleModule", "ActivityBusinessRulesMixin"], function() {
	return {
		entitySchemaName: "Activity",
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		attributes: {
			/**
			 * Activity entity opportunity column.
			 * @type {Object}
			 */
			"Opportunity": {
				"lookupListConfig": {
					"filter": function() {
						return this.getOpportunityFilters();
					},
					"columns": ["Account", "Contact"]
				},
				"dependencies": [
					{
						"columns": ["Opportunity"],
						"methodName": "setContactAndAccountByOpportunity"
					}
				]
			}
		},
		mixins: {
			/**
			 * @class ActivityBusinessRulesMixin
			 * Activity business rules mixin.
			 */
			ActivityBusinessRulesMixin: "Terrasoft.ActivityBusinessRulesMixin"
		}
	};
});
