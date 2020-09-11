define("InstalledAppSection", ["InstalledAppSectionResources"],
		function(resources) {
	return {
		entitySchemaName: "SysInstalledApp",
		attributes: {
			"SecurityOperationName": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "CanManageAdministration"
			}
		},
		methods: {

			onBuy: function() {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "SysInstalledApp"});
				var nameColumn = esq.addColumn("OrderLink");
				nameColumn.orderPosition = 1;
				nameColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
				var idColumnFilter = "Id";
				esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, idColumnFilter, this.get("ActiveRow")));
				esq.getEntityCollection(function(result) {
					var links = result.success
						? result.collection
						: this.Ext.create("Terrasoft.BaseViewModelCollection");
					links.each(function(application) {
						var orderLink = application.get("OrderLink");
						window.open(orderLink);
						return;
					}, this);
				});
				
			},
			
			onLicenses: function() {
				var url = this.getIsFeatureEnabled("NewLicenseManagerUI")
						? Terrasoft.workspaceBaseUrl + "/ClientApp/#/LicenseManager"
						: Terrasoft.loaderBaseUrl + "Lic/LicManager.aspx";
				window.open(url, "_blank");
			},

			onDeleteAccept: function() {
				this.showBodyMask();
				var options = {
					url: "../ServiceModel/AppInstallerService.svc/UninstallApp",
					headers: {
						"Content-Type": "application/json",
						"Accept": "application/json"
					},
					scope: this,
					callback: this.onDeleteCallback,
					jsonData: "\"" + this.get("ActiveRow") + "\"",
					timeout: 1 * 60 * 60 * 1000
				};
				Terrasoft.AjaxProvider.request(options);
			},
			
			onDeleteCallback: function(options, success, response) {
				this.hideBodyMask();
				var successInfo = JSON.parse(response.responseText).success;
				if (successInfo) {
					this.reloadGridData();
				} else {
					var errorInfo = JSON.parse(response.responseText).errorInfo;
					this.showInformationDialog(errorInfo.message);
				}
			},

			onRedirectToMarketplace: function() {
				window.open(resources.localizableStrings.MarketplaceLink);
			},
			
			onRedirectToInstallFromFile: function() {
				window.open("ApplicationInstallation.aspx");
			},
			
			getModuleCaption: function() {
				return this.get("Resources.Strings.SectionCaption");
			},

			getDefaultDataViews: function() {
				var dataViews = this.callParent(arguments);
				delete dataViews.AnalyticsDataView;
				return dataViews;
			},

			getSectionActions: function() {
				var actionMenuItems = this.callParent(arguments);
				actionMenuItems.clear();
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Type": "Terrasoft.MenuSeparator"
				}));
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Caption": {"bindTo": "Resources.Strings.InstallFromMarketplace"},
					"Click": {"bindTo": "onRedirectToMarketplace"}
				}));
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Caption": {"bindTo": "Resources.Strings.InstallFromFile"},
					"Click": {"bindTo": "onRedirectToInstallFromFile"}
				}));
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Type": "Terrasoft.MenuSeparator"
				}));
				return actionMenuItems;
			},

			onActiveRowAction: function(buttonTag) {
				if (buttonTag === "buy") {
					this.onBuy();
				} else if (buttonTag === "licenses") {
					this.onLicenses();
				}
				else {
					this.callParent(arguments);
				}
			},
			
			isShowBuy: function(activeRow) {
				var orderLink = "";
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "SysInstalledApp"});
				var nameColumn = esq.addColumn("OrderLink");
				nameColumn.orderPosition = 1;
				nameColumn.orderDirection = this.Terrasoft.OrderDirection.ASC;
				var idColumnFilter = "Id";
				esq.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					this.Terrasoft.ComparisonType.EQUAL, idColumnFilter, this.get("ActiveRow")));
				esq.getEntityCollection(function(result) {
					var links = result.success
						? result.collection
						: this.Ext.create("Terrasoft.BaseViewModelCollection");
					links.each(function(application) {
						orderLink = application.get("OrderLink");
					}, this);
					if (orderLink === "") {
						activeRow.set("isShowBuyButton", false);
					} else {
						activeRow.set("isShowBuyButton", true);
					}
				});
			},
			
			onActiveRowChange: function() {
				var activeRow = this.getActiveRow();
				if (activeRow) {
					this.isShowBuy(activeRow);
				}
			}
			

		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "DataGridActiveRowLicenseAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"index": 1,
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.BLUE,
					"caption": resources.localizableStrings.LicensesCaption,
					"tag": "licenses",
					"visible": true
				}
			},
			{
				"operation": "insert",
				"name": "DataGridActiveRowBuyAction",
				"parentName": "DataGrid",
				"propertyName": "activeRowActions",
				"index": 2,
				"values": {
					"className": "Terrasoft.Button",
					"style": Terrasoft.controls.ButtonEnums.style.GREY,
					"caption": resources.localizableStrings.BuyCaption,
					"tag": "buy",
					"visible": {"bindTo": "isShowBuyButton"}
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowDeleteAction",
				"index": 3,
				"values": {
					"style": Terrasoft.controls.ButtonEnums.style.GREY
				}
			},
			{
				"operation": "merge",
				"name": "SeparateModeActionsButton",
				"values": {
					"style": Terrasoft.controls.ButtonEnums.style.GREEN
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowOpenAction",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "merge",
				"name": "DataGridActiveRowCopyAction",
				"values": {
					"visible": false
				}
			},
			{
				"operation": "merge",
				"name": "SeparateModeAddRecordButton",
				"values": {
					"visible": false
				}
			},
			
			{
				"operation": "merge",
				"name": "SeparateModeViewOptionsButton",
				"values": {
					"visible": true// false
				}
			}

		]/**SCHEMA_DIFF*/
	};
});