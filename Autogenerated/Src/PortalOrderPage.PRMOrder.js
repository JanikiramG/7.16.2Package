define("PortalOrderPage", ["ConfigurationEnums"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "Order",
			methods: {

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function () {
					this.callParent(arguments);
					this.setOrderCustomer();
				},

				/**
				 * Sets customer of the order.
				 * @protected
				 * @virtual
				 */
				setOrderCustomer: function () {
					if (this.isAddMode() && !this.$IsProcessMode) {
						const esq = this.getContactAccountQuery();
						esq.getEntityCollection(function(response) {
							if (response.success && response.collection.getCount() > 0) {
								const account = response.collection.first();
								this.$Client = {
									value: account.$Id,
									displayValue: account.$Name,
									column: "Account"
								};
							}
						}, this);
					}
				},

				/**
				 * Returns query to account.
				 * @protected
				 * @virtual
				 * @returns {Terrasoft.EntitySchemaQuery} Query to account.
				 */
				getContactAccountQuery: function () {
					const esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Account",
						rowCount: 1
					});
					esq.addColumn("Id");
					esq.addColumn("Name");
					esq.addColumn("PriceList");
					const contactFilter = this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "[Contact:Account:Id].Id",
						Terrasoft.SysValue.CURRENT_USER_CONTACT.value);
					esq.filters.addItem(contactFilter);
					return esq;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @override
				 */
				onSaved: function() {
					const operation = this.get("Operation");
					if (operation === ConfigurationEnums.CardStateV2.EDIT) {
						this.updateDetail({detail: "PortalSupplyPaymentDetail"});
						this.updateDetail({detail: "PortalSupplyPaymentResultsDetail"});
					}
					this.callParent(arguments);
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
			details: /**SCHEMA_DETAILS*/{
				"PortalSupplyPaymentDetail": {
					"schemaName": "PortalSupplyPaymentDetailV2",
					"entitySchemaName": "SupplyPaymentElement",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Order"
					},
					"defaultValues": {
						"Currency": {
							"masterColumn": "Currency"
						},
						"CurrencyRate": {
							"masterColumn": "CurrencyRate"
						}
					},
					"subscriber": {"methodName": "refreshAmount"}
				},
				"PortalSupplyPaymentResultsDetail": {
					"schemaName": "PortalSupplyPaymentDetailV2",
					"entitySchemaName": "SupplyPaymentElement",
					"filter": {
						"masterColumn": "Id",
						"detailColumn": "Order"
					},
					"defaultValues": {
						"Currency": {
							"masterColumn": "Currency"
						},
						"CurrencyRate": {
							"masterColumn": "CurrencyRate"
						}
					},
					"subscriber": {"methodName": "refreshAmount"}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "OrderPassportTab",
					"propertyName": "items",
					"name": "PortalSupplyPaymentDetail",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "insert",
					"parentName": "OrderResultsTab",
					"propertyName": "items",
					"name": "PortalSupplyPaymentResultsDetail",
					"index": 1,
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "remove",
					"name": "SupplyPayment"
				},
				{
					"operation": "remove",
					"name": "SupplyPaymentResults"
				}
			]/**SCHEMA_DIFF*/
		};
	});
