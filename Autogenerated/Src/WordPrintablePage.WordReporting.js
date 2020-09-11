define("WordPrintablePage", ["ColumnSettingsUtilities", "ConfigurationEnums", "WordPrintablePageResources",
		"ConfigurationFileApi", "css!WordPrintablePageCSS", "ContainerList", "ImageCustomGeneratorV2"],
	function(ColumnSettingsUtilities, ConfigurationEnums, resources) {
		function getIcon(iconName) {
			const resourceImage = resources.localizableImages[iconName];
			return Terrasoft.ImageUrlBuilder.getUrl(resourceImage);
		}

		function getImageButtonBackgroundStyle(iconName) {
			return Ext.String.format("url({0}) 50% 50% no-repeat", getIcon(iconName));
		}

		const sysModuleEntitySchemaColumnPath =
			"[SysModuleEntity:Id:SysModuleEntity].>[VwSysEntitySchemaInWorkspace:UId:SysEntitySchemaUId].Name";

		Ext.define("Terrasoft.configuration.WordPrintableTablePartViewModel", {
			alternateClassName: "Terrasoft.WordPrintableTablePartViewModel",
			extend: "Terrasoft.BaseViewModel",
			Ext: null,
			Terrasoft: null,
			sandbox: null,

			/**
			 * @inheritdoc Terrasoft.BaseModel#columns
			 * @override
			 */
			columns: {
				isNew: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				isDeleted: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				id: {
					dataValueType: Terrasoft.DataValueType.GUID
				},
				sysModuleReportId: {
					dataValueType: Terrasoft.DataValueType.GUID
				},
				name: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				caption: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				objectId: {
					dataValueType: Terrasoft.DataValueType.GUID
				},
				macrosList: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				referenceColumn: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				referenceColumnCaption: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				filter: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				objectColumnPath: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				objectColumnCaption: {
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				isEmptyTableHide: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				}
			},

			constructor: function() {
				this.callParent(arguments);
				this.addEvents(
					"edit",
					"remove"
				);
			},

			getColumnValues: function() {
				return {
					Id: this.$id,
					Name: this.$name,
					Caption: this.$caption,
					ObjectId: this.$objectId,
					MacrosList: this.$macrosList,
					ReferenceColumn: this.$referenceColumn,
					ReferenceColumnCaption: this.$referenceColumnCaption,
					Filter: this.$filter,
					ObjectColumnPath: this.$objectColumnPath,
					ObjectColumnCaption: this.$objectColumnCaption,
					IsEmptyTableHide: this.$isEmptyTableHide
				};
			},

			setEntityColumnValues: function(entity) {
				const columnValues = entity.columnValues;
				this.$id = columnValues.Id;
				this.$name = columnValues.Name;
				this.$caption = columnValues.Caption;
				this.$objectId = columnValues.ObjectId;
				this.$macrosList = columnValues.MacrosList;
				this.$referenceColumn = columnValues.ReferenceColumn;
				this.$referenceColumnCaption = columnValues.ReferenceColumnCaption;
				this.$filter = columnValues.Filter;
				this.$objectColumnPath = columnValues.ObjectColumnPath;
				this.$objectColumnCaption = columnValues.ObjectColumnCaption;
				this.$isEmptyTableHide = columnValues.IsEmptyTableHide;
			},

			onEditTablePartClick: Terrasoft.throttle(function() {
				this.fireEvent("edit", this);
			}, 200, {trailing: false}),

			onRemoveTablePartClick: Terrasoft.throttle(function() {
				this.fireEvent("remove", this);
			}, 200, {trailing: false})
		});

		return {
			entitySchemaName: "SysModuleReport",
			messages: {
				"RequestSysModuleReport": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"ReturnSysModuleReport": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RequestSysModuleReportDiscard": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"ReturnSysModuleReportDiscardResult": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RequestSysModuleReportSave": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"ReturnSysModuleReportSaveResult": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RequestClosePage": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"GetMacrosListDetailInfo": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"ReinitializeMacrosList": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RootEntitySchemaChanged": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"MacrosListChanged": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"OpenMacrosSettingsPage": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"SetMacrosSettings": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"ColumnSettingsInfo": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"ColumnSetuped": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"GetHistoryState": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				"PushHistoryState": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				"ReplaceHistoryState": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.PUBLISH
				},
				"GetTablePartDefaultValues": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"GetTablePartById": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"SaveTablePart": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				}
			},
			attributes: {
				TablePartsCollection: {
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					value: null
				},
				EditTablePartsCollection: {
					dataValueType: this.Terrasoft.DataValueType.COLLECTION,
					value: Ext.create("Terrasoft.BaseViewModelCollection")
				},
				MacrosList: {
					dataValueType: Terrasoft.DataValueType.CUSTOM_OBJECT,
					value: null
				},
				FileImportErrorMessage: {
					dataValueType: Terrasoft.DataValueType.TEXT,
					value: ""
				},
				FileSelected: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				IsReportTemplateExists: {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				SysModule: {
					onChange: "_onSysModuleChange",
					lookupListConfig: {
						columns: [sysModuleEntitySchemaColumnPath],
						filter: function() {
							const filters = Ext.create("Terrasoft.FilterGroup");
							filters.addItem(Terrasoft.createIsNullFilter(Ext.create("Terrasoft.ColumnExpression", {
								columnPath: "=[SysModuleEntity:Id:SysModuleEntity]" +
									".>[SysModuleEntityInPortal:SysModuleEntity:Id].Id"
							})));
							filters.addItem(Terrasoft.createColumnIsNotNullFilter(sysModuleEntitySchemaColumnPath));
							return filters;
						}
					}
				}
			},
			methods: {

				// region Methods: Private

				getColumnDataValueType: function(column) {
					let dataValueType = this.callParent(arguments);
					if (column && column.name === "MacrosList") {
						dataValueType = Terrasoft.DataValueType.CUSTOM_OBJECT;
					}
					return dataValueType;
				},

				/**
				 * @param {Object} request
				 * @param {Function} callback
				 * @param {Object} scope
				 * @private
				 */
				_sendMessageAsync: function(request, callback, scope) {
					this.sandbox.subscribe(request.backwardMessageName, function(payload) {
						callback.call(scope, payload);
					}, this);
					this.sandbox.publish(request.forwardMessageName, request.payload);
				},

				onEditTablePartClick: function(tablePart) {
					this.openCardInChain({
						schemaName: "WordPrintableTablePartPage",
						operation: ConfigurationEnums.CardStateV2.EDIT,
						id: tablePart.$id
					});
				},

				onRemoveTablePartClick: function(tablePart) {
					tablePart.$isDeleted = true;
					this.$EditTablePartsCollection.remove(tablePart);
					this.trigger("change:EditTablePartsCollection", this.$EditTablePartsCollection);
					this.updateButtonsVisibility(true);
				},

				/**
				 * @param {Object} entity
				 * @private
				 */
				_initViewModel: function(entity) {
					this.isNew = entity.isNew;
					this.$EditTablePartsCollection.clear();
					Terrasoft.each(entity.columnValues, function(value, columnName) {
						const column = this.columns[columnName];
						if (column && column.type === Terrasoft.ViewModelColumnType.ENTITY_COLUMN) {
							this.setColumnValue(columnName, value, {preventValidation: true});
						}
						if (columnName === "TableParts") {
							const tablePartsList = Ext.create("Terrasoft.BaseViewModelCollection");
							tablePartsList.on("dataLoaded", this._onTablePartsCollectionDataLoaded, this);
							tablePartsList.on("add", this._onTablePartAdd, this);
							tablePartsList.on("remove", this._onTablePartRemove, this);
							tablePartsList.on("clear", this._onTablePartsClear, this);
							if (value) {
								value.forEach(function(tablePart) {
									tablePart.caption = Terrasoft.decodeHtml(tablePart.caption);
									const viewModel = Ext.create("Terrasoft.WordPrintableTablePartViewModel", {values: tablePart});
									viewModel.on("edit", this.onEditTablePartClick, this);
									viewModel.on("remove", this.onRemoveTablePartClick, this);
									tablePartsList.add(tablePart.id, viewModel);
								}, this);
							}
							this.setColumnValue("TablePartsCollection", tablePartsList, {preventValidation: true});
							this.trigger("change:EditTablePartsCollection", this.$EditTablePartsCollection);
						}
					}, this);
					if (!entity.isNew) {
						this.changedValues = {};
					}
				},

				_onTablePartsCollectionDataLoaded: function(collection) {
					this.$EditTablePartsCollection.loadAll(collection);
				},

				_onTablePartAdd: function(tablePart) {
					this.$EditTablePartsCollection.add(tablePart.$id, tablePart);
				},

				_onTablePartRemove: function(tablePart) {
					this.$EditTablePartsCollection.remove(tablePart);
				},

				_onTablePartsClear: function() {
					this.$EditTablePartsCollection.clear();
				},

				_loadModuleSchemaName: function(callback, scope) {
					if (!this.$SysModule) {
						this.$ModuleSchemaName = null;
						Ext.callback(callback, scope);
						return;
					}
					const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SysModule"
					});
					esq.addColumn("[SysModuleEntity:Id:SysModuleEntity]." +
						"[VwSysEntitySchemaInWorkspace:UId:SysEntitySchemaUId].Name", "entitySchemaName");
					esq.filters.add("ConfItemUser", this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "Id", this.$SysModule.value));
					esq.getEntityCollection(function(response) {
						const viewModel = response.collection.first();
						this.$ModuleSchemaName = viewModel.$entitySchemaName;
						Ext.callback(callback, scope);
					}, this);
				},

				_loadPrintableFileExists: function(callback, scope) {
					const esq = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "SysModuleReport"
					});
					esq.addFunctionColumn("File", Terrasoft.FunctionType.LENGTH, "FileStreamLength");
					esq.filters.add("PrimaryColumnFilter", this.Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Id", this.$Id));
					esq.getEntityCollection(function(response) {
						const itemsCount = response.collection.getCount();
						let isReportTemplateExists = false;
						if (itemsCount > 0) {
							const viewModel = response.collection.first();
							const fileStreamLength = viewModel.$FileStreamLength || 0;
							isReportTemplateExists = fileStreamLength !== 0;
						}
						this.$IsReportTemplateExists = isReportTemplateExists;
						Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @param {String} primaryColumnValue
				 * @param {Function} callback
				 * @param {Object} scope
				 * @private
				 */
				_loadViewModel: function(primaryColumnValue, callback, scope) {
					Terrasoft.chain(
						function(next) {
							const request = {
								forwardMessageName: "RequestSysModuleReport",
								backwardMessageName: "ReturnSysModuleReport",
								payload: {id: primaryColumnValue}
							};
							this._sendMessageAsync(request, next, this);
						},
						function(next, entity) {
							this._initViewModel(entity);
							Ext.callback(callback, scope);
						},
						this
					);
				},

				/**
				 * @return {Object}
				 * @private
				 */
				_prepareViewModelSaveConfig: function() {
					const columnValues = {};
					Terrasoft.each(this.columns, function(column, columnName) {
						if (column.type === Terrasoft.ViewModelColumnType.ENTITY_COLUMN) {
							columnValues[columnName] = this.get(columnName);
						}
					}, this);
					const tableParts = [];
					const tablePartsCollection = this.get("TablePartsCollection");
					if (tablePartsCollection) {
						tablePartsCollection.each(function(tablePartViewModel) {
							if (tablePartViewModel.$isNew && tablePartViewModel.$isDeleted) {
								return;
							}
							tableParts.push({
								isNew: tablePartViewModel.$isNew,
								isDeleted: tablePartViewModel.$isDeleted,
								id: tablePartViewModel.$id,
								name: tablePartViewModel.$name,
								caption: tablePartViewModel.$caption,
								sysModuleReportId: tablePartViewModel.$sysModuleReportId,
								objectId: tablePartViewModel.$objectId,
								macrosList: tablePartViewModel.$macrosList,
								referenceColumn: tablePartViewModel.$referenceColumn,
								referenceColumnCaption: tablePartViewModel.$referenceColumnCaption,
								filter: tablePartViewModel.$filter,
								objectColumnPath: tablePartViewModel.$objectColumnPath,
								objectColumnCaption: tablePartViewModel.$objectColumnCaption,
								isEmptyTableHide: tablePartViewModel.$isEmptyTableHide
							});
						}, this);
					}
					columnValues.TableParts = tableParts;
					return {columnValues: columnValues};
				},

				/**
				 * @param {Function} callback
				 * @param {Scope} scope
				 * @private
				 */
				_saveViewModel: function(callback, scope) {
					Terrasoft.chain(
						function(next) {
							const request = {
								forwardMessageName: "RequestSysModuleReportSave",
								backwardMessageName: "ReturnSysModuleReportSaveResult",
								payload: this._prepareViewModelSaveConfig()
							};
							this._sendMessageAsync(request, next, this);
						},
						function(next, response) {
							if (response.success) {
								this.isNew = false;
								this.$TablePartsCollection
									.filterByFn(function(tablePart) {
										return tablePart.$isDeleted;
									}, this)
									.getKeys()
									.forEach(function(tablePartKey) {
										this.$TablePartsCollection.removeByKey(tablePartKey);
									}, this);
								this.$TablePartsCollection.each(function(tablePart) {
									tablePart.$isNew = false;
								}, this);
								this.changedValues = null;
							}
							callback.call(scope, response);
						},
						this
					);
				},

				/**
				 * @private
				 */
				_internalClosePage: function() {
					this.sandbox.publish("BackHistoryState");
					this.sandbox.publish("RequestClosePage");
				},

				_openMacrosSettingsPage: function(macrosSettingsConfig) {
					ColumnSettingsUtilities.Open(this.sandbox, macrosSettingsConfig, function(newMacrosSettingsConfig) {
						this.sandbox.publish("SetMacrosSettings", newMacrosSettingsConfig, ["reportMacrosList"]);
					}, this.renderTo, this);
				},

				_onSysModuleChange: function(model, lookupValue) {
					this.set("ModuleSchemaName", lookupValue ? lookupValue[sysModuleEntitySchemaColumnPath] : null);
					this.sandbox.publish("RootEntitySchemaChanged", this.$ModuleSchemaName, ["reportMacrosList"]);
				},

				_onGetMacrosListDetailInfo: function() {
					return {
						rootEntitySchema: this.$ModuleSchemaName || "",
						macrosList: this.$MacrosList || [],
						caption: this.get("Resources.Strings.MacrosListDetailCaption"),
						infoButtonText: this.get("Resources.Strings.MacrosListDetailInfoButtonText"),
						moduleSchemaNameRequiredValidationMessage: this._getSysModuleRequiredValidationMessage()
					};
				},

				_onMacrosListChanged: function(macrosListArray) {
					this.$MacrosList = macrosListArray;
				},

				_getSysModuleRequiredValidationMessage: function() {
					return Ext.String.format(
						Terrasoft.Resources.BaseViewModel.fieldValidationError,
						this.getColumnCaptionByName("SysModule"),
						Terrasoft.Resources.BaseViewModel.columnRequiredValidationMessage);
				},

				_getFileImportDragAndDropContainerCaption: function() {
					return Ext.isIEOrEdge ? "" : this.get("Resources.Strings.FileImportDragAndDropContainerCaption");
				},

				_getTemplateWasSuccessfullyUploadedMessage: function() {
					return Ext.String.format(this.get("Resources.Strings.TemplateSuccessfullyUploadedMessage"));
				},

				// endregion

				// region Methods: Protected

				/**
				 * @inheritDoc Terrasoft.BasePageV2#onCloseCardButtonClick
				 * @overridden
				 */
				onCloseCardButtonClick: function() {
					this._internalClosePage();
				},

				/**
				 * @inheritDoc Terrasoft.BasePageV2#onDiscardChangesClick
				 * @overridden
				 */
				onDiscardChangesClick: function(callback, scope) {
					if (this.isNew) {
						this._internalClosePage();
					} else {
						const parentMethod = this.getParentMethod();
						this.sandbox.publish("RequestSysModuleReportDiscard");
						this.sandbox.subscribe("ReturnSysModuleReportDiscardResult", function() {
							Terrasoft.chain(
								function(next) {
									parentMethod.call(this, next);
								},
								function(next) {
									this._loadModuleSchemaName(next, this);
								},
								function() {
									this.sandbox.publish("RootEntitySchemaChanged", this.$ModuleSchemaName, ["reportMacrosList"]);
									this.sandbox.publish("ReinitializeMacrosList", this.$MacrosList, ["reportMacrosList"]);
									Ext.callback(callback, scope);
								},
								this
							);
						}, this);
					}
				},

				onEntityInitialized: function() {
					this.callParent(arguments);
					Terrasoft.chain(
						this._loadPrintableFileExists,
						this._loadModuleSchemaName,
						function() {
							this.sandbox.publish("RootEntitySchemaChanged", this.$ModuleSchemaName, ["reportMacrosList"]);
							this.sandbox.publish("ReinitializeMacrosList", this.$MacrosList, ["reportMacrosList"]);
						},
						this
					);
				},

				// endregion

				// region Methods: Public

				/**
				 * @inheritDoc Terrasoft.EntityBaseViewModelMixin#setDefaultValues
				 * @overridden
				 */
				setDefaultValues: function(callback, scope) {
					this.callParent([function() {
						this._loadViewModel(null, callback, scope);
					}, this]);
				},

				/**
				 * @inheritDoc Terrasoft.EntityBaseViewModelMixin#loadEntity
				 * @overridden
				 */
				loadEntity: function(primaryColumnValue, callback, scope) {
					this._loadViewModel(primaryColumnValue, callback, scope);
				},

				subscribeSandboxEvents: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("GetMacrosListDetailInfo", this._onGetMacrosListDetailInfo, this, ["reportMacrosList"]);
					this.sandbox.subscribe("MacrosListChanged", this._onMacrosListChanged, this, ["reportMacrosList"]);
					this.sandbox.subscribe("OpenMacrosSettingsPage", this._openMacrosSettingsPage, this, ["reportMacrosList"]);
					this.sandbox.subscribe("GetTablePartDefaultValues", function() {
						return {
							columnValues: {
								MainObjectName: this.$ModuleSchemaName
							}
						};
					}, this);
					this.sandbox.subscribe("GetTablePartById", function(payload) {
						const collection = this.get("TablePartsCollection");
						const tablePart = collection.get(payload.id);
						const columnValues = tablePart.getColumnValues();
						columnValues.MainObjectName = this.$ModuleSchemaName;
						return {columnValues: columnValues};
					}, this);
					this.sandbox.subscribe("SaveTablePart", function(entity) {
						const collection = this.get("TablePartsCollection");
						const id = entity.columnValues.Id;
						if (!collection.contains(id)) {
							const viewModel = Ext.create("Terrasoft.WordPrintableTablePartViewModel");
							viewModel.$isNew = true;
							viewModel.$isDeleted = false;
							viewModel.$sysModuleReportId = this.$Id;
							viewModel.on("edit", this.onEditTablePartClick, this);
							viewModel.on("remove", this.onRemoveTablePartClick, this);
							collection.add(id, viewModel);
						}
						const tablePart = collection.get(id);
						tablePart.setEntityColumnValues(entity);
						this.updateButtonsVisibility(true);
						return {success: true};
					}, this);
				},

				/**
				 * @inheritDoc Terrasoft.EntityBaseViewModelMixin#saveEntity
				 * @overridden
				 */
				saveEntity: function(callback, scope) {
					this._saveViewModel(callback, scope);
				},

				onGeTablePartstCollectionItemConfig: function(itemConfig) {
					itemConfig.config = {
						"className": "Terrasoft.Container",
						"id": "table-part",
						"classes": {"wrapClassName": ["table-part-ct"]},
						"visible": {
							"bindTo": "isDeleted",
							"bindConfig": {"converter": "invertBooleanValue"}
						},
						"items": [{
							"className": "Terrasoft.Hyperlink",
							"caption": {"bindTo": "caption"},
							"classes": {"hyperlinkClass": ["table-part-link"]},
							"click": {"bindTo": "onEditTablePartClick"}
						}, {
							className: "Terrasoft.HtmlControl",
							tpl: ["<span id='{id}' class='spacer'></span>"]
						}, {
							"className": "Terrasoft.Button",
							"click": {"bindTo": "onEditTablePartClick"},
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"hint": resources.localizableStrings.EditButtonHint,
							"styles": {
								"wrapperStyle": {
									"background": getImageButtonBackgroundStyle("EditTablePartIcon")
								}
							},
							"classes": {"wrapperClass": ["table-part-item", "action-item", "edit-column-icon"]}
						}, {
							"className": "Terrasoft.Button",
							"click": {"bindTo": "onRemoveTablePartClick"},
							"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"hint": resources.localizableStrings.RemoveButtonHint,
							"styles": {
								"wrapperStyle": {
									"background": getImageButtonBackgroundStyle("DeleteTablePartIcon")
								}
							},
							"classes": {"wrapperClass": ["table-part-item", "action-item", "remove-column-icon"]}
						}
						]
					};
				},

				addTablePart: function() {
					if (!this.$ModuleSchemaName) {
						this.showInformationDialog(this._getSysModuleRequiredValidationMessage());
						return;
					}
					this.openCardInChain({
						schemaName: "WordPrintableTablePartPage",
						operation: ConfigurationEnums.CardStateV2.ADD
					});
				},

				canChangeSection: function() {
					const hasMacrosList = this.$MacrosList && this.$MacrosList.length !== 0;
					const hasTableParts = this.$EditTablePartsCollection.getCount() !== 0;
					return !hasMacrosList && !hasTableParts;
				},

				rerenderMacrosListModule: function(config) {
					const moduleId = config.name;
					const loadedModules = this.loadedModules = this.loadedModules || {};
					if (!loadedModules[moduleId]) {
						this.loadModule(config);
						this.loadedModules[moduleId] = true;
					}
				},

				getEmptyMessageViewConfig: function(emptyMessageProperties) {
					return {
						className: "Terrasoft.Container",
						classes: {
							wrapClassName: ["empty-message-ct"]
						},
						items: [{
							className: "Terrasoft.Label",
							classes: {
								labelClass: ["empty-message"]
							},
							caption: emptyMessageProperties.caption
						}]
					};
				},

				prepareEmptyMessageConfig: function(config) {
					const emptyMessageProperties = {
						caption: this.get("Resources.Strings.EmptyDetailMessageCaption")
					};
					const emptyMessageViewConfig = this.getEmptyMessageViewConfig(emptyMessageProperties);
					Ext.apply(config, emptyMessageViewConfig);
				},

				getInfoBlockIcon: function() {
					const infoBlockIcon = this.get("Resources.Images.InfoBlockIcon");
					return Terrasoft.ImageUrlBuilder.getUrl(infoBlockIcon);
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#onRender
				 * @overridden
				 */
				onRender: function() {
					this.callParent(arguments);
					this._initDropzoneEvents();
				},

				_getDropzone: function() {
					const element = this.Ext.get("FileImportDragAndDropContainer");
					return element.dom;
				},

				_initDropzoneEvents: function() {
					const dropzone = this._getDropzone();
					Terrasoft.ConfigurationFileApi.initDropzoneEvents(dropzone, this._onDropzoneHover.bind(this),
						this._onDropzoneDrop.bind(this));
				},

				/**
				 * Handles dropzone "dragenter" and "dragleave" events.
				 * @private
				 */
				_onDropzoneHover: function(over, event) {
					const dropzone = this._getDropzone();
					if (over) {
						dropzone.classList.add("dropzone-hover");
					} else {
						dropzone.classList.remove("dropzone-hover");
						const dataTransfer = event.dataTransfer;
						this.$DroppedFiles = dataTransfer.files;
					}
				},

				_onDropzoneDrop: function() {
					this.onFilesSelected(this.$DroppedFiles);
				},

				/**
				 * Gets empty dropzone image.
				 * @return {String}
				 */
				getFileImportEmptyFileImage: function() {
					return this._getImageUrl("Resources.Images.FileImportEmptyFileImage");
				},

				/**
				 * Gets broken file image.
				 * @return {String}
				 */
				getFileImportErrorFileImage: function() {
					return this._getImageUrl("Resources.Images.FileImportErrorFileImage");
				},

				getWordIconImage: function() {
					return this._getImageUrl("Resources.Images.FileImportWordIcon");
				},

				_getImageUrl: function(resourceName) {
					const image = this.get(resourceName);
					return Terrasoft.ImageUrlBuilder.getUrl(image);
				},

				_getFileImportErrorMessage: function() {
					return this.$FileImportErrorMessage;
				},

				_setFileImportErrorMessage: function(errorMessage) {
					this.$FileImportErrorMessage = errorMessage;
				},

				_showClientFileImportErrorMessage: function(response) {
					if (response.success) {
						this.$IsReportTemplateExists = true;
						this.showInformationDialog(this._getTemplateWasSuccessfullyUploadedMessage());
					} else {
						const errorMessage = this._getTemplateUploadErrorMessage(response.errorInfo.errorCode,
							response.errorInfo.message);
						this.$IsReportTemplateExists = false;
						this._setFileImportErrorMessage(errorMessage);
					}
				},

				_getFileType: function(file) {
					return file && file.type;
				},

				_validateFileType: function(file) {
					let validationResult = false;
					if (file) {
						const fileType = this._getFileType(file);
						if (fileType) {
							const wordMediaTypeRegExp = /application\/vnd\.openxmlformats-officedocument\.wordprocessingml\.document/;
							validationResult = wordMediaTypeRegExp.test(fileType);
						} else {
							const fileName = file.name;
							const docExtensionRegExp = /.docx$/;
							validationResult = docExtensionRegExp.test(fileName);
						}
					}
					const message = (validationResult) ? "" : this.get("Resources.Strings.FileImportInvalidFileTypeMessage");
					this._setFileImportErrorMessage(message);
					return validationResult;
				},

				_getFileUploadConfig: function(file) {
					const fileId = Terrasoft.generateGUID();
					const config = {
						scope: this,
						data: {
							reportId: this.$Id,
							fileId: fileId
						},
						onComplete: this.onFileUploadComplete,
						entitySchemaName: "SysReportTemplate",
						uploadWebServicePath: "WordReportingDesignService/UploadReportTemplate",
						columnName: "File",
						parentColumnName: "Id",
						parentColumnValue: fileId,
						files: [file],
						isChunkedUpload: true,
						additionalParams: {
							ReportId: this.$Id
						},
						maxFileSizeSysSettingsName: "FileImportMaxFileSize"
					};
					return config;
				},

				_getFileSizeErrorMessage: function(maxFileSize, fileName) {
					const size = maxFileSize ? maxFileSize : 0;
					const fileCaption = fileName ? ": " + fileName : "";
					return Ext.String.format(this.get("Resources.Strings.FileImportInvalidSizeMessage"),
						size, fileCaption);
				},

				_getTemplateUploadErrorMessage: function(errorCode, message) {
					switch (errorCode) {
						case "404":
							return this.get("Resources.Strings.Template404UploadError");
						case "405":
							return this.get("Resources.Strings.Template405UploadError");
						case "406":
							return this.get("Resources.Strings.Template406UploadError");
						case "411":
							return this._getFileSizeErrorMessage(message);
						default:
							return this.get("Resources.Strings.TemplateGeneralUploadError");
					}
				},

				onFileUploadComplete: function(error, xhr) {
					this.hideBodyMask();
					let response;
					if (xhr) {
						try {
							response = JSON.parse(xhr.response);
						} catch (e) {
							response = null;
						}
					}
					if (error) {
						if (response) {
							this._showClientFileImportErrorMessage(response);
						} else {
							this.$IsReportTemplateExists = false;
							this._setFileImportErrorMessage(error);
						}
					} else {
						this._showClientFileImportErrorMessage(response);
					}
				},

				_validateFileSize: function(file, callback) {
					let sizeIsValid = false;
					let maxFileSizeValue;
					Terrasoft.chain(
						function(next) {
							Terrasoft.SysSettings.querySysSettingsItem("FileImportMaxFileSize", function(value) {
								if (value) {
									maxFileSizeValue = value;
									const maxSizeInBytes = value * 1024 * 1024;
									sizeIsValid = file.size <= maxSizeInBytes;
								}
								next()
							}, this);
						}, function() {
							Ext.callback(callback, this, [sizeIsValid, maxFileSizeValue]);
						}, this);
				},

				onFilesSelected: function(files) {
					const file = files[0];
					Terrasoft.chain(
						function(next) {
							if (!this._validateFileType(file)) {
								this.$IsReportTemplateExists = false;
								return;
							}
							next()
						}, function(next) {
							this._validateFileSize(file, function(sizeIsValid, maxFileSizeValue) {
								if (!sizeIsValid) {
									const message = this._getFileSizeErrorMessage(maxFileSizeValue, file.name)
									this._setFileImportErrorMessage(message);
									this.$IsReportTemplateExists = false;
									return;
								}
								next()
							});
						}, function() {
							this.save({
								isSilent: true,
								callback: function() {
									this.showBodyMask();
									const config = this._getFileUploadConfig(file);
									Terrasoft.ConfigurationFileApi.upload(config);
								},
								scope: this
							});
						}, this);
				},

				getIsEmptyFileContainerVisible: function() {
					return !this.$IsReportTemplateExists;
				},

				/**
				 * Gets error file container visibility.
				 * @return {Boolean}
				 */
				getIsErrorFileContainerVisible: function() {
					return !Ext.isEmpty(this.$FileImportErrorMessage);
				},

				/**
				 * Gets empty file container visibility.
				 * @return {Boolean}
				 */
				getIsUploadFileContainerVisible: function() {
					return !this.getIsErrorFileContainerVisible() && this.getIsEmptyFileContainerVisible();
				},

				_getTemplateFileName: function() {
					return this.$Caption + ".docx";
				},

				onFileDownloadButtonClick: function() {
					Terrasoft.download(
						Terrasoft.workspaceBaseUrl +
						"/rest/WordReportingDesignService/DownloadReportTemplate/" +
						this.$Id, this._getTemplateFileName()
					);
				},

				onFileDeleteButtonClick: function() {
					const requestConfig = {
						url: Terrasoft.workspaceBaseUrl + "/rest/WordReportingDesignService/RemoveReportTemplate",
						method: "POST",
						jsonData: {reportId: this.$Id}
					};
					const self = this;
					Terrasoft.AjaxProvider.request(Ext.apply(requestConfig, {
						callback: function(request, success) {
							if (success) {
								self.$IsReportTemplateExists = false;
							}
						}
					}));
				}

				//endregion

			},
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "merge",
					"name": "CardContentWrapper",
					"values": {
						"wrapClass": ["card-content-container", "word-printable-card-content-container"]
					}
				},
				{
					"operation": "insert",
					"name": "MainHeaderWrap",
					"parentName": "CardContentWrapper",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["word-printable-card-main-header-wrap-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "MainHeader",
					"parentName": "MainHeaderWrap",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["word-printable-card-main-header-container"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "PageCaption",
					"parentName": "MainHeader",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Caption"}
					}
				},
				{
					"operation": "remove",
					"name": "TabsContainer"
				},
				{
					"operation": "merge",
					"name": "SaveButton",
					"values": {
						"hint": ""
					}
				},
				{
					"operation": "insert",
					"name": "Caption",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "Caption",
						"caption": {"bindTo": "Resources.Strings.ReportCaptionLabel"},
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "SysModule",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "SysModule",
						"enabled": {
							"bindTo": "canChangeSection"
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "Type",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "Type",
						"enabled": false,
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "ShowInSection",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "ShowInSection",
						"caption": {"bindTo": "Resources.Strings.ShowInSectionLabel"},
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "ShowInCard",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"values": {
						"bindTo": "ShowInCard",
						"caption": {"bindTo": "Resources.Strings.ShowInCardLabel"},
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						}
					}
				},
				{
					"operation": "insert",
					"name": "FileImportContainer",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-block-ct"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FileImportDragAndDropContainer",
					"parentName": "FileImportContainer",
					"propertyName": "items",
					"values": {
						"id": "FileImportDragAndDropContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-dropzone"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FileImportDescriptionContainer",
					"parentName": "FileImportDragAndDropContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-description-ct"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "FileImportDescription",
					"parentName": "FileImportDescriptionContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.FileImportContainerDescription",
						"classes": {
							"labelClass": ["file-import-description"]
						},
						"markerValue": "FileImportDescription"
					}
				},
				{
					"operation": "insert",
					"name": "FileImportEmptyFileContainer",
					"parentName": "FileImportDragAndDropContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-empty-file-ct"]
						},
						"items": [],
						"visible": {"bindTo": "getIsEmptyFileContainerVisible"}
					}
				},
				{
					"operation": "insert",
					"name": "UploadFileContainer",
					"parentName": "FileImportEmptyFileContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-upload-file-ct"]
						},
						"items": [],
						"visible": {"bindTo": "getIsUploadFileContainerVisible"}
					}
				},
				{
					"operation": "insert",
					"name": "EmptyFileImage",
					"parentName": "UploadFileContainer",
					"propertyName": "items",
					"values": {
						"readonly": true,
						"getSrcMethod": "getFileImportEmptyFileImage",
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl",
						"classes": {
							"wrapClass": ["file-import-empty-file-image-wrapper"]
						},
						"markerValue": "EmptyFileImage"
					}
				},
				{
					"operation": "insert",
					"name": "EmptyFileCaption",
					"parentName": "UploadFileContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "_getFileImportDragAndDropContainerCaption"},
						"classes": {
							"wrapClassName": ["file-import-upload-caption"],
							"labelClass": ["file-import-upload-caption"]
						},
						"markerValue": "FileImportEmptyFileCaption"
					}
				},
				{
					"operation": "insert",
					"name": "ErrorFileContainer",
					"parentName": "FileImportEmptyFileContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["file-import-error-file-ct"]
						},
						"items": [],
						"visible": {"bindTo": "getIsErrorFileContainerVisible"}
					}
				},
				{
					"operation": "insert",
					"name": "ErrorFileImage",
					"parentName": "ErrorFileContainer",
					"propertyName": "items",
					"values": {
						"readonly": true,
						"getSrcMethod": "getFileImportErrorFileImage",
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl",
						"classes": {
							"wrapClass": ["file-import-error-file-image-wrapper"]
						},
						"markerValue": "FileImportErrorFileImage"
					}
				},
				{
					"operation": "insert",
					"name": "ErrorFileCaption",
					"parentName": "ErrorFileContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "_getFileImportErrorMessage"},
						"classes": {
							"wrapClassName": ["file-import-error-caption"],
							"labelClass": ["file-import-error-caption"]
						},
						"markerValue": "FileImportErrorFileCaption"
					}
				},
				{
					"operation": "insert",
					"name": "UploadFileButton",
					"parentName": "FileImportEmptyFileContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"caption": "$Resources.Strings.FileImportUploadFileButtonCaption",
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"classes": {
							"textClass": ["file-import-upload-button"],
							"wrapperClass": ["file-import-upload-button"]
						},
						"fileTypeFilter": [".docx"],
						"fileUpload": true,
						"filesSelected": {"bindTo": "onFilesSelected"},
						"fileUploadMultiSelect": false,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "FileImportUploadFileButton"
					}
				},


				{
					"operation": "insert",
					"name": "WordFileContainer",
					"parentName": "FileImportDragAndDropContainer",
					"propertyName": "items",
					"values": {
						"id": "WordFileContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["file-import-template-file-ct"],
						"items": [],
						"visible": {"bindTo": "IsReportTemplateExists"}
					}
				},
				{
					"operation": "insert",
					"name": "WordFileImage",
					"parentName": "WordFileContainer",
					"propertyName": "items",
					"values": {
						"readonly": true,
						"getSrcMethod": "getWordIconImage",
						"generator": "ImageCustomGeneratorV2.generateCustomImageControl",
						"classes": {
							"wrapClass": ["file-import-template-file-image-wrapper"]
						},
						"markerValue": "TemplateFileImage"
					}
				},
				{
					"operation": "insert",
					"name": "WordFileNameContainer",
					"parentName": "WordFileContainer",
					"propertyName": "items",
					"values": {
						"id": "WordFileNameContainer",
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["file-import-template-file-name-ct"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "WordFileName",
					"parentName": "WordFileNameContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"click": {"bindTo": "onFileDownloadButtonClick"},
						"caption": {"bindTo": "_getTemplateFileName"},
						"classes": {
							"wrapperClass": ["file-import-template-file-download-action-button"]
						},
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "TemplateFileName"
					}
				},
				{
					"operation": "insert",
					"name": "WordFileDeleteButton",
					"parentName": "WordFileNameContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "",
						"click": {"bindTo": "onFileDeleteButtonClick"},
						"classes": {
							"wrapperClass": ["file-import-delete-template-button"]
						},
						"imageConfig": resources.localizableImages.FileImportDeleteTemplateIcon,
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "TemplateFileDeleteButton"
					}
				},

				{
					"operation": "insert",
					"name": "TemplateFileActionsContainer",
					"parentName": "WordFileContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"wrapClass": ["file-import-template-file-actions-ct"],
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TemplateFileDownloadActionBtn",
					"parentName": "TemplateFileActionsContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "$Resources.Strings.FileImportDownloadTemplateFileCaption",
						"click": {"bindTo": "onFileDownloadButtonClick"},
						"classes": {
							"wrapperClass": ["file-import-template-file-download-action-button"]
						},
						"imageConfig": resources.localizableImages.FileImportDownloadTemplateIcon,
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.TOP,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "DownloadTemplateFileButton"
					}
				},
				{
					"operation": "insert",
					"name": "TemplateFileUploadActionBtn",
					"parentName": "TemplateFileActionsContainer",
					"propertyName": "items",
					"values": {
						"generateId": false,
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"caption": "$Resources.Strings.FileImportUploadTemplateFileCaption",
						"fileTypeFilter": [".docx"],
						"fileUpload": true,
						"filesSelected": {"bindTo": "onFilesSelected"},
						"fileUploadMultiSelect": false,
						"classes": {
							"wrapperClass": ["file-import-template-file-upload-action-button"]
						},
						"imageConfig": resources.localizableImages.FileImportUploadTemplateIcon,
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.TOP,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"markerValue": "UploadTemplateFileButton"
					}
				},


				{
					"operation": "insert",
					"name": "InfoBlockContainer",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["info-block-ct"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockCaptionContainer",
					"parentName": "InfoBlockContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["info-block-caption-ct"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockIcon",
					"parentName": "InfoBlockCaptionContainer",
					"propertyName": "items",
					"values": {
						"getSrcMethod": "getInfoBlockIcon",
						"readonly": true,
						"generator": "ImageCustomGeneratorV2.generateSimpleCustomImage",
						"classes": {
							"wrapClass": ["info-block-icon"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockCaption",
					"parentName": "InfoBlockCaptionContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockCaption",
						"classes": {
							"labelClass": ["info-block-caption"]
						},
						"markerValue": "InfoBlockCaption"
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockStepsCaption",
					"parentName": "InfoBlockContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockStepsCaption",
						"classes": {
							"labelClass": ["info-block-steps-caption"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockStepsContainer",
					"parentName": "InfoBlockContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"classes": {
							"wrapClassName": ["info-block-steps-ct"]
						},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockStep1",
					"parentName": "InfoBlockStepsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockStep1",
						"classes": {
							"labelClass": ["info-block-step"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockStep2",
					"parentName": "InfoBlockStepsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockStep2",
						"classes": {
							"labelClass": ["info-block-step"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockStep3",
					"parentName": "InfoBlockStepsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockStep3",
						"classes": {
							"labelClass": ["info-block-step"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockDescription",
					"parentName": "InfoBlockContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": "$Resources.Strings.InfoBlockDescription",
						"classes": {
							"labelClass": ["info-block-description"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "InfoBlockAcademyLink",
					"parentName": "InfoBlockContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.HYPERLINK,
						"classes": {
							"hyperlinkClass": ["info-block-academy"]
						},
						"caption": "$Resources.Strings.InfoBlockAcademyLinkCaption",
						"href": "$Resources.Strings.InfoBlockAcademyLink",
						"markerValue": "InfoBlockAcademyLink",
						"target": Terrasoft.controls.HyperlinkEnums.target.BLANK
					}
				},
				{
					"operation": "remove",
					"name": "RecommendationModuleContainer"
				},
				{
					"operation": "remove",
					"name": "HeaderGridLayout"
				},
				{
					"operation": "remove",
					"name": "PageHeaderContainer"
				},
				{
					"operation": "insert",
					"name": "MacrosListGroupModule",
					"parentName": "CardContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE,
						"moduleName": "MacrosListDetailModule",
						"reload": false,
						"afterrender": {
							"bindTo": "rerenderMacrosListModule"
						},
						"afterrerender": {
							"bindTo": "rerenderMacrosListModule"
						},
						"instanceConfig": {
							"sandboxTag": "reportMacrosList"
						}
					}
				},
				{
					"operation": "insert",
					"name": "TablePartsGroup",
					"parentName": "CardContentContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"classes": {
							"wrapClass": ["table-parts"]
						},
						"caption": {
							"bindTo": "Resources.Strings.TablePartsDetailCaption"
						},
						"items": [],
						"tools": []
					}
				},
				{
					"operation": "insert",
					"name": "TablePartInfoButton",
					"parentName": "TablePartsGroup",
					"propertyName": "tools",
					"values": {
						"itemType": Terrasoft.ViewItemType.INFORMATION_BUTTON,
						"content": "$Resources.Strings.TablePartsDetailInfoButtonText",
						"tools": [],
						"behaviour": {
							"displayEvent": Terrasoft.TipDisplayEvent.HOVER
						},
						"controlConfig": {
							"classes": {
								"wrapperClass": "info-button"
							}
						}
					}
				},
				{
					"operation": "insert",
					"name": "AddTablePart",
					"parentName": "TablePartsGroup",
					"propertyName": "tools",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
						"imageConfig": {"bindTo": "Resources.Images.AddTablePartIcon"},
						"classes": {
							"wrapperClass": "add-table-part"
						},
						"click": {"bindTo": "addTablePart"},
						"tag": "addTablePart"
					}
				},
				{
					"operation": "insert",
					"name": "TablePartsMainContainer",
					"parentName": "TablePartsGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TablePartsHeaderContainer",
					"parentName": "TablePartsMainContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"visible": {
							"bindTo": "EditTablePartsCollection",
							"bindConfig": {"converter": "isNotEmptyValue"}
						},
						"classes": {"wrapClassName": ["container-list-header"]},
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "TablePartsHeaderLabel",
					"parentName": "TablePartsHeaderContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Resources.Strings.TablePartsHeaderLabel"}
					}
				},
				{
					"operation": "insert",
					"name": "TablePartsContainerList",
					"parentName": "TablePartsMainContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"className": "Terrasoft.ContainerList",
						"collection": {"bindTo": "EditTablePartsCollection"},
						"classes": {"wrapClassName": ["container-list"]},
						"rowCssSelector": ".section-group-item",
						"onGetItemConfig": {"bindTo": "onGeTablePartstCollectionItemConfig"},
						"getEmptyMessageConfig": {"bindTo": "prepareEmptyMessageConfig"},
						"idProperty": "id",
						"dataItemIdPrefix": "table-part",
						"itemPrefix": "TablePart-",
						"defaultItemConfig": {},
						"selectableRowCss": "section-group-item"
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
