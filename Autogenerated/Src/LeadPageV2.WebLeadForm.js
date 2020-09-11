define("LeadPageV2", function() {
	return {
		entitySchemaName: "Lead",
		details: /**SCHEMA_DETAILS*/{
		}/**SCHEMA_DETAILS*/,
		methods: {
			/**
			 * Logic to collapse Unconfirmed data group.
			 * @return {Boolean}
			 */
			getWebFormUnconfirmedDataGroupCollapsed: function() {
				return !this.get("isCheckedEnabled");
			},

			/**
			 * Logic to set visible unconfirmed data group.
			 * @return {Boolean}
			 */
			getWebFormUnconfirmedDataGroupVisible: function() {
				if (this.getWebFormFilledIn()) {
					return false;
				}
				var isAddressUnresolved = !this.Ext.isEmpty(this.get("CountryStr")) && this.Ext.isEmpty(this.get("Country"));
				isAddressUnresolved = isAddressUnresolved || (!this.Ext.isEmpty(this.get("RegionStr")) &&
						this.Ext.isEmpty(this.get("Region")));
				isAddressUnresolved = isAddressUnresolved || (!this.Ext.isEmpty(this.get("CityStr")) &&
						this.Ext.isEmpty(this.get("City")));
				return isAddressUnresolved;
			},

			getWebFormFilledIn: function() {
				return !this.Ext.isEmpty(this.get("WebForm"));
			},
			/**
			 * Toll tip click handler for group "ContactCommunications".
			 * @protected
			 */
			showLeadPageNeedValidationInfoToolTip: function() {
				this.showInformationDialog(this.get("Resources.Strings.LeadPageNeedValidationInfo"));
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"parentName": "LeadPageGeneralInfoTabContainer",
				"propertyName": "items",
				"name": "LeadPageNeedValidationGroup",
				"values": {
					"caption": {"bindTo": "Resources.Strings.LeadPageNeedValidationBlockCaption"},
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"tools": [],
					"controlConfig": {
						"collapsed": {"bindTo": "getWebFormUnconfirmedDataGroupCollapsed"}
					},
					"visible": {"bindTo": "getWebFormUnconfirmedDataGroupVisible"}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationGroup",
				"propertyName": "items",
				"name": "LeadPageNeedValidationBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"name": "LeadWebFormInProfile",
				"values": {
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					},
					"contentType": Terrasoft.ContentType.LOOKUP,
					"enabled": false,
					"visible": {"bindTo": "getWebFormFilledIn"},
					"bindTo": "WebForm"
				},
				"alias": {
					"name": "WebFormInProfile",
					"excludeProperties": ["layout"],
					"excludeOperations": ["remove", "move"]
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "WebForm",
				"values": {
					"layout": {
						"column": 12,
						"row": 1,
						"colSpan": 12
					},
					"contentType": Terrasoft.ContentType.LOOKUP,
					"enabled": false,
					"bindTo": "WebForm"
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationGroup",
				"propertyName": "tools",
				"name": "LeadPageNeedValidationInfoToolTip",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					"imageConfig": {"bindTo": "Resources.Images.InfoSpriteImage"},
					"classes": {
						"wrapperClass": "info-button-lead-group",
						"imageClass": "info-button-lead-group-image"
					},
					"showTooltip": false,
					"click": {"bindTo": "showLeadPageNeedValidationInfoToolTip"}
				},
				"index": 1
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "CountryStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.CountryStrCaption"},
					"caption": {"bindTo": "Resources.Strings.CountryStrCaption"},
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "RegionStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.RegionStrCaption"},
					"caption": {"bindTo": "Resources.Strings.RegionStrCaption"},
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageNeedValidationBlock",
				"propertyName": "items",
				"name": "CityStr",
				"values": {
					"markerValue": {"bindTo": "Resources.Strings.CityStrCaption"},
					"caption": {"bindTo": "Resources.Strings.CityStrCaption"},
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageSourceInfoBlock",
				"propertyName": "items",
				"name": "BpmRef",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					},
					"enabled": false
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
