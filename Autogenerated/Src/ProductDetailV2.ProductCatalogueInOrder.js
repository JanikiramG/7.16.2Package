define("ProductDetailV2", [], function() {
		return {
			methods: {
				/**
				 * @inheritdoc Terrasoft.ProductDetailV2#productSelectionHandler
				 * @overridden
				 */
				onProductsSelected: function() {
					this.callParent();
					this.updateOrderProductCurrency();
				},

				/**
				 * Setups order currency for products that has empty order currency
				 * @virtual
				 */
				updateOrderProductCurrency: function() {
					var orderId = this.get("MasterRecordId");
					if (!orderId) {
						return;
					}
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Order"
					});
					esq.addColumn("Currency");
					esq.addColumn("CurrencyRate");
					esq.getEntity(orderId, function(result) {
						var entity = result.entity;
						if (!entity) {
							return;
						}
						var currency = entity.get("Currency");
						var currencyRate = entity.get("CurrencyRate");
						var update = this.Ext.create("Terrasoft.UpdateQuery", {
							rootSchemaName: "OrderProduct"
						});
						update.setParameterValue("Currency", currency.value, this.Terrasoft.DataValueType.GUID);
						update.setParameterValue("CurrencyRate", currencyRate, this.Terrasoft.DataValueType.FLOAT);
						update.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Order", orderId));
						update.filters.addItem(this.Terrasoft.createIsNullFilter(
							this.Ext.create("Terrasoft.ColumnExpression", {columnPath: "Currency"})));
						update.execute();
					}, this);
				}
			}
		};
	}
);
