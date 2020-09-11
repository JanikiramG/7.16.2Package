define("ProductCatalogueFolderManagerViewConfigGenerator", [
		"ProductCatalogueFolderManagerViewConfigGeneratorResources", "FolderManagerViewConfigGenerator"],
	function(resources) {
		return Ext.define("Terrasoft.ProductCatalogueFolderManagerViewConfigGenerator", {
			extend: "Terrasoft.FolderManagerViewConfigGenerator",

			/**
			 * @inheritdoc Terrasoft.FolderManagerViewConfigGenerator#getFolderManagerContainerConfig
			 * @override
			 */
			getFolderManagerContainerConfig: function() {
				var extendCatalogueFilterContainerId = "extendCatalogueFilterContainer_" + this.sandbox.id;
				var baseConfig = this.callParent(arguments);
				baseConfig.items.push({
					className: "Terrasoft.Container",
					id: extendCatalogueFilterContainerId,
					selectors: {wrapEl: "#" + extendCatalogueFilterContainerId},
					classes: {wrapClassName: ["extend-catalogue-filter-container"]},
					visible: {bindTo: "IsExtendCatalogueFilterContainerVisible"},
					items: []
				});
				return baseConfig;
			},

			/**
			 * @inheritdoc Terrasoft.FolderManagerViewConfigGenerator#getFolderContainerConfig
			 * @override
			 */
			getFolderContainerConfig: function() {
				var baseConfig = this.callParent(arguments);
				var visibleConfig = {
					visible: {
						bindTo: "IsFoldersContainerVisible"
					}
				};
				Ext.merge(baseConfig, visibleConfig);
				return baseConfig;
			},

			/**
			 * @inheritdoc Terrasoft.FolderManagerViewConfigGenerator#getFolderGridActiveRowActionsConfig
			 * @override
			 */
			getFolderGridActiveRowActionsConfig: function() {
				let config = [
					this.getFolderFavoriteActionConfig()
				];
				config.push(this.getCatalogueFolderFilterConfig());
				return config;
			},

			/**
			 * @inheritdoc Terrasoft.FolderManagerViewConfigGenerator#getFolderFavoriteActionConfig
			 * @override
			 */
			getFolderFavoriteActionConfig: function() {
				var baseConfig = this.callParent(arguments);
				baseConfig.classes["wrapperClass"] = [
					"folder-favorite-actions-icon", "product-catalog-folder-favorite-actions-icon"
				];
				var visibleConfig = {
					visible: {
						bindTo: "IsInCatalogue",
						bindConfig: {
							converter: function(isInCatalogue) {
								return !isInCatalogue && !Ext.isEmpty(this.get("Parent"));
							}
						}
					}
				};
				Ext.merge(baseConfig, visibleConfig);
				return baseConfig;
			},

			/**
			 * @inheritdoc Terrasoft.FolderManagerViewConfigGenerator#getHeaderConfig
			 * @override
			 */
			getHeaderConfig: function() {
				var baseConfig = this.callParent(arguments);
				var visibleConfig = {
					visible: {
						bindTo: "IsCloseButtonVisible"
					}
				};
				var closeButton = Terrasoft.findItem(baseConfig, {tag: "CloseButton"});
				if (closeButton) {
					Ext.merge(baseConfig.items[closeButton.index], visibleConfig);
				}
				return baseConfig;
			},

			/**
			 * Returns catalogue folder filter config.
			 * @return {Object} Catalogue folder filter config.
			 */
			getCatalogueFolderFilterConfig: function() {
				return {
					className: "Terrasoft.Button",
					classes: {wrapperClass: "folder-catalogue-actions-icon"},
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					tag: "extendFilter",
					imageConfig: resources.localizableImages.SpecificationFilterImageV2,
					visible: {
						bindTo: "IsInCatalogue",
						bindConfig: {
							converter: function(isInCatalogue) {
								return (
										isInCatalogue &&
										!Ext.isEmpty(this.get("Parent")) &&
										this.get("IsOpenFilterButtonVisible")
								);
							}
						}
					}
				};
			}
		});
	});
