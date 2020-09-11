define("ForecastMiniPage", ["ForecastMiniPageResources", "ForecastConstants", "ForecastHierarchyItemViewModel",
		"ForecastEntityLookupMixin", "ApplicationStructureWizardUtils", "css!ForecastMiniPageCSS"],
	function(resources, ForecastConstants) {
		return {
			entitySchemaName: "ForecastSheet",
			properties: {
				parentSchemaUId: "3a622ca4-e1ea-4273-8b41-c20129310fd7"
			},
			attributes: {
				/**
				 * @inheritDoc BaseMiniPage#MiniPageModes
				 * @override
				 */
				"MiniPageModes": {
					"value": [
						this.Terrasoft.ConfigurationEnums.CardOperation.ADD,
						this.Terrasoft.ConfigurationEnums.CardOperation.EDIT,
						this.Terrasoft.ConfigurationEnums.CardOperation.COPY
					]
				},
				/**
				 * Forecast entity.
				 */
				"ForecastEntity": {
					"dataValueType": Terrasoft.DataValueType.LOOKUP,
					"isLookup": true,
					"isRequired": true,
					"onChange": "onForecastEntityChanged"
				},

				/**
				 * Hierarchy collection.
				 */
				"HierarchyData": {
					"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Forecast settings config.
				 */
				"Setting": {
					"type": this.Terrasoft.ViewModelColumnType.ENTITY_COLUMN,
					"value": "{}"
				},
				/**
				 * Forecast entity primary display column exist flag.
				 */
				"IsEntityPrimaryDisplayColumnExist": {
					"value": true
				}
			},
			messages: {
				/**
				 * Message of saving forecast result.
				 */
				"SetForecastResult": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},

				/**
				 * @message StructureExplorerInfo
				 * Returns settings for Structure explorer modal box.
				 */
				"StructureExplorerInfo": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message ColumnSelected
				 * Returns selected column config.
				 */
				"ColumnSelected": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE
				},

				/**
				 * @message GetHierarchyCollection
				 * Gets hierarchy collection.
				 */
				"GetHierarchyCollection": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.BIDIRECTIONAL
				},

				/**
				 * @message DeleteHierarchyItem
				 * Delete hierarchy item.
				 */
				"DeleteHierarchyItem": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.BIDIRECTIONAL
				}
			},
			mixins: {
				ForecastEntityLookupMixin: "Terrasoft.ForecastEntityLookupMixin"
			},
			methods: {

				/**
				 * @inheritDoc Terrasoft.BaseMiniPage#init
				 * @override
				 */
				init: function() {
					const collection = new Terrasoft.BaseViewModelCollection();
					collection.on("itemChanged", this.addHierarchy, this);
					this.set("HierarchyData", collection);
					this.callParent(arguments);
					this.subscribeSandboxMessages();
				},

				/**
				 * @inheritDoc Terrasoft.BaseMiniPage#init
				 * @override
				 */
				destroy: function() {
					this.$HierarchyData.un("itemChanged", this.addHierarchy, this);
					this.callParent(arguments);
				},

				/**
				 * @inheritDoc Terrasoft.BaseMiniPage#onPageInitialized
				 * @override
				 */
				onPageInitialized: function(callback, scope) {
					this.callParent([function() {
						this.viewModel.mixins.ForecastEntityLookupMixin.init(callback, scope);
					}, scope || this]);
				},

				/**
				 * Subscribes for sandbox messages.
				 * @protected
				 * @virtual
				 */
				subscribeSandboxMessages: function() {
					this.sandbox.subscribe("GetHierarchyCollection", this.getHierarchyData, this, []);
					this.sandbox.subscribe("DeleteHierarchyItem", this.deleteHierarchyItem, this, []);
				},

				/**
				 * Deletes hierarchy item by id.
				 * @param {String} id Item id.
				 */
				deleteHierarchyItem: function(id) {
					const data = this.getHierarchyData();
					data.removeByKey(id);
					data.each(function(item, index) {
						item.set("Level", index + 1);
					});
				},

				/**
				 * @inheritDoc BaseMiniPage#getMiniPageHeader
				 * @protected
				 * @override
				 */
				getMiniPageHeader: function() {
					if (this.isAddMode()) {
						return this.get("Resources.Strings.NewPlanCaption");
					}
					if (this.isEditMode()) {
						return this.get("Resources.Strings.EditPlanCaption");
					}
					return this.Terrasoft.emptyString;
				},

				/**
				 * @inheritDoc BaseMiniPage#initEntity
				 * @protected
				 * @override
				 */
				initEntity: function(callback, scope) {
					this.callParent([function() {
						this.Terrasoft.chain(
							this._initForecastColumnReferenceSchema,
							this._initForecastReferenceSchema,
							this.initHierarchy,
							function() {
								this.Ext.callback(callback, scope);
							},
							this
						);
					}, this]);
				},

				/**
				 * Initializes hierarchy from Setting config.
				 * @protected
				 * @virtual
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback scope.
				 */
				initHierarchy: function(callback, scope) {
					const settings = this.getSettingsObj();
					if (settings && settings.hierarchy) {
						settings.hierarchy.forEach(function(item, index) {
							this._setHierarchyItem(index, item);
						}, this);
						if (this.isEditMode() && settings.hierarchy.length > 0) {
							const level = settings.hierarchy.length + 1;
							this._addEmptyHierarchyItem(level);
						}
					}
					this.Ext.callback(callback, scope);
				},

				/**
				 * @inheritDoc Terrasoft.BaseMiniPage#save
				 * @override
				 */
				save: function() {
					const forecastEntityId = this.$ForecastEntity && this.$ForecastEntity.value;
					if (this.isEmpty(forecastEntityId)) {
						return;
					}
					this.saveHierarchy();
					const parentMethod = this.getParentMethod(this, arguments);
					this._getForecastEntityInCellUId(forecastEntityId, function(forecastEntityInCellUId) {
						var isValid = this.validate();
						if (!isValid) {
							return;
						}
						if (this.isNotEmpty(forecastEntityInCellUId)) {
							this.$ForecastEntityInCellUId = forecastEntityInCellUId;
							parentMethod();
						} else {
							this.Terrasoft.chain(
								this._addEntity,
								parentMethod,
								this
							);
						}
					}, this);
				},

				/**
				 * Saves hierarchy to settings config.
				 * @protected
				 * @virtual
				 */
				saveHierarchy: function() {
					const hierarchyData = this.getHierarchyData();
					const settings = this.getSettingsObj();
					settings.hierarchy = [];
					hierarchyData.each(function(item, index) {
						const columnPath = item.get("ColumnPath");
						if (columnPath) {
							settings.hierarchy.push({
								"columnPath": columnPath,
								"level": index
							});
						}
					});
					this.set("Setting", JSON.stringify(settings));
				},

				/**
				 * @private
				 */
				_addEmptyHierarchyItem: function(level) {
					const hierarchyData = this.getHierarchyData();
					const viewModel = this.createHierarchyViewModel(level);
					hierarchyData.add(viewModel.get("Id"), viewModel);
				},

				/**
				 * @private
				 */
				_setHierarchyItem: function(index, item) {
					const hierarchyData = this.getHierarchyData();
					const viewModel = this.createHierarchyViewModel(index + 1, item.columnPath);
					this._getColumnCaption(item.columnPath, function(columnCaption) {
						viewModel.set("ColumnCaption", columnCaption);
					}, this);
					hierarchyData.add(viewModel.get("Id"), viewModel);
				},

				/**
				 * @private
				 */
				_getColumnCaption: function(path, callback, scope) {
					if (path.includes('.')) {
						this._loadHierarchyItemCaption(this.$ForecastEntity.value, path, callback, scope);
					} else {
						const schema = this.get("ForecastReferenceSchema");
						const column = schema.columns[path];
						if (column) {
							this.Ext.callback(callback, scope, [column.caption])
						}
					}
				},

				/**
				 * @private
				 */
				_loadHierarchyItemCaption: function(schemaUid, columnPath, callback, scope) {
					var schemaColumnInformationRequest = {
						getSchemaColumnInformation: {
							entitySchemaUId: schemaUid,
							SchemaColumnPath: columnPath
						}
					};
					this.Terrasoft.SchemaDesignerUtilities.execute(schemaColumnInformationRequest, function(response) {
						if (response) {
							const metaPath = schemaUid + "." + response.getSchemaColumnInformationResponse.columnMetaPath;
							this.Terrasoft.SchemaDesignerUtilities.getColumnCaptionPathByMetaPath(metaPath, callback, scope);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_initForecastColumnReferenceSchema: function(callback, scope) {
					const forecastEntitySchemaName = this.$EntitySchemaName;
					this.Terrasoft.require([forecastEntitySchemaName], function(schema) {
						this.set("ForecastColumnReferenceSchema", schema);
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @private
				 */
				_getSchemaName: function() {
					const entitySchema = this.$ForecastEntity;
					if (entitySchema) {
						if (entitySchema.Name) {
							return entitySchema.Name;
						}
						const referenceSchema = this.Terrasoft.EntitySchemaManager.getItem(entitySchema.value);
						entitySchema.Name = referenceSchema.name;
						this.set("ForecastEntity", entitySchema);
						return entitySchema.Name;
					}
					return "";
				},

				/**
				 * @private
				 */
				_initForecastReferenceSchema: function(callback, scope) {
					let schemaName = this._getSchemaName();
					const schema = this.Terrasoft[schemaName];
					if (this.isNotEmpty(schema)) {
						this.set("ForecastReferenceSchema", schema);
						this.Ext.callback(callback, scope);
						return;
					}
					this.Terrasoft.require([schemaName], function(schema) {
						this.set("ForecastReferenceSchema", schema);
						this.Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @inheritDoc Terrasoft.BaseMiniPage#onSaved
				 * @override
				 */
				onSaved: function() {
					if (this.isEditMode()) {
						this._publishSetForecastResult();
					} else {
						this._addForecastColumns(this._publishSetForecastResult);
					}
				},

				/**
				 * Adds forecast columns.
				 * @param {Function} callback Callback function.
				 * @private
				 */
				_addForecastColumns: function(callback) {
					const query = this.getInsertForecastColumnQuery();
					query.execute(function(response) {
						if (response.success) {
							this.Ext.callback(callback, this);
						}
					}, this);
				},

				/**
				 * Returns inesrt query of forecast column insert.
				 * @return {Terrasoft.InsertQuery} Insert query of forecast column insert.
				 * @protected
				 */
				getInsertForecastColumnQuery: function() {
					const insertEsq = this.Ext.create("Terrasoft.InsertQuery", {
						rootSchemaName: "ForecastColumn"
					});
					insertEsq.setParameterValue("Sheet", this.$Id, this.Terrasoft.DataValueType.GUID);
					insertEsq.setParameterValue("Type", ForecastConstants.ColumnType.Editable,
						this.Terrasoft.DataValueType.GUID);
					insertEsq.setParameterValue("Position", 0, this.Terrasoft.DataValueType.INTEGER);
					insertEsq.setParameterValue("Title", this.get("Resources.Strings.EditColumnCaption"),
						this.Terrasoft.DataValueType.TEXT);
					return insertEsq;
				},

				/**
				 * Forms ForecastColumn Settings column value.
				 * @protected
				 * @param {Terrasoft.EntitySchema} schema ForecastColumn reference schema.
				 * @return {Object} Settings column value.
				 */
				formForecastColumnSettingValue: function(schema) {
					const periodColumn = this._getSchemaColumnByName(schema, "DueDate");
					const refColumn = this._getSchemaColumn(schema, {
						"referenceSchemaName": this.$ForecastEntity.Name
					});
					const config = {
						sourceUId: schema.uId,
						periodColumn: periodColumn && periodColumn.uId || "",
						refColumnId: refColumn && refColumn.uId || ""
					};
					return JSON.stringify(config);
				},

				/**
				 * @private
				 */
				_getSchemaColumnByName: function(schema, name) {
					return this._getSchemaColumn(schema, {"name": name});
				},

				/**
				 * @private
				 */
				_getSchemaColumn: function(schema, filter) {
					return this.Terrasoft.findWhere(schema.columns, filter);
				},

				/**
				 * @private
				 */
				_publishSetForecastResult: function() {
					const result = {
						forecastId: this.$Id,
						forecastName: this.$Name,
						forecastForecastEntityInCellUId: this.$ForecastEntityInCellUId,
						forecastEntityId: this.$ForecastEntity.value,
						forecastEntityName: this.$ForecastEntity.Name,
						forecastSetting: this.$Setting
					};
					this.sandbox.publish("SetForecastResult", result, [this.sandbox.id]);
					this.hideBodyMask();
					this.close();
				},

				/**
				 * Returns hierarchy collection.
				 * @return {Terrasoft.BaseViewModelCollection} Hierarchy collection
				 */
				getHierarchyData: function() {
					let data = this.get("HierarchyData");
					if (!data) {
						data = this.Ext.create("Terrasoft.BaseViewModelCollection");
						this.set("HierarchyData", data);
					}
					return data;
				},

				/**
				 * Creates first hierarchy item.
				 */
				toggleHierarchyContainer: function() {
					const hierarchyData = this.getHierarchyData();
					if (hierarchyData.getCount() === 0) {
						this._addEmptyHierarchyItem();
						this.addNewHierarchyButtonClick();
					}
				},

				/**
				 * Clicks on new added hierarchy item.
				 */
				addNewHierarchyButtonClick: function() {
					const lookupButton = document.getElementsByClassName("hierarchy-select-column");
					if (lookupButton && lookupButton.length) {
						lookupButton[lookupButton.length - 1].click();
					}
				},

				/**
				 * Creates hierarchy view model item.
				 * @protected
				 * @param {Number} [level] Item level.
				 * @param {string} [columnPath] Item Column Path.
				 * @returns {Terrasoft.ForecastHierarchyItemViewModel}
				 */
				createHierarchyViewModel: function(level, columnPath) {
					level = level || 1;
					const entity = this.get("ForecastEntity") || {};
					const viewModel = this.Ext.create("Terrasoft.ForecastHierarchyItemViewModel", {
						sandbox: this.sandbox,
						entitySchemaName: entity.Name,
						values: {
							"Id": this.Terrasoft.generateGUID(),
							"Level": level,
							"ColumnPath": columnPath
						}
					});
					return viewModel;
				},

				/**
				 * Returns settings object.
				 * @protected
				 * @return {Object} Settings object.
				 */
				getSettingsObj: function() {
					const settings = this.get("Setting");
					return this.isNotEmpty(settings) && this.Ext.isString(settings) ? JSON.parse(settings) : {};
				},

				/**
				 * Generates configuration of the element view.
				 * @protected
				 * @param {Object} itemConfig Link to the configuration element of ContainerList.
				 */
				onGetItemConfig: function(itemConfig) {
					itemConfig.config = this.getHierarchyViewConfig();
				},

				/**
				 * Returns hierarchy item view config.
				 * @virtual
				 * @protected
				 * @return {Object} Hierarchy item view config.
				 */
				getHierarchyViewConfig: function() {
					const deleteIconImage = this.get("Resources.Images.CloseButtonImage");
					return {
						"id": "hierarchyColumnTextEdit",
						"className": "Terrasoft.Container",
						"classes": {"wrapClassName": ["control-width-15", "hierarchy-container-item"]},
						"items": [
							{
								"className": "Terrasoft.Label",
								"classes": {"labelClass": ["hierarchy-label"]},
								"caption": {"bindTo": "HierarchyLevelCaption"},
							},
							{
								"className": "Terrasoft.Container",
								"classes": {"wrapClassName": ["hierarchy-input-container"]},
								"items": [
									{
										"className": "Terrasoft.TextEdit",
										"value": {"bindTo": "ColumnCaption"},
										"markerValue": {"bindTo": "getMarkerValue"},
										"readonly": true,
										"rightIconClasses": ["custom-right-item", "lookup-edit-right-icon",
											"hierarchy-select-column"],
										"rightIconClick": {"bindTo": "openStructureExplorer"}
									},
									{
										"className": "Terrasoft.Button",
										"markerValue": {"bindTo": "getDeleteButtonMarkerValue"},
										"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
										"visible": {
											"bindTo": "ColumnPath",
											"bindConfig": {"converter": "isNotEmptyValue"}
										},
										"click": {"bindTo": "deleteHierarchyItem"},
										"classes": {"wrapperClass": ["delete-hierarchy-button"]},
										"imageConfig": deleteIconImage
									}
								]
							}
						]
					};
				},

				/**
				 * Handles forecast entity change event.
				 */
				onForecastEntityChanged: function() {
					this._verifyIsPrimaryDisplayColumnExist();
					this.getHierarchyData().reloadAll();
				},

				/**
				 * Add item to hierarchy.
				 */
				addHierarchy: function() {
					const hierarchyData = this.getHierarchyData();
					const lastItem = hierarchyData.last();
					if (lastItem && this.isNotEmpty(lastItem.get("ColumnPath"))) {
						const level = hierarchyData.getCount() + 1;
						this._addEmptyHierarchyItem(level);
						this.addNewHierarchyButtonClick();
					}
				},

				/**
				 * Verifies that primary display column in forecast entity exists.
				 * @private
				 */
				_verifyIsPrimaryDisplayColumnExist: function() {
					if (this.$ForecastEntity && this.$IsEntityInitialized) {
						this.Terrasoft.require([this.$ForecastEntity.Name], function(schema) {
							this.set("IsEntityPrimaryDisplayColumnExist", !!schema.primaryDisplayColumn);
						}, this);
					}
				},

				/**
				 * @private
				 */
				_addEntity: function(callback, scope) {
					let newSchema;
					let packageUId;
					const referenceSchema = this.Terrasoft.EntitySchemaManager.getItem(this.$ForecastEntity.value);
					this._showSavingMask();
					this.Terrasoft.chain(
						this.Terrasoft.PackageManager.getCustomPackageUId,
						function(next, customPackageUId) {
							packageUId = customPackageUId;
							const entityName = this.$ForecastEntity.Name;
							const newSchemaName =
								this.Terrasoft.EntitySchemaManager.getSchemaNamePrefix() + entityName + "Forecast";
							const existedSchema = this.Terrasoft.EntitySchemaManager.findItemByName(newSchemaName);
							if (this.isNotEmpty(existedSchema)) {
								this.$ForecastEntityInCellUId = existedSchema.uId;
								this.Ext.callback(callback, scope);
								return;
							}
							newSchema = this._createNewSchema(newSchemaName, customPackageUId, entityName);
							next();
						}, function(next) {
							newSchema.setParent(this.parentSchemaUId, next, this);
						}, function(next) {
							newSchema.define();
							const newEntitySchema = this.Terrasoft.EntitySchemaManager.addSchema(newSchema);
							this.Terrasoft.DataManager.initEntitySchemaDataCollection(newSchema.name);
							this.Terrasoft.ApplicationStructureWizardUtils
								.createLookupManagerItem(newEntitySchema, next, this);
						},
						function(next) {
							const column = this._createLookupColumn(referenceSchema);
							newSchema.addColumn(column);
							next();
						},
						function(next) {
							this.Terrasoft.EntitySchemaManager.save(next, this);
						},
						this._processResponse,
						function(next) {
							this._updateSavingMask(this.get("Resources.Strings.AddingNewObject"));
							this.Terrasoft.SchemaDesignerUtilities.buildChangedConfiguration(next, this);
						},
						this._processResponse,
						function(next) {
							this.Terrasoft.EntitySchemaManager.updateDBStructure({packageUId: packageUId}, next, this);
						},
						function() {
							this.$ForecastEntityInCellUId = newSchema.uId;
							this._hideSavingMask();
							this.Ext.callback(callback, scope);
						},
						this
					);
				},

				/**
				 * @private
				 */
				_processResponse: function(next, response) {
					if (response && response.success) {
						this.Ext.callback(next, this);
					} else {
						this._clearSchemasModifiedStatus(response.items);
						this._hideSavingMask();
						this._showErrorMessage(response);
					}
				},

				/**
				 * @private
				 */
				_clearSchemasModifiedStatus: function(items) {
					items.each(function(item) {
						item.status = this.Terrasoft.ModificationStatus.NOT_MODIFIED;
					}, this);
				},

				/**
				 * @private
				 */
				_showErrorMessage: function(response) {
					const message = response.errorInfo.toString();
					this.Terrasoft.showInformation(message);
				},

				/**
				 * @private
				 */
				_updateSavingMask: function(maskCaption) {
					if (this.savingMaskId) {
						this.Terrasoft.Mask.updateCaption(this.savingMaskId, maskCaption);
					} else {
						this._showSavingMask(maskCaption);
					}
				},

				/**
				 * @private
				 */
				_showSavingMask: function(maskCaption) {
					this.savingMaskId = this.Terrasoft.Mask.show({caption: maskCaption, timeout: 0});
				},

				/**
				 * @private
				 */
				_hideSavingMask: function() {
					this.Terrasoft.Mask.hide(this.savingMaskId);
					this.savingMaskId = null;
				},

				/**
				 * @private
				 */
				_createNewSchema: function(newSchemaName, customPackageUId, entityName) {
					const newSchema = this.Terrasoft.EntitySchemaManager.createSchema({
						"uId": this.Terrasoft.generateGUID(),
						"name": newSchemaName,
						"packageUId": customPackageUId,
						"caption": {}
					});
					const caption = this.Ext.String.format(
						this.get("Resources.Strings.NewObjectCaptionTemplate"), entityName);
					newSchema.setLocalizableStringPropertyValue("caption", caption);
					return newSchema;
				},

				/**
				 * @private
				 */
				_createLookupColumn: function(referenceSchema) {
					const column = new this.Terrasoft.EntitySchemaColumn({
						name: this.Terrasoft.EntitySchemaManager.getSchemaNamePrefix() + referenceSchema.name,
						caption: new this.Terrasoft.LocalizableString(referenceSchema.caption)
					});
					column.dataValueType = this.Terrasoft.DataValueType.LOOKUP;
					column.referenceSchemaUId = referenceSchema.uId;
					column.isValueCloneable = true;
					column.isCascade = true;
					column.setNew();
					return column;
				},

				/**
				 * @private
				 */
				_getForecastEntityInCellUId: function(forecastEntityUId, callback, scope) {
					let schemaUId;
					this.Terrasoft.EntitySchemaManager.getItemByUId(forecastEntityUId, function(referenceSchema) {
						const childForecastEntityList = this.Terrasoft.EntitySchemaManager.filterByFn(function(item) {
							return item.parentUId === this.parentSchemaUId;
						}, this);
						let column;
						this.Terrasoft.eachAsync(childForecastEntityList.getItems(), function(item, next) {
							this.Terrasoft.require([item.name], function(schema) {
								column = this.Terrasoft.findWhere(schema.columns, {
									"isInherited": false,
									"referenceSchemaName": referenceSchema.name
								});
								if (this.isNotEmpty(column)) {
									schemaUId = schema.uId;
									this.Ext.callback(callback, scope || this, [schemaUId]);
									return;
								}
								next();
							}, this, next);
						}, function() {
							this.Ext.callback(callback, scope || this, [schemaUId]);
						}, this);
					}, this);
				}
			},
			diff: /**SCHEMA_DIFF*/[
				{
					"name": "Name",
					"parentName": "MiniPage",
					"operation": "insert",
					"propertyName": "items",
					"index": 0,
					"values": {
						"labelConfig": {
							"visible": true
						},
						"isMiniPageModelItem": true,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						}
					}
				},
				{
					"name": "PeriodType",
					"parentName": "MiniPage",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"isMiniPageModelItem": true,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"enabled": {
							"bindTo": "isAddMode"
						}
					}
				},
				{
					"name": "ForecastEntity",
					"parentName": "MiniPage",
					"operation": "insert",
					"propertyName": "items",
					"values": {
						"isMiniPageModelItem": true,
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": {
								"bindTo": "prepareForecastEntityList"
							},
							"loadNextPage": {
								"bindTo": "loadNextForecastEntities"
							}
						},
						"enabled": {
							"bindTo": "isAddMode"
						}
					}
				},
				{
					"name": "PrimaryDisplayNotExistContainer",
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"values": {
						"wrapClass": ["primary-display-container"],
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						},
						"visible": {
							"bindTo": "IsEntityPrimaryDisplayColumnExist",
							"bindConfig": {"converter": "invertBooleanValue"},
						},
						"items": []
					}
				},
				{
					"name": "ForecastPrimaryDisplayNotExistError",
					"parentName": "PrimaryDisplayNotExistContainer",
					"operation": "insert",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Resources.Strings.PrimaryDisplayColumnNotExistErrorMessage"},
						"classes": {"labelClass": ["primary-display-container-label"]}
					},
					"propertyName": "items"
				},
				{
					"operation": "insert",
					"name": "Name",
					"parentName": "PrimaryDisplayNotExistContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.HYPERLINK,
						"classes": {"hyperlinkClass": ["primary-display-container-hyperlink"]},
						"markerValue": {"bindTo": "Resources.Strings.MoreDetailsCaption"},
						"caption": {"bindTo": "Resources.Strings.MoreDetailsCaption"},
						"href": {"bindTo": "Resources.Strings.MoreDetailsLink"}
					}
				},
				{
					"operation": "merge",
					"name": "SaveEditButton",
					"values": {
						"caption": {"bindTo": "Resources.Strings.CreateCaption"},
						"enabled": {"bindTo": "IsEntityPrimaryDisplayColumnExist"}
					}
				},
				{
					"operation": "merge",
					"name": "MiniPageHeaderCaption",
					"values": {
						"visible": true
					}
				},
				{
					"operation": "merge",
					"name": "OpenCurrentEntityPage",
					"values": {
						"visible": false
					}
				},
				{
					"name": "MainHierarchyContainer",
					"operation": "insert",
					"parentName": "MiniPage",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"layout": {
							"column": 0,
							"row": 5,
							"colSpan": 24
						},
						"visible": {"bindTo": "IsEntityPrimaryDisplayColumnExist"},
						"items": []
					}
				},
				{
					"name": "SetHierarchyButton",
					"operation": "insert",
					"parentName": "MainHierarchyContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"caption": {"bindTo": "Resources.Strings.SetupHierarchyButtonCaption"},
						"click": {"bindTo": "toggleHierarchyContainer"},
						"classes": {"wrapperClass": ["setup-hierarchy-button"]},
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
						"imageConfig": resources.localizableImages.HierarchyImage,
						"enabled": {
							"bindTo": "ForecastEntity",
							"bindConfig": {"converter": "isNotEmptyValue"}
						}
					}
				},
				{
					"name": "ItemsHierarchyContainer",
					"operation": "insert",
					"parentName": "MainHierarchyContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {"wrapClassName": ["items-hierarchy-container"]},
						"items": []
					}
				},
				{
					"name": "HierarchyContainerList",
					"operation": "insert",
					"parentName": "ItemsHierarchyContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"className": "Terrasoft.ContainerList",
						"collection": {"bindTo": "HierarchyData"},
						"onGetItemConfig": {"bindTo": "onGetItemConfig"},
						"classes": {"wrapClassName": ["hierarchy-container-list"]},
						"defaultItemConfig": {},
						"idProperty": "Id",
						"itemPrefix": "Id",
						"markerValue": "HierarchyContainerList"
					}
				}
			]/**SCHEMA_DIFF*/
		};
	});
