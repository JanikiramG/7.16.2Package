define("GeneratedWebFormPageV2", ["GeneratedWebFormPageV2Resources", "Lead"],
		function() {
			return {
				details: /**SCHEMA_DETAILS*/{
					LeadDefaults: {
						schemaName: "LeadDefaultsDetailV2",
						entitySchemaName: "LandingLeadDefaults",
						filter: {
							masterColumn: "Id",
							detailColumn: "Landing"
						}
					}
				}/**SCHEMA_DETAILS*/,
				diff: /**SCHEMA_DIFF*/[
					{
						"name": "ObjectDefaults",
						"operation": "merge",
						"values": {
							"visible": false
						}
					},
					{
						"name": "LeadDefaults",
						"operation": "insert",
						"parentName": "DefaultsTab",
						"propertyName": "items",
						"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
					},
					{
						"name": "CreateContact",
						"operation": "insert",
						"parentName": "ProfileContainer",
						"propertyName": "items",
						"values": {
							"layout": {
								"column": 0,
								"row": 4,
								"colSpan": 8
							},
							"tips": []
						}
					},
					{
						"operation": "insert",
						"parentName": "CreateContact",
						"propertyName": "tips",
						"name": "CreateContactToolTip",
						"values": {
							"content": {"bindTo": "Resources.Strings.CreateContactToolTipText"},
							"style": Terrasoft.TipStyle.GREEN,
							"behaviour": {
								"displayEvent": Terrasoft.TipDisplayEvent.HOVER
							},
							"tools": []
						}
					},
					{
						"name": "EventTrackingSetupAcademyUrl",
						"operation": "insert",
						"parentName": "FaqContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"classes": {
								"textClass": ["faq-button", "base-edit-link"]
							},
							"click": {"bindTo": "onFaqClick"},
							"caption": {"bindTo": "Resources.Strings.EventTrackingSetupAcademyUrl"},
							"tag": {"data-context-help-code": "SiteEventTypeSection"},
							"layout": {
								"column": 4,
								"row": 6,
								"colSpan": 20
							}
						}
					},
					{
						"name": "LeadSourceTrackingAcademyUrl",
						"operation": "insert",
						"parentName": "FaqContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"classes": {
								"textClass": ["faq-button", "base-edit-link"]
							},
							"click": {"bindTo": "onFaqClick"},
							"caption": {"bindTo": "Resources.Strings.LeadSourceTrackingAcademyUrl"},
							"tag": {"data-context-help-code": "LeadSourceTracking"},
							"layout": {
								"column": 4,
								"row": 7,
								"colSpan": 20
							}
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});
