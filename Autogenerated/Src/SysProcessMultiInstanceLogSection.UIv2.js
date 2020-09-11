define("SysProcessMultiInstanceLogSection", ["ConfigurationEnums", "BaseFiltersGenerateModule", "ConfigurationConstants",
			"ProcessModuleUtilities", "SysProcessLogSectionV2GridRowViewModel", "DcmSchemaManager",
			"css!BaseProcessLogSectionCSS", "ProcessLogActions"],
	function(ConfigurationEnums) {
		return {
			entitySchemaName: "VwSysProcessMILog",
			attributes: {
				"MultiInstanceElementId": {
					dataValueType: this.Terrasoft.DataValueType.GUID,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},
				"ProcessCaption": {
					dataValueType: this.Terrasoft.DataValueType.TEXT,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			messages: {},
			methods: {
				/**
				 * @overridden
				 */
				init: function(callback, scope) {
					const historyState = this.sandbox.publish("GetHistoryState");
					const state = historyState.state;
					const multiInstanceElementId = historyState.hash.recordId;
					this.set("MultiInstanceElementId", multiInstanceElementId);
					this.set("ShowArchivedRecords", true);
					this.set("UseSectionHeaderCaption", true);
					this.callParent([function () {
						this._assignProcessCaption(state.processCaption, multiInstanceElementId, function(caption) {
							this.set("ProcessCaption", caption);
							Ext.callback(callback, scope);
						}, this);
					}, this]);
				},

				/**
				 * @inheritDoc Terrasoft.Configuration.BaseSectionV2#getDefaultDataViews
				 * @overridden
				 */
				getDefaultDataViews: function() {
					const dataViews = this.callParent(arguments);
					delete dataViews.AnalyticsDataView;
					return dataViews;
				},

				/**
				 * @inheritDoc Terrasoft.configuration.mixins.HistoryStateUtilities#getHistoryStateInfo
				 * @overridden
				 */
				getHistoryStateInfo: function() {
					const info = this.callParent(arguments);
					if (info.operation === "view") {
						info.workAreaMode = ConfigurationEnums.WorkAreaMode.SECTION;
					}
					return info;
				},

				_assignProcessCaption: function(stateCaption, multiInstanceElementId, callback, scope) {
					if (stateCaption) {
						Ext.callback(callback, scope, [stateCaption]);
						return;
					}
					const esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "VwSysProcessElementLog"
					});
					esq.addColumn("Caption");
					esq.filters.add("primaryColumnFilter", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Id", multiInstanceElementId));
					esq.execute(function(result) {
						let caption;
						if (result.success && !result.collection.isEmpty()) {
							const row = result.collection.first();
							caption = row.get("Caption");
						}
						Ext.callback(callback, scope, [caption]);
					}, scope);
				},

				/**
				 * Discards chain to previous state.
				 * @private
				 */
				_closeSection: function() {
					this.sandbox.publish("BackHistoryState");
				},

				/**
				 * @inheritDoc Terrasoft.configuration.mixins.GridUtilities#getGridEntitySchema
				 * @overridden
				 */
				getGridEntitySchemaName: function() {
					return "VwSysProcessLog";
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#getEditPages
				 * @overridden
				 */
				initEditPages: function() {
					const entitySchemaName = this.getGridEntitySchemaName();
					const editPages = this.getEditPagesCollectionByName(entitySchemaName);
					this.set("EditPages", editPages);
				},

				/**
				 * @inheritdoc Terrasoft.BaseDataView#getActiveViewCaption
				 * @overridden
				 */
				getActiveViewCaption: function() {
					const parentCaption = this.callParent(arguments);
					return this.get("ProcessCaption")
						? Ext.String.format("{0} {1}", parentCaption, this.get("ProcessCaption"))
						: parentCaption;
				},

				/**
				 * @inheritdoc Terrasoft.SysProcessLogSectionV2#getFilters
				 * @overridden
				 */
				getFilters: function() {
					const filters = this.callParent(arguments);
					this._addMultiInstanceFilter(filters);
					return filters;
				},

				/**
				 * @inheritdoc Terrasoft.BaseDataView#isSeparateModeActionsButtonVisible
				 * @overridden
				 */
				isSeparateModeActionsButtonVisible: function() {
					return false;
				},

				_addMultiInstanceFilter: function(filters) {
					const multiInstanceId = this.get("MultiInstanceElementId") || Terrasoft.GUID_EMPTY;
					filters.add("MultiInstanceFilter", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "IteratorElement", multiInstanceId));
				},

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#removeCardHistoryState
				 * @overridden
				 */
				removeCardHistoryState: Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseDataView#loadCardModule
				 */
				loadCardModule: function() {
					this.sandbox.loadModule("CardModuleV2", {
						renderTo: "CardContainer",
						instanceConfig: {
							isSeparateMode: true,
							isSeparateModeInitialized: true,
							useSeparatedPageHeader: this.get("UseSeparatedPageHeader")
						}
					});
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "CloseButton",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.BLUE,
						"caption": {"bindTo": "Resources.Strings.CloseButtonCaption"},
						"click": {"bindTo": "_closeSection"},
						"visible": true,
						"classes": {"textClass": ["actions-button-margin-right"]},
						"tag": "onCloseClick"
					}
				},
				{
					"operation": "remove",
					"name": "DataGridActiveRowCancelExecution",
					"parentName": "DataGrid",
					"propertyName": "activeRowActions"
				},
				{
					"operation": "remove",
					"name": "HasArchivedFilterContainer",
					"parentName": "FiltersContainer",
					"propertyName": "items"
				},
				{
					"operation": "remove",
					"name": "SeparateModeOpenProcessLibButton",
					"parentName": "SeparateModeActionButtonsLeftContainer",
					"propertyName": "items"
				}
			]/**SCHEMA_DIFF*/
		};
	});
