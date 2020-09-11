define("FullscreenForecastTab", [
		"ForecastTab",
		"ForecastSheetQueryMixin",
		"ImageCustomGeneratorV2",
		"css!ForecastModule",
		"css!ForecastsModule",
		"css!FullscreenViewModule",
		"css!FullscreenForecastModule"],
	function() {
		return {
			attributes: {
				"ForecastId": {
					dataValueType: this.Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"ForecastInfo": {
					dataValueType: this.Terrasoft.DataValueType.ENTITY,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"HeaderCaption": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"IsBlankSlateVisible": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			mixins: {
				"ForecastSheetQueryMixin": "Terrasoft.ForecastSheetQueryMixin"
			},
			methods: {

				//region Methods: Private

				/**
				 * @private
				 */
				_parseHash: function() {
					var currentState = this.sandbox.publish("GetHistoryState");
					var hashParts = currentState.hash.historyState.split("/");
					return {
						moduleName: hashParts[0],
						forecastId: hashParts[1]
					};
				},

				/**
				 * @private
				 */
				_initForecastId: function() {
					var hash = this._parseHash();
					this.$ForecastId = hash.forecastId;
				},

				/**
				 * @private
				 */
				_initHeaderCaption: function() {
					this.$HeaderCaption = this.get("Resources.Strings.ForecastModuleCaption");
					if (!this.Ext.isEmpty(this.$ForecastInfo) && !this.Ext.isEmpty(this.$ForecastInfo.$Name)) {
						this.$HeaderCaption = this.$ForecastInfo.$Name;
					}
					this.sandbox.publish("UpdatePageHeaderCaption", {
						pageHeaderCaption: this.$HeaderCaption
					});
				},

				/**
				 * @private
				 */
				_initBlankStateVisible: function() {
					this.$IsBlankSlateVisible = this.Ext.isIEOrEdge;
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @override
				 */
				init: function() {
					this.showBodyMask();
					this.callParent(arguments);
					this._initBlankStateVisible();
					this._initForecastId();
				},

				/**
				 * @inheritdoc Terrasoft.ForecastTab#initForecasts
				 * @override
				 */
				initForecasts: function() {
					var parentMethod = this.getParentMethod();
					var args = arguments;
					this.loadForecasts(function() {
						this._initHeaderCaption();
						parentMethod.apply(this, args);
						this.hideBodyMask();
					}, this);
				},

				onRender: function() {
					this.callParent(arguments);
					this._initHeaderCaption();
				},

				/**
				 * Loads sorted by name forecasts.
				 * @protected
				 * @virtual
				 * @param {Function} callback Callback function.
				 * @param {Terrasoft.BaseModel} scope Context of callback function.
				 * @return {Terrasoft.Collection} Collection of forecasts.
				 */
				loadForecasts: function(callback, scope) {
					var esq = this.getForecastsEsq();
					esq.getEntity(this.$ForecastId, function(response) {
						if (response && response.success) {
							this.$ForecastInfo = response.entity;
							this.Ext.callback(callback, scope || this);
						}
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.ForecastTab#getForecastObject
				 * @override
				 */
				getForecastObject: function() {
					if (this.Ext.isEmpty(this.$ForecastInfo)) {
						return {};
					}
					return {
						"forecastId": this.$ForecastId,
						"forecastEntityId": this.$ForecastInfo.$ForecastEntityId,
						"forecastEntityName": this.$ForecastInfo.$ForecastEntityName,
						"forecastForecastEntityInCellUId": this.$ForecastInfo.$ForecastEntityInCellUId,
						"forecastSetting": this.$ForecastInfo.$Setting
					};
				},

				//endregion

				//region Methods: Public

				/**
				 * Returns blank slate icon url.
				 */
				getBlankSlateIcon: function() {
					return this.Terrasoft.ImageUrlBuilder.getUrl(this.get("Resources.Images.BlankSlateIcon"));
				}

				//endregion

			},
			diff: [
				{
					"operation": "insert",
					"name": "BlankSlateContainer",
					"parentName": "ForecastModuleContainerMain",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"classes": {
							"wrapClassName": ["blank-slate-wrap"]
						},
						"visible": {
							"bindTo": "IsBlankSlateVisible"
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "BlankSlateIcon",
					"parentName": "BlankSlateContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getBlankSlateIcon",
						"readonly": true,
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"classes": {
							"wrapClass": ["blank-slate-icon"]
						},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24,
							"rowSpan": 5
						}
					}
				},
				{
					"operation": "insert",
					"name": "BlankSlateDescription",
					"parentName": "BlankSlateContainer",
					"propertyName": "items",
					"values": {
						"itemType": this.Terrasoft.ViewItemType.LABEL,
						"caption": {
							"bindTo": "Resources.Strings.BlankSlateDescription"
						},
						"labelClass": ["blank-slate-description"],
						"layout": {
							"column": 0,
							"row": 6,
							"colSpan": 24,
							"rowSpan": 5
						}
					}
				},
				{
					"operation": "merge",
					"name": "buttonContainer",
					"values": {
						"visible": {
							"bindTo": "IsBlankSlateVisible",
							"bindConfig": {"converter": "invertBooleanValue"}
						}
					}
				},
				{
					"operation": "merge",
					"name": "ForecastApp",
					"values": {
						"visible": {
							"bindTo": "IsBlankSlateVisible",
							"bindConfig": {"converter": "invertBooleanValue"}
						}
					}
				},
				{
					"operation": "remove",
					"name": "fullscreenButton"
				}
			]
		};
	}
);
