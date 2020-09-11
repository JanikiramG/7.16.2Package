define("BaseProductDetailPageV2", ["BusinessRuleModule", "MoneyModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "BaseProductEntry",
		attributes: {
			/**
			 * Measure unit
			 * @type {Terrasoft.DataValueType.LOOKUP}
			 */
			"Unit": {
				lookupListConfig: {
					filter: function() {
						if (this.get("Product")) {
							return this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
								"[ProductUnit:Unit:Id].Product.Id", this.get("Product").value);
						}
						return null;
					}
				}
			},

			/**
			 * Products base units list
			 * @type {Terrasoft.DataValueType.COLLECTION}
			 */
			"BaseUnits": {
				dataValueType: this.Terrasoft.DataValueType.COLLECTION,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},

			/**
			 * Product
			 * @type {Terrasoft.DataValueType.LOOKUP}
			 */
			"Product": {
				lookupListConfig: {
					columns: ["[ProductUnit:Product:Id].NumberOfBaseUnits", "Unit"],
					filter: function() {
						return this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
							"IsArchive", 0);
					}
				},
				isRequired: true
			},

			/**
			 * Ammount
			 * @type {Terrasoft.DataValueType.FLOAT}
			 */
			"Amount": {
				dependencies: [{
					columns: ["BaseQuantity"],
					methodName: "onBaseQuantityOrUnitChange"
				}]
			},

			/**
			 * Quantity in base measure unit
			 * @type {Terrasoft.DataValueType.FLOAT}
			 */
			"BaseQuantity": {
				name: "BaseQuantity",
				dataValueType: this.Terrasoft.DataValueType.FLOAT,
				dependencies: [{
					columns: ["Quantity", "Unit"],
					methodName: "onQuantityOrUnitChange"
				}]
			},

			/**
			 * PriceList
			 * @type {Terrasoft.DataValueType.LOOKUP}
			 */
			"PriceList": {
				lookupListConfig: {
					filter: function() {
						if (this.get("Product")) {
							return this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
								"[ProductPrice:PriceList:Id].Product.Id", this.get("Product").value);
						}
						return null;
					}
				},
				dependencies: [{
					columns: ["Product"],
					methodName: "onProductChange"
				}]
			},

			/**
			 * Product price
			 * @type {Terrasoft.DataValueType.FLOAT}
			 */
			"Price": {
				name: "Price",
				dataValueType: this.Terrasoft.DataValueType.FLOAT,
				dependencies: [{
					columns: ["PriceList"],
					methodName: "onPriceListChange"
				}]
			},

			/**
			 * Is initialized
			 * @type {Terrasoft.DataValueType.BOOLEAN}
			 */
			"IsInitialized": {
				dataValueType: this.Terrasoft.DataValueType.BOOLEAN
			}
		},
		methods: {
			/**
			 * Entity initialization event
			 * @protected
			 * @virtual
			 */
			initEntity: function(callback, scope) {
				this.callParent([function() {
					if (!this.get("IsInitialized")) {
						this.Terrasoft.chain(
							this._setQuerySysSettings,
							this._loadDiscountTax,
							this._loadProductBaseUnits,
							function() {
								this.set("IsInitialized", true);
								this.set("IsEntityInitialized", true);
								callback.call(scope || this);
							}, this
						)
					} else {
						callback.call(scope || this);
					}
				}, this]);
			},

			/**
			 * Sets query system settings.
			 * @param callback {Function} Callback function.
			 * @param scope {Object} Callback scope.
			 * @private
			 */
			_setQuerySysSettings: function(callback, scope) {
				Terrasoft.SysSettings.querySysSettings(["BasePriceList", "DefaultTax", "PriceWithTaxes"], function(values) {
					if (values.DefaultTax) {
						this.set("DefaultTax", values.DefaultTax);
					}
					if (values.BasePriceList) {
						this.set("BasePriceList", values.BasePriceList);
					}
					if (values.PriceWithTaxes) {
						this.set("PriceWithTaxes", values.PriceWithTaxes);
					}
					this.Ext.callback(callback, scope || this);
				}, this);
			},

			/**
			 * Loads discount tax.
			 * @param callback {Function} Callback function.
			 * @param scope {Object} Callback scope.
			 * @private
			 */
			_loadDiscountTax: function(callback, scope) {
				if (this.isAddMode() && this.$DefaultTax) {
					const select = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "Tax"
					});
					select.addColumn("Id");
					select.addColumn("Name");
					select.addColumn("Percent");
					select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Id", this.$DefaultTax.value));
					select.execute(function(response) {
						response.collection.each(function(item) {
							this.set("Tax", this.$DefaultTax);
							this.set("DiscountTax", item.get("Percent"));
						}, this);
						this.Ext.callback(callback, scope || this);
					}, this);
				} else {
					this.Ext.callback(callback, scope || this);
				}
			},

			/**
			 * Set quantity.
			 * On change field "Measure unit"
			 */
			onQuantityOrUnitChange: function() {
				const unit = this.get("Unit");
				const baseUnits = this.get("BaseUnits");
				if (this.isEmpty(unit)) {
					this.set("BaseQuantity", 0);
					return;
				}
				if (this.isEmpty(baseUnits)) {
					this._loadProductBaseUnits(this.onQuantityOrUnitChange, this);
					return;
				}
				const quantity = this.get("Quantity");
				const productUnit = baseUnits.findByAttr("UnitId", unit.value);
				const numberOfBaseUnits = productUnit ? productUnit.get("NumberOfBaseUnits") : 1;
				this.set("BaseQuantity", quantity * (numberOfBaseUnits || 1));
			},

			/**
			 * Loads products base units.
			 * @param callback {Function} Callback function.
			 * @param scope {Object} Callback scope.
			 * @private
			 */
			_loadProductBaseUnits: function(callback, scope) {
				const product = this.get("Product");
				if (this.isEmpty(product)) {
					this.Ext.callback(callback, scope || this);
					return;
				}
				var select = this.Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "ProductUnit"});
				select.addColumn("NumberOfBaseUnits");
				select.addColumn("Unit.Id", "UnitId");
				select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Product.Id", product.value));
				select.execute(function(response) {
					this.set("BaseUnits", response.collection);
					this.Ext.callback(callback, scope || this);
				}, this);
			},

			/**
			 * Set quantity
			 * On change field "Quantity"
			 * @protected
			 */
			onBaseQuantityOrUnitChange: function() {
				this.calcAmount();
			},

			/**
			 * Calculate amount
			 * @protected
			 */
			calcAmount: function() {
				var price = this.get("Price") || 0;
				var quantity = this.get("BaseQuantity") || this.get("Quantity") || 0;
				this.set("Amount", (price * quantity));
			},

			/**
			 * On product change event
			 * @protected
			 */
			onProductChange: function() {
				var basePriceList = this.get("BasePriceList");
				var product = this.get("Product");
				this.set("PriceList", null);
				if (!product || !basePriceList) {
					return;
				}
				this.set("PriceList", basePriceList);
				this.set("Unit", product.Unit);
			},

			/**
			 * Get additional pricelist data
			 * @protected
			 * @returns {boolean}
			 */
			requirePriceListData: function() {
				var priceList = this.get("PriceList");
				var product = this.get("Product");
				if (!priceList || !product) {
					this.set("PriceList", null);
					this.set("Price", 0);
					this.set("Tax", null);
					this.set("DiscountTax", 0);
					return false;
				}
				var select = Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "ProductPrice"
				});
				select.addColumn("Price");
				select.addColumn("Currency.Id");
				select.addColumn("Tax");
				select.addColumn("Tax.Percent");
				select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "PriceList", priceList.value));
				select.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, "Product", this.get("Product").value));
				select.execute(function(response) {
					response.collection.each(function(item) {
						priceList.Price = item.get("Price");
						priceList["Currency.Id"] = item.get("Currency.Id");
						priceList.Tax = item.get("Tax");
						priceList["Tax.Percent"] = item.get("Tax.Percent");
					}, this);
					if (priceList && priceList.hasOwnProperty("Tax")) {
						this.set("Tax", priceList.Tax);
						this.set("DiscountTax", priceList["Tax.Percent"]);
					}
					this.onPriceListChange(true);
				}, this);
				return false;
			},

			/**
			 * On PriceList change event
			 * @protected
			 * @returns {boolean}
			 */
			onPriceListChange: function() {
				var product = this.get("Product");
				if (product && product.Unit) {
					this.set("Unit", product.Unit);
				}
				return this.requirePriceListData();
			}
		},
		rules: {
			/**
			 * Business rule of PriceList
			 */
			"PriceList": {
				"EnabledPriceList": {
					ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					property: BusinessRuleModule.enums.Property.ENABLED,
					conditions: [{
						leftExpression: {
							type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
							attribute: "Product"
						},
						comparisonType: this.Terrasoft.ComparisonType.IS_NOT_NULL
					}]
				}
			},
			"Name": {
				"BindParameterEnabledName": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"TotalAmount": {
				"BindParameterEnabledTotalAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"PrimaryTotalAmount": {
				"BindParameterEnabledPrimaryTotalAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"DiscountTax": {
				"BindParameterEnabledDiscountTax": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"TaxAmount": {
				"BindParameterEnabledTaxAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"PrimaryTaxAmount": {
				"BindParameterEnabledPrymaryTaxAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"Amount": {
				"BindParameterEnabledAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			},
			"PrimaryAmount": {
				"BindParameterEnabledPrimaryAmount": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.ENABLED,
					"conditions": [{
						"leftExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": true
						},
						"comparisonType": this.Terrasoft.ComparisonType.EQUAL,
						"rightExpression": {
							"type": BusinessRuleModule.enums.ValueType.CONSTANT,
							"value": false
						}
					}]
				}
			}
		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "remove",
			"name": "CustomProduct",
			"parentName": "BaseGeneralInfoBlock",
			"propertyName": "items",
			"values": {
				"bindTo": "CustomProduct",
				"layout": {
					"column": 0,
					"row": 2,
					"colSpan": 24
				}
			}
		},
			{
				"operation": "move",
				"name": "Quantity",
				"parentName": "BaseGeneralInfoBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "Quantity",
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "move",
				"name": "Unit",
				"parentName": "BaseGeneralInfoBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "Unit",
					//"enabled": true,
					"layout": {"column": 12, "row": 2, "colSpan": 12},
					"contentType": this.Terrasoft.ContentType.ENUM
				}
			},
			{
				"operation": "move",
				"name": "DeliveryDate",
				"parentName": "BaseGeneralInfoBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "DeliveryDate",
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 12
					}
				}
			},
			{
				"operation": "merge",
				"name": "AmountControlGroup",
				"parentName": "BaseProductPageGeneralTabContainer",
				"propertyName": "items",
				"values": {
					"controlConfig": {
						"collapsed": false
					}
				}
			},
			{
				"operation": "insert",
				"name": "PriceList",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "PriceList",
					"layout": {"column": 0, "row": 0, "colSpan": 12},
					"contentType": this.Terrasoft.ContentType.ENUM
				}
			},
			{
				"operation": "move",
				"name": "Price",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "Price",
					"layout": {"column": 0, "row": 1, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "Amount",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "Amount",
					"layout": {"column": 12, "row": 1, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "DiscountPercent",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "DiscountPercent",
					"layout": {"column": 0, "row": 2, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "DiscountAmount",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "DiscountAmount",
					"layout": {"column": 12, "row": 2, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "Tax",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "Tax",
					"layout": {"column": 0, "row": 3, "colSpan": 12},
					"contentType": this.Terrasoft.ContentType.ENUM
				}
			},
			{
				"operation": "move",
				"name": "TaxAmount",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "TaxAmount",
					"layout": {"column": 0, "row": 4, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "DiscountTax",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "DiscountTax",
					"layout": {"column": 12, "row": 4, "colSpan": 12}
				}
			},
			{
				"operation": "move",
				"name": "TotalAmount",
				"parentName": "AmountBlock",
				"propertyName": "items",
				"values": {
					"bindTo": "TotalAmount",
					"layout": {"column": 0, "row": 5, "colSpan": 12}
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
