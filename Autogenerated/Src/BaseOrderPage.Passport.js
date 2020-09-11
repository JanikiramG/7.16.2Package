define("BaseOrderPage", ["OrderConfigurationConstants", "ConfigurationEnums", "OrderUtilities"],
	function(OrderConfigurationConstants, ConfigurationEnums) {
		return {
			entitySchemaName: "Order",
			messages: {

				/**
				 * ############ ### ######### ##### ######.
				 */
				"GetOrderAmount": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			mixins: {
				OrderUtilities: "Terrasoft.OrderUtilities"
			},
			details: /**SCHEMA_DETAILS*/{
				SupplyPayment: {
					schemaName: "SupplyPaymentDetailV2",
					entitySchemaName: "SupplyPaymentElement",
					filter: {
						masterColumn: "Id",
						detailColumn: "Order"
					},
					defaultValues: {
						Currency: {
							masterColumn: "Currency"
						},
						CurrencyRate: {
							masterColumn: "CurrencyRate"
						}
					},
					subscriber: {methodName: "refreshAmount"}
				},
				SupplyPaymentResults: {
					schemaName: "SupplyPaymentDetailV2",
					entitySchemaName: "SupplyPaymentElement",
					filter: {
						masterColumn: "Id",
						detailColumn: "Order"
					},
					defaultValues: {
						Currency: {
							masterColumn: "Currency"
						},
						CurrencyRate: {
							masterColumn: "CurrencyRate"
						}
					},
					subscriber: {methodName: "refreshAmount"}
				}
			}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "OrderPassportTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1,
					"values": {
						"caption": {"bindTo": "Resources.Strings.OrderPassport"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "OrderPassportTab",
					"propertyName": "items",
					"name": "SupplyPayment",
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				},
				{
					"operation": "insert",
					"parentName": "OrderResultsTab",
					"propertyName": "items",
					"name": "SupplyPaymentResults",
					"index": 1,
					"values": {"itemType": Terrasoft.ViewItemType.DETAIL}
				}
			]/**SCHEMA_DIFF*/,
			methods: {
				/**
				 * @inheritdoc Terrasoft.Configuration.BasePageV2#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initValidateActions();
				},

				/**
				 * ############# #######.
				 * @protected
				 */
				initValidateActions: function() {
					this.save = this.needToChangeInvoice({
						getId: function() {
							return this.get("Id");
						},
						name: "Order",
						validateColumns: ["Currency"]
					}, this.save, this);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#activeTabChange
				 * @overridden
				 */
				activeTabChange: function(activeTab) {
					this.callParent(arguments);
					var tabName = activeTab.get("Name");
					if (tabName === "OrderPassportTab") {
						this.updateDetail({detail: "SupplyPayment"});
					} else if (tabName === "OrderResultsTab") {
						this.updateDetail({detail: "SupplyPaymentResults"});
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					var detailIds = [this.getDetailId("SupplyPayment"), this.getDetailId("SupplyPaymentResults")];
					this.sandbox.subscribe("GetOrderAmount", this.onGetOrderAmount, this, detailIds);
				},

				/**
				 * ############ ######### GetOrderAmount.
				 * @public
				 */
				onGetOrderAmount: function() {
					return this.get("Amount");
				},

				/**
				 * @inheritdoc Terrasoft.OrderPageV2#modifyAmountESQ
				 * @overridden
				 */
				modifyAmountESQ: function(esq) {
					this.callParent(arguments);
					esq.addColumn("PaymentAmount");
					esq.addColumn("PrimaryPaymentAmount");
				},

				/**
				 * @inheritdoc Terrasoft.OrderPageV2#updateAmountColumnValues
				 * @overridden
				 */
				updateAmountColumnValues: function(entity) {
					this.callParent(arguments);
					var updatedPaymentAmount = entity.get("PaymentAmount");
					var updatedPrimaryPaymentAmount = entity.get("PrimaryPaymentAmount");
					if (updatedPaymentAmount !== this.get("PaymentAmount") ||
						updatedPrimaryPaymentAmount !== this.get("PrimaryPaymentAmount")) {
						this.set("PaymentAmount", updatedPaymentAmount);
						this.set("PrimaryPaymentAmount", updatedPrimaryPaymentAmount);
					}
				},

				/**
				 * ######### ####### "######".
				 * @obsolete
				 */
				validateOrderStatus: function(callback, scope) {
					this.log(this.Ext.String.format(this.Terrasoft.Resources.ObsoleteMessages.ObsoleteMethodMessage,
						"validateOrderStatus", "asyncValidate"));
					callback.call(scope || this, {success: true});
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overriden
				 */
				onSaved: function() {
					var operation = this.get("Operation");
					if (operation === ConfigurationEnums.CardStateV2.EDIT) {
						this.updateDetail({detail: "SupplyPayment"});
						this.updateDetail({detail: "SupplyPaymentResults"});
					}
					this.callParent(arguments);
				}
			}
		};
	});
