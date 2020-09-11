Ext.define("Terrasoft.NUI.NavigationHelper", {
	alternateClassName: "Terrasoft.NavigationHelper",
	extend: "Terrasoft.core.BaseObject",
	Ext: null,
	_sandbox: null,

	_navigateToSection: function(options) {
		const moduleConfig = this._getModuleConfig(options.sectionSchema);
		if (!moduleConfig) {
			this.warning("Cant find a module by supplied section schema name: " + options.sectionSchema);
			return;
		}
		const sectionUrl = this._getSectionUrl(moduleConfig);
		this._getSectionFilters(moduleConfig.entitySchemaName, options, function(filters) {
			const newState = {
				hash: sectionUrl
			};
			if (!Terrasoft.isEmptyObject(filters)) {
				newState.stateObj = {
					filterStates: filters
				};
			}
			this._sandbox.publish("PushHistoryState", newState);
		});
	},

	_getSectionFilters: function(entitySchemaName, options, callback) {
		const filter = { };
		if (options.hideFilterBlock) {
			filter.isExtendedFiltersContainerExpanded = false;
			filter.isExtendedFolderContainerExpanded = false;
			filter.isFoldersContainerExpanded = false;
		}
		if (options.folderId) {
			this._getFolderFilterByFolderId(entitySchemaName, options.folderId, function(folderFilter) {
				if (!Ext.isEmpty(folderFilter)) {
					filter.FolderFilters = [folderFilter];
				}
				Ext.callback(callback, this, [filter]);
			});
		} else {
			Ext.callback(callback, this, [filter]);
		}
	},

	_getFolderESQ: function(schemaName) {
		const esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
			rootSchemaName: schemaName
		});
		esq.addColumn("Id");
		esq.addColumn("Name");
		esq.addColumn("FolderType.Id", "FolderTypeId");
		esq.addColumn("FolderType.Name", "FolderTypeName");
		esq.addColumn("FolderType.Image.Id", "FolderImageId");
		return esq;
	},

	_getFolderFilterFromResult: function(entitySchemaName, entity) {
		return {
			displayValue: entity.get("Name"),
			folderType: {
				displayValue: entity.get("FolderTypeName"),
				primaryImageValue: entity.get("FolderImageId"),
				value: entity.get("FolderTypeId")
			},
			sectionEntityScheamName: entitySchemaName,
			value: entity.get("Id")
		};
	},

	_getFolderFilterByFolderId: function(entitySchemaName, folderId, callback) {
		const esq = this._getFolderESQ(entitySchemaName + "Folder");
		return esq.getEntity(folderId, function(result) {
			let folderFilter;
			if (result.success && result.entity) {
				folderFilter = this._getFolderFilterFromResult(entitySchemaName, result.entity);
			} else {
				const warningMessage = this.Ext.String.format("Folder with id '{0}' not found in {1}",
					folderId, entitySchemaName);
				this.warning(warningMessage);
			}
			Ext.callback(callback, this, [folderFilter]);
		}, this);
	},

	_getSectionUrl: function(moduleConfig) {
		let url = moduleConfig.sectionModule + "/";
		if (moduleConfig.sectionSchema) {
			url += moduleConfig.sectionSchema + "/";
		}
		return url;
	},

	_getModuleConfig: function(sectionSchema) {
		let result = null;
		Terrasoft.each(Terrasoft.configuration.ModuleStructure, function(item) {
			if (item && item.sectionSchema && item.sectionSchema === sectionSchema) {
				result = item;
			}
		}, this);
		return result;
	},

	/**
	 * Initializes a new instance of the Terrasoft.NavigationHelper.
	 */
	constructor: function(config) {
		this.Ext = config.Ext;
		this._sandbox = config.sandbox;
	},

	/**
	 * Performs navigation.
	 * @param config {Object} Navigation config.
	 * @param {String} config.target Target to navigate to. Possible values: 'Section'.
	 * @param {Object} config.options Navigation options.
	 * @param {String} config.options.sectionSchema Name of the schema to navigate to.
	 * @param {GUID} config.options.folderId Static folder identifier to set folder filter on.
	 * @param {Boolean} config.options.hideFilterBlock Hides filter block.
	 */
	navigateTo: function(config) {
		if (config.target === 'Section') {
			this._navigateToSection(config.options);
		} else {
			const warningMessage = this.Ext.String.format("Unsupported target: {0}", config.target);
			this.warning(warningMessage);
		}
	}
});
