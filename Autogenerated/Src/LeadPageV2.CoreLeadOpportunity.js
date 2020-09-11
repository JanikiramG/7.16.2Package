define("LeadPageV2", ["terrasoft", "OpportunityConfigurationConstants", "LeadConfigurationConst", "BusinessRuleModule"],
		function(Terrasoft, OpportunityConfigurationConstants, LeadConfigurationConst, BusinessRuleModule) {
			return {
				entitySchemaName: "Lead",
				details: /**SCHEMA_DETAILS*/{
				}/**SCHEMA_DETAILS*/,
				attributes: {},
				messages: {
					"GetCurrentOpportunityInfo": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.PUBLISH
					}
				},
				methods: {

					/**
					 * Returns GUID of opportunity
					 * @returns {Terrasoft.DataValueType.GUID}
					 */
					getUidOpportunity: function() {

						var opportunity = this.get("Opportunity");
						return (opportunity) ? opportunity.value : null;
					},

					/**
					 * Returns the primary opportunity contact
					 * @returns {Terrasoft.EntitySchemaQuery}
					 */
					getOpportunityContactESQ: function() {
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "OpportunityContact"
						});
						select.addColumn("Id");
						select.addColumn("Contact");
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Opportunity", this.getUidOpportunity()));
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "IsMainContact", true));
						return select;
					},

					/**
					 * Returns the opportunity
					 * @returns {Terrasoft.EntitySchemaQuery}
					 */
					getOpportunityESQ: function() {
						var select = Ext.create("Terrasoft.EntitySchemaQuery", {
							rootSchemaName: "Opportunity"
						});
						select.addColumn("Id");
						select.addColumn("Budget");
						select.addColumn("Owner");
						select.addColumn("Stage");
						select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Id", this.getUidOpportunity()));
						return select;
					},

					/**
					 * Sets data from the opportunity
					 * @override
					 */
					onEntityInitialized: function() {
						this.callParent(arguments);
						if (this.isNewMode() && this.getUidOpportunity()) {
							this.getOpportunityContactESQ().getEntityCollection(function(response) {
								if (response.success) {
									if (response.collection.getCount() < 1) {
										return;
									}
									var mainContact = response.collection.getByIndex(0);
									this.set("QualifiedContact", mainContact.get("Contact"), Terrasoft.DataValueType.LOOKUP);
								}
							}, this);
							this.getOpportunityESQ().getEntityCollection(function(response) {
								if (response.success) {
									if (response.collection.getCount() < 1) {
										return;
									}
									var mainOpportunity = response.collection.getByIndex(0);
									this.set("Budget", mainOpportunity.get("Budget"), Terrasoft.DataValueType.MONEY);
									this.set("SalesOwner", mainOpportunity.get("Owner"), Terrasoft.DataValueType.LOOKUP);
								}
							}, this);
						}
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "move",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "SalesOwner",
						"values": {
							"layout": {
								"column": 0,
								"row": 2,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.LOOKUP,
							"bindTo": "SalesOwner"
						}
					},
					{
						"operation": "move",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "OpportunityDepartment",
						"values": {
							"layout": {
								"column": 0,
								"row": 3,
								"colSpan": 12
							},
							"contentType": Terrasoft.ContentType.ENUM,
							"enabled": {"bindTo": "SourceDataEditable"}
						}
					},
					{
						"operation": "insert",
						"parentName": "LeadPageDealInformationBlock",
						"propertyName": "items",
						"name": "Opportunity",
						"values": {
							"layout": {
								"column": 0,
								"row": 1,
								"colSpan": 12}
						}
					}
				]/**SCHEMA_DIFF*/,
				rules: {
					"Opportunity": {
						"FilterOpportunityrByAccount": {
							"ruleType": BusinessRuleModule.enums.RuleType.FILTRATION,
							"autocomplete": true,
							"baseAttributePatch": "Account",
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							"attribute": "QualifiedAccount"
						},
						"EnabledOpportunityForQualifyStatus": {
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
					}
				},
				userCode: {
				}
			};
		});
