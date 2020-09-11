define("BaseLeadPage", ["BusinessRuleModule", "ConfigurationConstants", "PartnersOwnerMixin"],
	function(BusinessRuleModule, ConfigurationConstants) {
	return {
		entitySchemaName: "Lead",
		details: /**SCHEMA_DETAILS*/{
			Files: {
				schemaName: "FileDetailV2",
				entitySchemaName: "FileLead",
				filter: {
					detailColumn: "Lead"
				}
			},
			QualifyStatusInLead: {
				schemaName: "QualifyStatusInLeadDetailV2",
				filter: {
					masterColumn: "Id",
					detailColumn: "Lead"
				}
			}
		}/**SCHEMA_DETAILS*/,
		attributes: {
			"EmployeesNumber": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				lookupListConfig: {
					orders: [{columnPath: "Position"}]
				}
			},
			"Owner": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				lookupListConfig: {
					filter: function () {
						return this.getOwnerFilter("SalesChannel");
					}
				}
			}
		},
		mixins: {
			PartnersOwnerMixin: "Terrasoft.PartnersOwnerMixin"
		},
		methods: {},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "GeneralInfoTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0,
				"values": {
					"caption": {"bindTo": "Resources.Strings.GeneralInfoTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "DealSpecificsTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1,
				"values": {
					"caption": {"bindTo": "Resources.Strings.DealSpecificsTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "HistoryTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 2,
				"values": {
					"caption": {"bindTo": "Resources.Strings.HistoryTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageGeneralInfoTabContainer",
				"propertyName": "items",
				"name": "LeadPageGeneralTabContentGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"controlConfig": {"collapsed": false}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageGeneralTabContentGroup",
				"propertyName": "items",
				"name": "LeadPageGeneralBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "GeneralInfoTab",
				"name": "LeadPageGeneralInfoTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "DealSpecificsTab",
				"name": "DealSpecificsTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "DealSpecificsTabContainer",
				"propertyName": "items",
				"name": "LeadPageDealInformation",
				"values": {
					"caption": {bindTo: "Resources.Strings.DealInformationCaption"},
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": []
				},
				"index": 0
			},
			{
				"operation": "insert",
				"parentName": "LeadPageDealInformation",
				"propertyName": "items",
				"name": "LeadPageDealInformationBlock",
				"alias": {
					"name": "LeadPageTransferToSaleInfoBlock"
				},
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},

			{
				"operation": "insert",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"name": "Budget",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"name": "SalesOwner",
				"values": {
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 12
					},
					"contentType": Terrasoft.ContentType.LOOKUP,
					"bindTo": "SalesOwner"
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadPageDealInformationBlock",
				"propertyName": "items",
				"name": "NextActualizationDate",
				"values": {
					"layout": {
						"column": 12,
						"row": 0,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "HistoryTab",
				"propertyName": "items",
				"name": "QualifyStatusInLead",
				"index": 0,
				"values": {
					"itemType": Terrasoft.ViewItemType.DETAIL
				}
			},
			{
				"operation": "insert",
				"name": "NotesTab",
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 4,
				"values": {
					"caption": {"bindTo": "Resources.Strings.NotesTabCaption"},
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "NotesTab",
				"propertyName": "items",
				"name": "Files",
				"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
			},
			{
				"operation": "insert",
				"parentName": "NotesTab",
				"name": "LeadNotesTabContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadNotesTabContainer",
				"propertyName": "items",
				"name": "LeadNotesControlGroup",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
					"items": [],
					"caption": {"bindTo": "Resources.Strings.NotesGroupCaption"},
					"controlConfig": {"collapsed": false}
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadNotesTabContainer",
				"propertyName": "items",
				"name": "LeadNotesTabBlock",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"parentName": "LeadNotesControlGroup",
				"propertyName": "items",
				"name": "Notes",
				"values": {
					"contentType": Terrasoft.ContentType.RICH_TEXT,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {"visible": false},
					"controlConfig": {
						"imageLoaded": {"bindTo": "insertImagesToNotes"},
						"images": {"bindTo": "NotesImagesCollection"}
					}
				}
			}
		]/**SCHEMA_DIFF*/,
		rules: {
			"Contact": {
				"EnabledContact": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"Account": {
				"EnabledAccount": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"MobilePhone": {
				"EnabledMobilePhone": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"Email": {
				"EnabledEmail": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"EmployeesNumber": {
				"EnabledEmployeesNumber": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"Country": {
				"EnabledCountry": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			},
			"Website": {
				"EnabledWebsite": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Status"
						},
						comparisonType: Terrasoft.ComparisonType.EQUAL,
						rightExpression: {
							type: BusinessRuleModule.enums.ValueType.CONSTANT,
							value: ConfigurationConstants.Lead.Status.New
						}
					}]
				}
			}
		}
	};
});
