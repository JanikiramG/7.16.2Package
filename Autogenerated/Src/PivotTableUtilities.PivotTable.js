define("PivotTableUtilities", [], function() {
	Ext.define("Terrasoft.configuration.mixins.PivotTableUtilities", {
		alternateClassName: "Terrasoft.PivotTableUtilities",

		statics: {
			/**
			 * Validate pivot table config.
			 * @param {Object} config 
			 */
			validatePivotConfig: function(config) {
				if (!config) {
					return false;
				}
				const rows = config.rows || [];
				const aggregates = config.aggregates || [];
				return rows.length > 0 && aggregates.length > 0;
				// TODO: CRM-55358. Remove previous check and unconnect the following code.
				// const hasRows = (config.rows || []).length > 0;
				// const hasColumns = (config.columns || []).length > 0;
				// const hasAggregates = (config.aggregates || []).length > 0;
				// return hasAggregates && (hasRows || hasColumns);
			},

			/**
			 * Returns true when pivot table is enabled.
			 * Check features and browsers.
			 */
			isEnabledPivotTable: function() {
				const isAvailableBrowser = !Ext.isIEOrEdge;
				const isPivotTableFeatureEnabled = Terrasoft.Features.getIsEnabled("PivotTable");
				// TODO. CRM-52673 Oracle 12+
				const isEnabledOffsetFetch = Terrasoft.useOffsetFetchPaging;
				return isAvailableBrowser && isPivotTableFeatureEnabled && isEnabledOffsetFetch;
			},

			/**
			 * Returns pivot table designer diff configuration.
			 */
			getPivotTableDesignerViewConfig: function() {
				const isEnabledPivotTable = Terrasoft.PivotTableUtilities.isEnabledPivotTable();
				return isEnabledPivotTable
					? {
						"itemType": Terrasoft.ViewItemType.COMPONENT,
						"className": "Terrasoft.PivotTableDesigner",
						"options": {"bindTo": "PivotTableDesignerOptions"},
						"optionsChanged": {"bindTo": "onPivotTableOptionsChanged"}
					}
					: {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					};
			}
		},

		/**
		 * Generates default pivot table configuration.
		 * @protected
		 * @returns {Object} Default pivot table config.
		 */
		getDefaultPivotTableConfig: function() {
			return {
				rows: [],
				columns: [],
				aggregates: []
			}
		},

		/**
		 * Returns pivot table view options.
		 * @protected
		 * @param {Object} gridConfig Dashboard widget grid config.
		 */
		getPivotViewOptions: function(gridConfig) {
			gridConfig = gridConfig || {};
			const gridColumnsConfigs = gridConfig.items || [];
			const fieldsOptions = this._getPivotFieldsOptions(gridColumnsConfigs);
			return {
				fieldsOptions: fieldsOptions
			};
		},

		/**
		 * @private
		 */
		_getPivotFieldsOptions: function(gridColumnsConfigs) {
			return Terrasoft.map(gridColumnsConfigs, function(columnConfig) {
				return { 
					fieldId: columnConfig.bindTo, 
					fieldCaption: columnConfig.caption,
					fieldType: columnConfig.dataValueType
				};
			});
		},
	});
	return Ext.create("Terrasoft.PivotTableUtilities");
});
