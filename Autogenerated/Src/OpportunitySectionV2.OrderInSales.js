define("OpportunitySectionV2", ["OpportunityOrderUtilities"],
	function() {
		return {
			mixins: {
				/**
				 * Order utilities mixin.
				 */
				OpportunityOrderUtilities: "Terrasoft.OpportunityOrderUtilities"
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "CreateOrderFromOpportunityButton",
					"parentName": "CombinedModeActionButtonsCardLeftContainer",
					"propertyName": "items",
					"index": 5,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.GREEN,
						"caption": {"bindTo": "getButtonCaption"},
						"click": {"bindTo": "onCardAction"},
						"tag": "CreateOrderFromOpportunity",
						"enabled": {"bindTo": "canEntityBeOperated"},
						"classes": {
							"textClass": ["actions-button-margin-right"]
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
