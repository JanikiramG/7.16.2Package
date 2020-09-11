  define("PortalOpportunityPageV2", ["ConfigurationConstants"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "Opportunity",
			details: /**SCHEMA_DETAILS*/ {
				Lead: {
					schemaName: "LeadDetailV2",
					entitySchemaName: "Lead",
					filter: {
						detailColumn: "Opportunity",
						masterColumn: "Id"
					},
					defaultValues: {
						QualifiedAccount: {
							masterColumn: "Account"
						},
						Budget: {
							masterColumn: "Budget"
						},
						SalesOwner: {
							masterColumn: "Owner"
						},
						LeadType: {
							masterColumn: "LeadType"
						}
					}
				}
			} /**SCHEMA_DETAILS*/,
			modules: /**SCHEMA_MODULES*/{
				"ClientProfile": {
					"config": {
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"schemaName": "PortalClientProfileSchema",
						"parameters": {
							"viewModelConfig": {
								"masterColumnName": "Client"
							}
						}
					}
				}
			}/**SCHEMA_MODULES*/,
			methods: {
				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this._initializePartnerSale();
					this._initializePartner();
				},

				/**
				 * @private
				 */
				_initializePartnerSale: function () {
					if (this.isEmpty(this.$Type)) {
						this.$Type = {
							value: ConfigurationConstants.Opportunity.Type.PartnerSale
						};
					}
				},

				/**
				 * @private
				 */
				_initializePartner: function () {
					if (this.isEmpty(this.$Owner)) {
						this.$Owner = this.Terrasoft.SysValue.CURRENT_USER_CONTACT;
					}
					if (this.isEmpty(this.$Partner) &&
						!this.Terrasoft.isEmptyGUID(this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT.value)) {
							this.$Partner = this.Terrasoft.SysValue.CURRENT_USER_ACCOUNT;
					}
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#getLookupPageConfig
				 * @override
				 */
				getLookupPageConfig: function () {
					const parentConfig = this.callParent(arguments);
					parentConfig.hideActions = true;
					return parentConfig;
				}
			},
			diff: /**SCHEMA_DIFF*/ [
				{
					"operation": "insert",
					"name": "LeadTab",
					"values": {
						"items": [],
						"caption": {
							"bindTo": "Resources.Strings.LeadTabCaption"
						}
					},
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1
				},
				{
					"operation": "insert",
					"name": "Lead",
					"values": {
						"itemType": 2
					},
					"parentName": "LeadTab",
					"propertyName": "items",
					"index": 0
				},
				{
					"operation": "remove",
					"name": "Partner"
				}
			]/**SCHEMA_DIFF*/
		};
	});
