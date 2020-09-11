define("ProductPageV2", ["MoneyModule", "MultiCurrencyEdit", "MultiCurrencyEditUtilities",
		"css!ProductManagementBaseCss"],
	function(MoneyModule) {
		return {
			entitySchemaName: "Product",
			attributes: {
				/**
				 * Owner of the product.
				 */
				"Owner": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					lookupListConfig: {
						filter: function() {
							return Terrasoft.createColumnIsNotNullFilter("[SysAdminUnit:Contact].Id");
						}
					}
				},
				/**
				 * Unit of the product.
				 */
				"Unit": {
					"isRequired": true
				},
				/**
				 * Price in base currency.
				 * @private
				 */
				"PrimaryPrice": {
					"dataValueType": Terrasoft.DataValueType.FLOAT,
					"dependencies": [
						{
							"columns": ["CurrencyRate", "Price"],
							"methodName": "recalculatePrimaryPrice"
						}
					]
				},
				/**
				 * Currency rate.
				 * @private
				 */
				"CurrencyRate": {
					"dataValueType": Terrasoft.DataValueType.FLOAT,
					"dependencies": [
						{
							"columns": ["Currency"],
							"methodName": "setCurrencyRate"
						}
					]
				},
				/**
				 * Currency rate list.
				 */
				"CurrencyRateList": {
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					value: this.Ext.create("Terrasoft.Collection")
				},
				/**
				 * Currency button menu list.
				 */
				"CurrencyButtonMenuList": {
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					value: this.Ext.create("Terrasoft.BaseViewModelCollection")
				}
			},
			properties: {
				moneyModule: null
			},
			details: /**SCHEMA_DETAILS*/{
				Files: {
					schemaName: "FileDetailV2",
					entitySchemaName: "ProductFile",
					filter: {
						masterColumn: "Id",
						detailColumn: "Product"
					}
				}
			}/**SCHEMA_DETAILS*/,
			mixins: {
				/**
				 * Mixin multi-currency management in the entity page.
				 */
				MultiCurrencyEditUtilities: "Terrasoft.MultiCurrencyEditUtilities"
			},
			methods: {
				/**
				 * @inheritDoc Terrasoft.BasePageV2#init
				 * @override
				 */
				init: function() {
					this.moneyModule = MoneyModule;
					this.callParent(arguments);
				},
				
				/**
				 * @inheritDoc Terrasoft.BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.mixins.MultiCurrencyEditUtilities.init.call(this);
					this.recalculatePrimaryPrice();
					this.setCurrencyRate();
				},

				/**
				 * @inheritDoc Terrasoft.ContextHelpMixin#initContextHelp
				 * @override
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1056);
					this.callParent(arguments);
				},

				/**
				 * Handlers the file selection dialog.
				 * @return {Boolean}
				 */
				beforePhotoFileSelected: function() {
					return true;
				},

				/**
				 * Returns photo link.
				 * @protected
				 * @return {String}
				 */
				getPhotoSrcMethod: function() {
					var primaryImageColumnValue = this.get(this.primaryImageColumnName);
					if (primaryImageColumnValue) {
						return this.getSchemaImageUrl(primaryImageColumnValue);
					}
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.DefaultPhoto"));
				},

				/**
				 * Handlers changed and upload an image.
				 * @param {Object} photo
				 */
				onPhotoChange: function(photo) {
					if (!photo) {
						this.set(this.primaryImageColumnName, null);
						return;
					}
					this.Terrasoft.ImageApi.upload({
						file: photo,
						onComplete: this.onPhotoUploaded,
						onError: this.Terrasoft.emptyFn,
						scope: this
					});
				},

				/**
				 * Handlers uploaded an image.
				 * @param {String} imageId
				 */
				onPhotoUploaded: function(imageId) {
					var imageData = {
						value: imageId,
						displayValue: "Picture"
					};
					this.set(this.primaryImageColumnName, imageData);
				},

				/**
				 * Returns currency division.
				 * @protected
				 * @return {Number} Currency division.
				 */
				getCurrencyDivision: function() {
					var currency = this.get("Currency");
					return currency && currency.Division;
				},

				/**
				 * Recalculates price in base currency.
				 * @protected
				 */
				recalculatePrimaryPrice: function() {
					var price = this.get("Price");
					if (this.Ext.isEmpty(price)) {
						this.set("PrimaryPrice", null);
						return;
					}
					var division = this.getCurrencyDivision();
					this.moneyModule.RecalcBaseValue.call(this, "CurrencyRate", "Price", "PrimaryPrice", division);
				},

				/**
				 * Sets currency rate.
				 * @protected
				 */
				setCurrencyRate: function() {
					this.moneyModule.LoadCurrencyRate.call(this, "Currency", "CurrencyRate", new Date());
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "PhotoContainer",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["image-edit-container"],
						"layout": {"column": 0, "row": 0, "rowSpan": 2, "colSpan": 3},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "PhotoContainer",
					"propertyName": "items",
					"name": "Photo",
					"values": {
						"getSrcMethod": "getPhotoSrcMethod",
						"onPhotoChange": "onPhotoChange",
						"beforeFileSelected": "beforePhotoFileSelected",
						"readonly": false,
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl"
					}
				},
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Name",
					"values": {
						"layout": {"column": 3, "row": 0, "colSpan": 20},
						"labelWrapConfig": {"classes": {"wrapClassName": ["page-header-label-wrap"]}}
					}
				},
				{
					"operation": "insert",
					"name": "CommonControlGroup",
					"parentName": "Header",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"layout": {"column": 3, "row": 1, "colSpan": 20, "rowSpan": 1},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "ProductGeneralInfoBlock",
					"parentName": "CommonControlGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "Type",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Type",
						"layout": {"column": 0, "row": 0, "colSpan": 12},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"name": "Unit",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Unit",
						"layout": {"column": 12, "row": 0, "colSpan": 12},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"name": "Code",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Code",
						"layout": {"column": 0, "row": 1, "colSpan": 12},
						"tip": {
							"content": {"bindTo": "Resources.Strings.CodeTip"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "Owner",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Owner",
						"layout": {"column": 12, "row": 1, "colSpan": 12},
						"tip": {
							"content": {"bindTo": "Resources.Strings.OwnerTip"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "URL",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "URL",
						"layout": {"column": 0, "row": 2, "colSpan": 12},
						"tip": {
							"content": {"bindTo": "Resources.Strings.UrlTip"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "IsArchive",
					"parentName": "ProductGeneralInfoBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "IsArchive",
						"layout": {"column": 12, "row": 2, "colSpan": 12},
						"tip": {
							"content": {"bindTo": "Resources.Strings.IsArchiveTip"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "ProductGeneralInfoTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1,
					"values": {
						"caption": {"bindTo": "Resources.Strings.GeneralInfoTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "ProductFilesTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {"bindTo": "Resources.Strings.FilesTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "PriceControlGroup",
					"parentName": "ProductGeneralInfoTab",
					"propertyName": "items",
					"index": 2,
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"caption": {"bindTo": "Resources.Strings.PriceGroupCaption"},
						"items": [],
						"controlConfig": {
							"collapsed": false
						},
						"markerValue": "GroupPrices"
					}
				},
				{
					"operation": "insert",
					"name": "NotesControlGroup",
					"parentName": "ProductFilesTab",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": [],
						"caption": {"bindTo": "Resources.Strings.NotesGroupCaption"},
						"controlConfig": {
							"collapsed": false
						}
					}
				},
				{
					"operation": "insert",
					"name": "ProductPriceBlock",
					"parentName": "PriceControlGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					}
				},
// Columns and details
				{
					"operation": "insert",
					"name": "Price",
					"parentName": "ProductPriceBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Price",
						"layout": {"column": 0, "row": 0, "colSpan": 12},
						"primaryAmount": "PrimaryPrice",
						"currency": "Currency",
						"rate": "CurrencyRate",
						"primaryAmountEnabled": false,
						"rateEnabled": false,
						"generator": "MultiCurrencyEditViewGenerator.generate"
					}
				},
				{
					"operation": "insert",
					"name": "Tax",
					"parentName": "ProductPriceBlock",
					"propertyName": "items",
					"values": {
						"bindTo": "Tax",
						"layout": {"column": 12, "row": 0, "colSpan": 12},
						"contentType": Terrasoft.ContentType.ENUM
					}
				},
				{
					"operation": "insert",
					"parentName": "ProductFilesTab",
					"propertyName": "items",
					"index": 0,
					"name": "Files",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "NotesControlGroup",
					"propertyName": "items",
					"name": "Notes",
					"values": {
						"contentType": Terrasoft.ContentType.RICH_TEXT,
						"layout": {"column": 0, "row": 0, "colSpan": 24},
						"labelConfig": {
							"visible": false
						},
						"controlConfig": {
							"imageLoaded": {
								"bindTo": "insertImagesToNotes"
							},
							"images": {
								"bindTo": "NotesImagesCollection"
							}
						}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
