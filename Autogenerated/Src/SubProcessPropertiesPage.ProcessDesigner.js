﻿/**
 * Parent: RootUserTaskPropertiesPage
 */
define("SubProcessPropertiesPage", ["SubProcessPropertiesPageResources", "ProcessSchemaUserTaskUtilities",
	"ProcessModuleUtilities", "ProcessSchemaParameterViewConfig"
], function(resources, processSchemaUserTaskUtilities) {
	return {
		properties: {
			/**
			 * @inheritdoc RootUserTaskPropertiesPage.properties#schemaManagerName
			 * @override
			 */
			schemaManagerName: "ProcessSchemaManager",

			/**
			 * @inheritdoc RootUserTaskPropertiesPage.properties#useNotification
			 * @override
			 */
			useNotification: true,

			/**
			 * @private
			 */
			_schemaListRequestId: null
		},
		attributes: {
			"Schema": {
				dataValueType: Terrasoft.DataValueType.LOOKUP,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				referenceSchemaName: "SysSchema",
				isRequired: true
			},
			"SubProcessInstance": {
				dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
				type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		methods: {

			/**
			 * @inheritdoc ProcessSchemaElementEditable#onElementDataLoad
			 * @override
			 */
			onElementDataLoad: function(element, callback, scope) {
				const parentMethod = this.getParentMethod();
				Terrasoft.chain(
					function(next) {
						this.getSubProcessSchemaInstance(element.schemaUId, next, this);
					},
					function(next, subProcess) {
						if (!subProcess) {
							element.setPropertyValue("schemaUId", null);
						}
						this.set("SubProcessInstance", subProcess);
						parentMethod.call(this, element, next, this);
					},
					function(next) {
						this.initSchema(element, next, this);
					},
					function() {
						this.initBaseParameters(element);
						callback.call(scope);
					}, this
				);
			},

			/**
			 * Returns schema object by identifier.
			 * @private
			 * @param {String} schemaUId Schema identifier.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope Execution context.
			 */
			getSchemaByUId: function(schemaUId, callback, scope) {
				Terrasoft.ProcessModuleUtilities.loadSchemaDisplayValue(schemaUId, function(displayValue) {
					const schema = {
						value: schemaUId,
						displayValue: displayValue
					};
					callback.call(scope, schema);
				}, this);
			},

			/**
			 * Synchronizes sub-process element parameters with actual version schema.
			 * @protected
			 * @param {Terrasoft.manager.ProcessSubprocessSchema} element Sub-process element.
			 * @param {Object} actualSchema Actual version schema value.
			 */
			synchronizeActualSchemaParameters: function(element, actualSchema) {
				const links = this.findLinksToElements(element);
				element.resetParameters(function() {
					const parameters = element.parameters.clone();
					element.synchronizeParameters(actualSchema);
					if (!parameters) {
						return;
					}
					parameters.each(function(parameter) {
						const newParameter = element.findParameterByNameOrByUId(parameter.name, parameter.uId);
						this.synchronizeSchemaParameter(element, newParameter, parameter);
					}, this);
				}, this);
				this.initBaseParameters(element);
				this.invalidateDependentElements(links);
			},

			/**
			 * Finds elements that are linked with the schema element.
			 * @protected
			 * @param {Terrasoft.manager.ProcessSubprocessSchema} element Sub-process element.
			 * @return {Array}.
			 */
			findLinksToElements: function(element) {
				return element.parentSchema.findLinksToElements([element.name]);
			},

			/**
			 * Initializes schema.
			 * @protected
			 * @param {Terrasoft.manager.ProcessSubprocessSchema} element Process element.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope The scope of callback function.
			 */
			initSchema: function(element, callback, scope) {
				this.on("change:Schema", this.onBeforeSchemaChanged, this);
				const schemaUId = element.schemaUId;
				if (Terrasoft.isEmpty(schemaUId)) {
					callback.call(scope);
					return;
				}
				const subProcess = this.get("SubProcessInstance");
				this.getSchemaByUId(subProcess.uId, function(schema) {
					this.set("Schema", schema, {silent: true});
					if (schemaUId !== subProcess.uId) {
						element.setPropertyValue("schemaUId", subProcess.uId);
					}
					this.synchronizeActualSchemaParameters(element, subProcess);
					callback.call(scope);
				}, this);
			},

			/**
			 * Returns schema list filter.
			 * @protected
			 * @param {Function} callback The callback function.
			 * @param {Object} callback.filter Schemas filter.
			 */
			getSchemaListFilter: function(callback) {
				const element = this.get("ProcessElement");
				const schema = this.get("Schema") || {};
				const parentSchema = element.parentSchema;
				const excludedSchemaUId = schema.value;
				let filter = {
					PackageUId: Terrasoft.formatGUID(parentSchema.packageUId, "B"),
					EnabledOnly: false,
					ExcludedSchemas: [Terrasoft.formatGUID(parentSchema.uId, "B")]
				};
				filter = Ext.apply(filter, element.schemaFilter);
				if (excludedSchemaUId) {
					filter.ExcludedSchemas.push(Terrasoft.formatGUID(excludedSchemaUId, "B"));
				}
				callback(filter);
			},

			/**
			 * Returns list of sub-process schemas.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			getSchemaList: function(callback, scope) {
				scope = scope || this;
				Terrasoft.AjaxProvider.abortRequestByInstanceId(this._schemaListRequestId);
				this.getSchemaListFilter(function(filter) {
					const request = Terrasoft.ProcessModuleUtilities.getActualProcessSchemasByFilter(filter, callback, scope);
					this._schemaListRequestId = request.instanceId;
				}.bind(this));
			},

			/**
			 * The event handler for preparing element schemas drop-down list.
			 * @private
			 * @param {Object} filter Filters for data preparation.
			 * @param {Terrasoft.Collection} list The data for the drop-down list.
			 */
			onPrepareSchemaList: function(filter, list) {
				if (Terrasoft.isEmptyObject(list)) {
					return;
				}
				list.clear();
				this.getSchemaList(function(schemas) {
					list.loadAll(schemas);
				}, this);
			},

			/**
			 * @inheritdoc RootUserTaskPropertiesPage#onBeforeSchemaChanged.
			 * @override
			 */
			onBeforeSchemaChanged: function(model, newSchema) {
				const element = this.get("ProcessElement");
				const oldSchemaUId = element.schemaUId;
				const newSchemaUId = newSchema ? newSchema.value : "";
				if (!newSchemaUId || (oldSchemaUId === newSchemaUId)) {
					return;
				}
				if (Terrasoft.isEmpty(oldSchemaUId)) {
					this.onAfterSchemaChanged();
					return;
				}
				this.getSchemaByUId(oldSchemaUId, function(oldSchema) {
					this.canChangeSchema(function(canChange) {
						if (canChange) {
							this.confirmSchemaChange(oldSchema);
						} else {
							this.set("Schema", oldSchema);
						}
					}, this);
				}, this);
			},

			/**
			 * Sets default element caption by schema display value.
			 * @param {Terrasoft.manager.ProcessBaseElementSchema} element Process element.
			 * @param {Object} schema Schema value.
			 */
			setElementCaptionBySchema: function(element, schema) {
				let newCaption;
				if (Terrasoft.isEmptyGUID(element.schemaUId) || !schema) {
					newCaption = element.defaultCaption;
				} else {
					newCaption = schema.displayValue;
				}
				const filterFn = function(item, caption) {
					const sameElement = item.uId === element.uId;
					return sameElement ? false : String(item.caption) === caption;
				};
				const utilities = processSchemaUserTaskUtilities;
				const elements = element.parentSchema.flowElements;
				newCaption = utilities.generateItemUniqueName(newCaption + " ", elements, filterFn);
				this.set("caption", newCaption);
				element.setLocalizableStringPropertyValue("caption", newCaption);
			},

			/**
			 * Initializes specified process schema parameters.
			 * @private
			 * @param {Terrasoft.ProcessBaseElementSchema} element Process element.
			 * @param {Terrasoft.ProcessSchema} schema Process schema.
			 */
			initSchemaParameters: function(element, schema) {
				this.synchronizeParameters(element, schema);
				this.initBaseParameters(element);
			},

			/**
			 * @inheritdoc Terrasoft.RootUserTaskPropertiesPage#synchronizeSchemaParameters
			 * @override
			 */
			synchronizeSchemaParameters: function(callback, scope) {
				const maskId = this._showParametersLoadMask();
				Terrasoft.chain(
					function(next) {
						this.getSubProcessSchemaInstance(this.$Schema.value, next, this);
					},
					function(next, subProcess) {
						this.set("SubProcessInstance", subProcess);
						this.synchronizeActualSchemaParameters(this.$ProcessElement, subProcess);
						this.initElementProperty(subProcess, next, this);
						Terrasoft.Mask.hide(maskId);
						Ext.callback(callback, scope);
					},
					this
				);
			},

			/**
			 * @private
			 */
			_showParametersLoadMask: function() {
				const config = {
					selector: ".sub-process-parameters-container",
					timeout: 0
				};
				return Terrasoft.Mask.show(config);
			},

			/**
			 * @inheritdoc Terrasoft.RootUserTaskPropertiesPage#onAfterSchemaCnahged
			 * @override
			 */
			onAfterSchemaChanged: function() {
				this.callParent(arguments);
				const schema = this.get("Schema");
				const schemaUId = schema ? schema.value : Terrasoft.GUID_EMPTY;
				const element = this.get("ProcessElement");
				element.setPropertyValue("schemaUId", schemaUId);
				if (Terrasoft.isEmpty(schemaUId)) {
					this.initSchemaParameters(element, null);
				} else {
					Terrasoft.chain(
						function(next) {
							this.getSubProcessSchemaInstance(schemaUId, next, this);
						},
						function(next, subProcess) {
							this.set("SubProcessInstance", subProcess);
							this.initSchemaParameters(element, subProcess);
							this.initElementProperty(subProcess, next, this);
						}, this
					);
				}
				this.setElementCaptionBySchema(element, schema);
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#initIsSerializeToDBEnabled
			 * @override
			 */
			initIsSerializeToDBEnabled: function(element, callback, scope) {
				const subProcess = this.get("SubProcessInstance");
				if (subProcess) {
					this.set("IsSerializeToDBEnabled", !subProcess.serializeToDB);
				}
				callback.call(scope);
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#initIsSerializeToDB
			 * @override
			 */
			initIsSerializeToDB: function(element) {
				const subProcess = this.get("SubProcessInstance");
				const isSerializeToDB = subProcess && subProcess.serializeToDB || element.serializeToDB;
				this.set("serializeToDB", isSerializeToDB);
			},

			/**
			 * Get schema instance by uid.
			 * @protected
			 * @param {String} schemaUId Schema identifier.
			 * @param {Function} callback The callback function.
			 * @param {Object} scope The scope of callback function.
			 */
			getSubProcessSchemaInstance: function(schemaUId, callback, scope) {
				Terrasoft.ProcessSchemaManager.getActualVersionUId(schemaUId, function(result) {
					const actualSchemaUId = result && result.actualVersionSchemaUId;
					Terrasoft.ProcessSchemaManager.getSubProcessSchemaInstanceByUId(actualSchemaUId, callback, scope);
				}, this);
			},

			/**
			 * Synchronize element parameters with schema.
			 * @protected
			 * @param {Terrasoft.manager.ProcessSubprocessSchema} element Process element.
			 * @param {Terrasoft.UserTaskSchema|null} schema New schema.
			 */
			synchronizeParameters: function(element, schema) {
				if (schema === null) {
					element.clearParamters();
				} else {
					element.synchronizeParameters(schema);
				}
			},

			/**
			 * Handles open schema designer click. Opens schema designer in new window.
			 * @protected
			 */
			onOpenSchemaDesignerButtonClick: function() {
				const schema = this.get("Schema");
				const schemaUId = schema && schema.value;
				this.$IsAddSchemaButtonClicked = Ext.isEmpty(schemaUId);
				if (schemaUId) {
					Terrasoft.ProcessSchemaManager.getActualVersionUId(schemaUId, function(result) {
						Terrasoft.ProcessModuleUtilities.showProcessSchemaDesigner(result.actualVersionSchemaUId);
					}, this);
				} else {
					Terrasoft.ProcessModuleUtilities.showProcessSchemaDesigner(schemaUId);
				}
			},

			/**
			 * Returns Open/Add process designer button image config.
			 * @protected
			 * @param {Object} processSchema Process schema.
			 * @return {Object}
			 */
			getOpenProcessSchemaDesignerButtonImageConfig: function(processSchema) {
				if (processSchema) {
					return this.get("Resources.Images.OpenButtonImage");
				} else {
					return this.get("Resources.Images.AddButtonImage32");
				}
			},

			/**
			 * Returns flag indicating that the parameters label is visible.
			 * @return {Boolean}
			 */
			getIsParametersLabelVisible: function() {
				return !!this.get("Schema");
			},

			/**
			 * Returns flag indicating that the empty message is visible.
			 * @return {Boolean}
			 */
			getIsEmptyMessageVisible: function() {
				return !!this.get("Schema") && this.get("IsEmptyParameters");
			},

			/**
			 * Returns Open/Add process designer button hint.
			 * @protected
			 * @param {Object} processSchema Process schema.
			 * @return {Object}
			 */
			getOpenProcessSchemaDesignerButtonHint: function(processSchema) {
				if (processSchema) {
					return this.get("Resources.Strings.OpenSchemaButtonHintCaption");
				} else {
					return this.get("Resources.Strings.AddSchemaButtonHintCaption");
				}
			},

			/**
			 * Reverts value of attribute Schema if empty.
			 * @private
			 */
			revertSchemaAttribute: function() {
				if (this.get("Schema")) {
					return;
				}
				const element = this.get("ProcessElement");
				const schemaUId = element.schemaUId;
				if (!Terrasoft.isEmpty(schemaUId)) {
					this.set("Schema", {
						value: schemaUId,
						displayValue: ""
					});
					this.getSchemaByUId(schemaUId, function(schema) {
						this.set("Schema", schema);
					}, this);
				}
			},

			/**
			 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
			 * @override
			 */
			saveValues: function() {
				this.callParent(arguments);
				this.revertSchemaAttribute();
			},

			/**
			 * @inheritdoc RootUserTaskPropertiesPage#getSchema
			 * @override
			 */
			getSchema: function() {
				return this.get("Schema");
			},

			/**
			 * @inheritdoc RootUserTaskPropertiesPage#getSchema
			 * @override
			 */
			setSchema: function(schema, options) {
				return this.set("Schema", schema, options);
			},

			/**
			 * @deprecated
			 */
			getSchemaActualVersionUId: function(element, callback, scope) {
				Terrasoft.ProcessSchemaManager.getActualVersionUId(element.schemaUId, callback, scope);
			},

			/**
			 * @inheritdoc ProcessFlowElementPropertiesPage#getParameterEditToolsButtonEditMenuItem
			 * @override
			 */
			getParameterEditToolsButtonEditMenuItem: function() {
				const itemModel = this.callParent(arguments);
				itemModel.set("Tag", {"containerId": "sub-process-item-edit"});
				return itemModel;
			},

			/**
			 * Determines whether the schema element can be used in background processes.
			 * @return {Boolean} True, if functionality is enabled; otherwise - False.
			 */
			canUseBackgroundProcessMode: function() {
				return this.callParent(arguments) && this.get("IsMultiInstanceMode");
			},

			/**
			 * @inheritdoc ProcessFlowElementPropertiesPage#getUseBackgroundModeCaption
			 * @override
			 */
			getUseBackgroundModeCaption: function() {
				return resources.localizableStrings.UseBackgroundModeCaption;
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "SubProcessContainer",
				"propertyName": "items",
				"parentName": "EditorsContainer",
				"className": "Terrasoft.GridLayoutEdit",
				"values": {
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"items": []
				}
			},
			{
				"operation": "insert",
				"name": "SchemaLabel",
				"parentName": "SubProcessContainer",
				"propertyName": "items",
				"values": {
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.ProcessSchemaSelectLabelCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					}
				}
			},
			{
				"operation": "insert",
				"name": "Schema",
				"parentName": "SubProcessContainer",
				"propertyName": "items",
				"values": {
					"caption": {"bindTo": "Resources.Strings.SchemaCaption"},
					"layout": {
						"column": 0,
						"row": 1,
						"colSpan": 22
					},
					"labelConfig": {
						"visible": false
					},
					"contentType": Terrasoft.ContentType.ENUM,
					"controlConfig": {
						"prepareList": {"bindTo": "onPrepareSchemaList"},
						"filterComparisonType": Terrasoft.StringFilterType.CONTAIN
					},
					"wrapClass": ["top-caption-control", "no-caption-control"]
				}
			},
			{
				"operation": "insert",
				"name": "OpenSchemaDesignerButton",
				"parentName": "SubProcessContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.BUTTON,
					"hint": {
						"bindTo": "Schema",
						"bindConfig": {
							"converter": "getOpenProcessSchemaDesignerButtonHint"
						}
					},
					"imageConfig": {
						"bindTo": "Schema",
						"bindConfig": {
							"converter": "getOpenProcessSchemaDesignerButtonImageConfig"
						}
					},
					"classes": {
						"wrapperClass": ["open-schema-designer-tool-button"]
					},
					"click": {"bindTo": "onOpenSchemaDesignerButtonClick"},
					"layout": {
						"column": 22,
						"row": 1,
						"colSpan": 2
					}
				}
			},
			{
				"operation": "move",
				"name": "MultiInstanceExecutionModeConfig",
				"parentName": "SubProcessContainer",
				"propertyName": "items",
				"values": {
					"contentType": Terrasoft.ContentType.ENUM,
					"visible": {
						"bindTo": "IsMultiInstanceMode"
					},
					"classes": {
						"wrapClassName": ["multi-instance-property-container"],
						"labelClass": ["t-title-label-proc"]
					},
					"controlConfig": {
						"className": "Terrasoft.ComboBoxEdit",
						"prepareList": {
							"bindTo": "prepareMultiInstanceExecutionModeList"
						},
						"list": {"bindTo": "MultiInstanceExecutionModeList"},
						"change": {"bindTo": "onMultiInstanceExecutionModeChange"}
					},
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "SubProcessContainer",
				"name": "SubProcessParametersContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.CONTAINER,
					"items": [],
					"layout": {
						"column": 0,
						"row": 3,
						"colSpan": 24
					}
				}
			},
			{
				"operation": "insert",
				"name": "ProcessParametersLabel",
				"parentName": "SubProcessParametersContainer",
				"propertyName": "items",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.ProcessParametersCaption"
					},
					"classes": {
						"labelClass": ["t-title-label-proc"]
					},
					"visible": {
						"bindTo": "getIsParametersLabelVisible"
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "SubProcessParametersContainer",
				"propertyName": "items",
				"name": "EmptyParametersMessage",
				"values": {
					"itemType": Terrasoft.ViewItemType.LABEL,
					"caption": {
						"bindTo": "Resources.Strings.SubProcessEmptyParametersMessage"
					},
					"visible": {
						"bindTo": "getIsEmptyMessageVisible"
					},
					"classes": {
						"labelClass": ["empty-parameters"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "SubProcessParametersContainer",
				"propertyName": "items",
				"name": "SubProcessParameterList",
				"values": {
					"generator": "ConfigurationItemGenerator.generateHierarchicalContainerList",
					"idProperty": "Id",
					"onItemClick": {
						"bindTo": "onItemClick"
					},
					"collection": "Parameters",
					"nestedItemsAttributeName": "ItemProperties",
					"nestedItemsContainerId": "nested-parameters",
					"defaultItemConfig": {},
					"classes": {
						"wrapClassName": ["sub-process-parameters-container"]
					},
					"rowCssSelector": ".paramContainer"
				}
			},
			{
				"operation": "insert",
				"parentName": "SubProcessParameterList",
				"propertyName": "defaultItemConfig",
				"name": "parameterItem",
				"values": Terrasoft.ProcessSchemaParameterViewConfig.generate("sub-process-")
			},
			{
				"operation": "merge",
				"name": "EditorsContainer",
				"values": {
					"classes": {
						"wrapClassName": ["tabs", "editors-ct", "header-container-margin-bottom"]
					}
				}
			},
			{
				"operation": "insert",
				"parentName": "EditorsContainer",
				"propertyName": "items",
				"name": "useBackgroundMode",
				"values": {
					"layout": {
						"column": 0,
						"row": 2,
						"colSpan": 24
					},
					"visible": {
						"bindTo": "canUseBackgroundProcessMode"
					},
					"wrapClass": ["t-checkbox-control"]
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
