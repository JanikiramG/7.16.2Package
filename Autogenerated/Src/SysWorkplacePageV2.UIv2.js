define("SysWorkplacePageV2", ["SectionServiceMixin"],
	function() {
		return {
			entitySchemaName: "SysWorkplace",
			messages: {
				/**
				 * @message UpdateWorkplaceType
				 * Calls workplace type update for page and detail.
				 */
				"UpdateWorkplaceType": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.BIDIRECTIONAL
				}
			},
			mixins: {
				/**
				 * @class SectionServiceMixin
				 * Section service mixin.
				 */
				SectionServiceMixin: Terrasoft.SectionServiceMixin
			},

			attributes: {
				/**
				 * Sign that current workplace is portal.
				 */
				"IsCurrentWorkplaceSSP": {
					dataValue: this.Terrasoft.DataValueType.BOOLEAN
				},

				/**
				 * Section types enum.
				 * @protected
				 */
				"SectionTypes": {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT
				},

				/**
				 * Workplace type.
				 */
				"Type": {
					"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"lookupListConfig": {
						"columns": ["Code"]
					}
				}
			},

			details: /**SCHEMA_DETAILS*/{
				SysAdminUnit: {
					schemaName: "SysAdminUnitInWorkplaceDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "SysWorkplace"
					},
					defaultValues: {
						SysWorkplace: {
							masterColumn: "Id"
						}
					}
				},
				SysModule: {
					schemaName: "SysModuleInWorkplaceDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "SysWorkplace"
					},
					defaultValues: {
						SysWorkplace: {
							masterColumn: "Id"
						},
						IsCurrentWorkplaceSSP: {
							masterColumn: "IsCurrentWorkplaceSSP"
						},
						SectionTypes: {
							masterColumn: "SectionTypes"
						}
					}
				}
			}/**SCHEMA_DETAILS*/,
			methods: {

				//region Methods: Private

				/**
				 * Updates card state after workplace saved using workplace API.
				 * @private
				 * @param {Object} result Save workplace result.
				 */
				_updateCardState: function(result) {
					var workplaceId = result.CreateWorkplaceResult;
					this.$Id = workplaceId;
					this.$PrimaryColumnValue = workplaceId;
					this.isNew = false;
					this.updateDetails();
				},

				/**
				 * Set workplace type from defaultValues.
				 * @private
				 */
				_applyWorkplaceTypeValues: function() {
					if (this.getIsFeatureDisabled("UseTypedWorkplaces")) {
						return;
					}
					var type = this.getDefaultValueByName("Type");
					var code =  this.getDefaultValueByName("Code");
					this.$Type = type ? {value: type} : this.$Type;
					this.$TypeCode = Terrasoft.isNotEmpty(code) ? code : this.$TypeCode;
				},

				//endregion

				//region Methods: Protected

				/**
				 * ############## ####### ######### ########
				 * @protected
				 */
				initHeaderCaption: function() {
					var caption = this.get("Resources.Strings.HeaderCaption");
					this.set("NewRecordPageCaption", caption);
				},

				/**
				 * ########## ###### ######### ######## ########
				 * @override
				 * @return {Terrasoft.BaseViewModelCollection} ########## ######### ######## ########
				 */
				getActions: function() {
					var actionMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					return actionMenuItems;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([
						function() {
							this._applyWorkplaceTypeValues();
							this.initSectionTypes(callback, scope);
						}, this
					]);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#subscribeSandboxEvents
				 * @overridden
				 */
				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("UpdateWorkplaceType", this.updateWorkplaceType, this);
				},

				/**
				 * Updates workplace type for page and section.
				 * @protected.
				 */
				updateWorkplaceType: function() {
					this.initCurrentWorkspaceType(this.$SectionTypes, function() {
						var detailId = this.getDetailId("SysModule");
						this.sandbox.publish("UpdateWorkplaceType", this.$IsCurrentWorkplaceSSP, [detailId]);
					}, this);
				},

				/**
				 * @inheritDoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					if (this.getIsFeatureEnabled("UseTypedWorkplaces") && this.isEditMode()) {
						this.$TypeCode = this.$Type && this.$Type.Code;
						this.initCurrentWorkspaceType();
					}
				},

				/**
				 * Sets "SectionTypes" attribute.
				 * @overridden
				 * @param {Object} result Section types enum (values: "General" or "SSP").
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				processedSectionTypes: function(result, callback, scope) {
					var sectionTypes = JSON.parse(result.GetSectionTypesResult);
					this.$SectionTypes = sectionTypes;
					this.initCurrentWorkspaceType(sectionTypes, callback, scope);
				},

				/**
				 * Initializes "IsCurrentWorkplaceSSP" attribute.
				 * @protected
				 * @param {Object} sectionTypes Section types enum (values: "General" or "SSP").
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				initCurrentWorkspaceType: function(sectionTypes, callback, scope) {
					if (this.getIsFeatureEnabled("UseTypedWorkplaces") && !this.Terrasoft.isNull(this.$TypeCode)) {
						this.$IsCurrentWorkplaceSSP = Boolean(this.$TypeCode);
						this.Ext.callback(callback, scope || this);
						return;
					}
					var config = {
						data: {
							"type": sectionTypes.SSP
						},
						serviceName: "WorkplaceService",
						methodName: "GetWorkplacesByType"
					};
					this.callService(config, function(result) {
						var workplacesByType = result.GetWorkplacesByTypeResult;
						if (workplacesByType) {
							var currentWorkplaceSSP = Ext.Array.findBy(workplacesByType, function(item) {
								return JSON.parse(item).Id === this.$PrimaryColumnValue;
							}, this);
							this.$IsCurrentWorkplaceSSP = !Ext.isEmpty(currentWorkplaceSSP);
						}
						this.Ext.callback(callback, scope || this);
					}, this);
				},

				/**
				 * @inheritdoc Terrasoft.BaseEntityPage#save
				 * @override
				 */
				save: function(config) {
					if (this.getIsFeatureDisabled("SspSectionWizard") || !this.isAddMode()) {
						this.callParent(arguments);
						return;
					}
					this.saveUsingApi(config);
				},

				/**
				 * Saves new workplace using workplace API.
				 * @protected
				 * @param {Object} config Save card config.
				 */
				saveUsingApi: function(config) {
					var sectionTypes = this.$SectionTypes || {};
					var serviceConfig = {
						data: {
							"name": this.$Name,
							"type": this.getIsFeatureEnabled("UseTypedWorkplaces") ? this.$TypeCode : sectionTypes.GENERAL
						},
						serviceName: "WorkplaceService",
						methodName: "CreateWorkplace"
					};
					this.callService(serviceConfig, function(result) {
						this._updateCardState(result);
						this.Terrasoft.chain(this.saveDetailsInChain, function() {
							this.onSaved({success: true}, config);
						}, this);
					}, this);
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "Header",
					"propertyName": "items",
					"name": "Name",
					"values": {
						"bindTo": "Name",
						"layout": {"column": 0, "row": 0, "colSpan": 23}
					}
				}, {
					"operation": "insert",
					"name": "SettingsTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"values": {
						"caption": {bindTo: "Resources.Strings.SettingsTabCaption"},
						"items": []
					}
				}, {
					"operation": "insert",
					"parentName": "SettingsTab",
					"propertyName": "items",
					"name": "SysModule",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}, {
					"operation": "insert",
					"parentName": "SettingsTab",
					"propertyName": "items",
					"name": "SysAdminUnit",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}, {
					"operation": "remove",
					"name": "ViewOptionsButton"
				}
			]/**SCHEMA_DIFF*/
		};
	});
