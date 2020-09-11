define("LeadSectionV2", ["LeadSectionV2Resources", "terrasoft", "ControlGridModule", "BaseProgressBarModule",
			"EntityHelper", "LeadManagementUtilities", "css!BaseProgressBarModule",
			"css!LeadQualificationModuleStyles"],
		function(resources, Terrasoft) {
			return {
				entitySchemaName: "Lead",
				attributes: {
					"UseProcessLeadManagement": {
						type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: Terrasoft.DataValueType.BOOLEAN
					},
					/**
					 * Caption of the Qualification button.
					 */
					"QualificationProcessButtonCaption": {
						type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
						dataValueType: Terrasoft.DataValueType.TEXT
					}
				},
				mixins: {
					EntityHelper: "Terrasoft.EntityHelper",
					LeadManagementUtilities: "Terrasoft.LeadManagementUtilities"
				},
				messages: {
					/**
					 * @message GetBackHistoryState
					 * Gets history point that will be reached when "Close" button in the "Needs" window will be clicked.
					 */
					"GetBackHistoryState": {
						mode: Terrasoft.MessageMode.PTP,
						direction: Terrasoft.MessageDirectionType.SUBSCRIBE
					}
				},
				methods: {
					/**
					 * Initiates starter model values
					 * @overridden
					 * @param {Function} callback Call back function.
					 */
					init: function(callback) {
						this.callParent([function() {
							this.initLeadManagement(callback, this);
						}, this]);
						var initialHistoryState = this.sandbox.publish("GetHistoryState").hash.historyState;
						this.set("InitialHistoryState", initialHistoryState);
					},

					/**
					 * Subscribe on sandbox events
					 * @protected
					 * @overriden
					 */
					subscribeSandboxEvents: function() {
						this.callParent();
						this.sandbox.subscribe("GetBackHistoryState", function() {
							return this.get("InitialHistoryState");
						}, this, ["LeadTypeSectionV2"]);
						var cardModuleSandboxId = this.getCardModuleSandboxId();
						this.sandbox.subscribe("EntityInitialized", function(entityInfo) {
							var activeRow = this.getActiveRow();
							if (activeRow) {
								activeRow.set("QualifyStatus", entityInfo.QualifyStatus);
							}
							this.initLeadManagementControls();
						}, this, [cardModuleSandboxId]);
					},

					/**
					 * Returns section actions collection.
					 * Adds "Set up customer needs" action.
					 * @protected
					 * @overridden
					 * @return {Terrasoft.BaseViewModelCollection} Returns actions collection.
					 */
					getSectionActions: function() {
						var actionMenuItems = this.callParent(arguments);
						actionMenuItems.addItem(this.getButtonMenuItem({
							"Type": "Terrasoft.MenuSeparator"
						}));
						actionMenuItems.addItem(this.getButtonMenuItem({
							"Caption": {"bindTo": "Resources.Strings.ConfigureLeadTypes"},
							"Enabled": true,
							"Click": {"bindTo": "navigateToLeadTypeSection"}
						}));
						return actionMenuItems;
					},

					/**
					 * Navigates to Lead type section.
					 * @protected
					 */
					navigateToLeadTypeSection: function() {
						this.sandbox.publish("PushHistoryState", {
							hash: "SectionModuleV2/LeadTypeSectionV2"
						});
					},

					/**
					 * @inheritdoc Terrasoft.GridUtilitiesV2#getGridDataColumns
					 * @overridden
					 */
					getGridDataColumns: function() {
						var gridDataColumns = this.callParent(arguments);
						gridDataColumns.QualifyStatus = gridDataColumns.QualifyStatus || {path: "QualifyStatus"};
						gridDataColumns.QualificationProcessId =
								gridDataColumns.QualificationProcessId || {path: "QualificationProcessId"};
						gridDataColumns["QualifyStatus.StageNumber"] =
								gridDataColumns["QualifyStatus.StageNumber"] || {path: "QualifyStatus.StageNumber"};
						return gridDataColumns;
					},

					/**
					 * @inheritdoc Terrasoft.BaseSectionV2#onActiveRowAction
					 * @overridden
					 */
					onActiveRowAction: function(buttonTag) {
						if (buttonTag === "onLeadManagementSectionButtonClick") {
							this.onLeadManagementSectionButtonClick();
						} else {
							this.callParent(arguments);
						}
					},

					/**
					 * @inheritdoc Terrasoft.LeadManagementUtilities#leadManagementProcessCallback
					 * @overridden
					 */
					leadManagementProcessCallback: function() {
						this.mixins.LeadManagementUtilities.leadManagementProcessCallback.call(this, arguments);
						this.hideBodyMask();
						this.reloadActiveRow();
					},

					/**
					 * Refresh entity columns of active row.
					 * @protected
					 */
					reloadActiveRow: function() {
						var activeRow = this.getActiveRow();
						if (activeRow) {
							var entityColumns = this.getEntityColumns(activeRow);
							var gridColumns = _.keys(this.getGridDataColumns());
							var columns = entityColumns.concat(gridColumns);
							columns = _.uniq(columns);
							this.refreshColumns(columns, this.Ext.emptyFn, activeRow, {silent: false});
						}
					},

					/**
					 * Get the viewModel's columns that belongs to entity.
					 * @protected
					 * @param {Object} activeRow The active row of the section.
					 * @return {Array}
					 */
					getEntityColumns: function(activeRow) {
						var result = [];
						Terrasoft.each(activeRow.columns, function(item, key) {
							if (item.type === Terrasoft.ViewModelColumnType.ENTITY_COLUMN) {
								result.push(key);
							}
						});
						return result;
					},

					/**
					 * @inheritdoc Terrasoft.LeadManagementUtilities#getQualifyStatus
					 * @overridden
					 */
					getQualifyStatus: function(id) {
						var activeRow;
						if (id) {
							var gridData = this.getGridData();
							activeRow = gridData.get(id);
						} else {
							activeRow = this.getActiveRow();
						}
						if (!activeRow) {
							return null;
						}
						var qualifyStatus = activeRow.get("QualifyStatus");
						return (qualifyStatus) ? qualifyStatus.value : null;
					},

					/**
					 * @inheritdoc Terrasoft.LeadManagementUtilities#initLeadManagementControls
					 * @overridden
					 */
					initLeadManagementControls: function(entity) {
						if (this.get("IsCardVisible")) {
							this.mixins.LeadManagementUtilities.initLeadManagementControls.call(this);
						} else {
							this.initLeadManagementButtonCaption(entity);
							this.initLeadManagementButtonVisibility(entity);
							this.initDisqalificationButtonVisibility();
						}
					},

					/**
					 * @inheritdoc Terrasoft.GridUtilitiesV2#addColumnLink
					 * @overridden
					 */
					addColumnLink: function(item) {
						var self = this;
						item.getQualificationProcessButtonCaption = function() {
							self.initLeadManagementButtonCaption.call(self, item);
							return self.get("QualificationProcessButtonCaption");
						};
						item.getIsQualificationStageActive = function() {
							self.initLeadManagementButtonVisibility.call(self, item);
							return self.get("LeadManagementButtonVisible");
						};
						item.getQualifyStatusValue = function(qualifyStatus) {
							if (!qualifyStatus) {
								return null;
							} else {
								return {
									value: qualifyStatus && qualifyStatus.StageNumber || this.get("QualifyStatus.StageNumber"),
									displayValue: qualifyStatus.displayValue
								};
							}
						};
						return this.callParent(arguments);
					},

					/**
					 * @inheritDoc Terrasoft.GridUtilitiesV2#onActiveRowChange
					 * @overridden
					 */
					onActiveRowChange: function() {
						this.initLeadManagementControls();
						this.callParent(arguments);
					},

					/**
					 * Passes indicator config by reference.
					 * @param {Object} control Configuration object.
					 * @overridden
					 */
					applyControlConfig: function(control) {
						control.config = {
							className: "Terrasoft.BaseProgressBar",
							value: {
								"bindTo": "QualifyStatus",
								"bindConfig": {"converter": "getQualifyStatusValue"}
							},
							width: "158px"
						};
					}
				},
				diff: /**SCHEMA_DIFF*/[
					{
						"operation": "merge",
						"name": "DataGrid",
						"values": {
							"className": "Terrasoft.ControlGrid",
							"controlColumnName": "QualifyStatus",
							"applyControlConfig": {"bindTo": "applyControlConfig"}
						}
					},
					{
						"operation": "merge",
						"name": "DataGridActiveRowDeleteAction",
						"values": {
							"visible": true
						}
					},
					{
						"operation": "insert",
						"name": "QualificationProcessButton",
						"parentName": "CombinedModeActionButtonsCardLeftContainer",
						"propertyName": "items",
						"values": {
							"itemType": Terrasoft.ViewItemType.BUTTON,
							"style": Terrasoft.controls.ButtonEnums.style.GREEN,
							"caption": {"bindTo": "QualificationProcessButtonCaption"},
							"markerValue": {"bindTo": "QualificationProcessButtonCaption"},
							"click": {"bindTo": "onLeadManagementSectionButtonClick"},
							"classes": {"wrapperClass": ["actions-button-margin-right"]},
							"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
							"imageConfig": resources.localizableImages.QualificationProcessButtonImage,
							"visible": {"bindTo": "LeadManagementButtonVisible"}
						}
					},
					{
						"operation": "insert",
						"name": "DataGridActiveRowQualificationProcessAction",
						"parentName": "DataGrid",
						"propertyName": "activeRowActions",
						"values": {
							"className": "Terrasoft.Button",
							"style": Terrasoft.controls.ButtonEnums.style.GREEN,
							"caption": {"bindTo": "getQualificationProcessButtonCaption"},
							"tag": "onLeadManagementSectionButtonClick",
							"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
							"imageConfig": resources.localizableImages.QualificationProcessActionImage,
							"visible": {"bindTo": "getIsQualificationStageActive"}
						}
					}
				]/**SCHEMA_DIFF*/
			};
		});
