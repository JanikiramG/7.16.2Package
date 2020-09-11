define("SupplyPaymentProductDetailV2", [], function() {
	return {
		entitySchemaName: "SupplyPaymentProduct",
		mixins: {
			ConfigurationGridUtilites: "Terrasoft.ConfigurationGridUtilities"
		},
		attributes: {
			/**
			 * ####### #### ### ###### #############.
			 */
			IsEditable: {
				dataValueType: Terrasoft.DataValueType.BOOLEAN,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				value: true
			}
		},
		methods: {
			/**
			 * ########### ######### ###### ##### ######### # ######.
			 * @overridden
			 * @param {Terrasoft.Collection} collection ######### ######### #######.
			 */
			prepareResponseCollection: function(collection) {
				this.callParent(arguments);
				var index = 0;
				var setProductPriceLimits = function(next) {
					var item = collection.getByIndex(index++);
					this.setProductPriceLimits(item, function() {
						next();
					});
				};
				var methods = [];
				collection.each(function() {
					methods.push(setProductPriceLimits);
				}, this);
				methods.push(this);
				Terrasoft.chain.apply(this, methods);
			},

			/**
			 * ########## ######## #### # ####### ########## # ######## #### # ######.
			 * @private
			 * @param {String} table ### #######.
			 * @param {String} column ### #######.
			 * @return {Object} ########## ####### ######.
			 */
			getColumnData: function(table, column) {
				if (this.get(table) && this.get(table)[column]) {
					this.set(Ext.String.format("{0}.{1}", table, column), this.get(table)[column]);
				}
				return this.get(Ext.String.format("{0}.{1}", table, column));
			},

			/**
			 * ######### ###### ### ######### ##### ########## # ##### ########.
			 * @private
			 * @param {Terrasoft.BaseViewModel} item tem ####### ###### #########.
			 * @param {Function} callback ####### ######### ######.
			 */
			setProductPriceLimits: function(item, callback) {
				if (!item.get("Product")) {
					return;
				}
				var esq = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "SupplyPaymentProduct"
				});
				esq.addAggregationSchemaColumn("Amount", Terrasoft.AggregationType.SUM, "AmountSum");
				esq.addAggregationSchemaColumn("Quantity", Terrasoft.AggregationType.SUM, "QuantitySum");
				var filters = Terrasoft.createFilterGroup();
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"SupplyPaymentElement.Order", item.getColumnData("SupplyPaymentElement", "Order").value));
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"SupplyPaymentElement.Type", item.getColumnData("SupplyPaymentElement", "Type").value));
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL,
					"Product", item.get("Product").value));
				filters.addItem(Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.NOT_EQUAL,
					"Id", item.get("Id")));
				esq.filters = filters;
				esq.getEntityCollection(function(response) {
					if (response.success) {
						var collection = response.collection;
						if (collection.getCount() > 0) {
							var item = collection.getByIndex(0);
							var amountSum = item.get("AmountSum");
							var quantitySum = item.get("QuantitySum");
							item.set("AmountPlan", amountSum);
							item.set("QuantityPlan", quantitySum);
							callback.call(this, response);
						}
					}
				}, this);
			},

			/**
			 * ######### # ######### ####### #######.
			 * @overridden
			 * @param {Terrasoft.EntitySchemaQuery} esq ######, # ####### ##### ######### ####### ## #########.
			 */
			addGridDataColumns: function(esq) {
				this.callParent(arguments);
				esq.addColumn("Product.Quantity");
				esq.addColumn("Product.TotalAmount");
				esq.addColumn("SupplyPaymentElement.Type");
				esq.addColumn("SupplyPaymentElement.Order");
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"className": "Terrasoft.ConfigurationGrid",
					"generator": "ConfigurationGridGenerator.generatePartial",
					"generateControlsConfig": {bindTo: "generateActiveRowControlsConfig"},
					"multiSelect": false,
					"rowDataItemMarkerColumnName": "Product",
					"changeRow": {"bindTo": "changeRow"},
					"unSelectRow": {"bindTo": "unSelectRow"},
					"onGridClick": {"bindTo": "onGridClick"},
					"activeRowActions": [
						{
							"className": "Terrasoft.Button",
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "save",
							"markerValue": "save",
							"imageConfig": {"bindTo": "Resources.Images.SaveIcon"}
						},
						{
							"className": "Terrasoft.Button",
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "cancel",
							"markerValue": "cancel",
							"imageConfig": {"bindTo": "Resources.Images.CancelIcon"}
						},
						{
							"className": "Terrasoft.Button",
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"tag": "remove",
							"markerValue": "remove",
							"imageConfig": {"bindTo": "Resources.Images.RemoveIcon"}
						}
					],
					"listedZebra": true,
					"initActiveRowKeyMap": {"bindTo": "initActiveRowKeyMap"},
					"activeRowAction": {"bindTo": "onActiveRowAction"}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
