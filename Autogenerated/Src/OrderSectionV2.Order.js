define("OrderSectionV2", ["ProductSalesUtils", "BaseFiltersGenerateModule", "VisaHelper", "ReportUtilities",
	"css!VisaHelper"], function(ProductSalesUtils, BaseFiltersGenerateModule, VisaHelper) {
	return {
		entitySchemaName: "Order",
		attributes: {
			/**
			 * ######### ###### #### "######### ## ###########"
			 */
			SendToVisaMenuItemCaption: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: VisaHelper.resources.localizableStrings.SendToVisaCaption
			}
		},
		methods: {
			/**
			 * ############# ############# ########### #######.
			 * @protected
			 */
			initContextHelp: function() {
				this.set("ContextHelpId", 1055);
				this.callParent(arguments);
			},

			/**
			 * ######## "######### ## ###########"
			 */
			sendToVisa: VisaHelper.SendToVisaMethod,

			/**
			 * ########## ######### ######## ####### # ###### ########### #######
			 * @protected
			 * @overridden
			 * @return {Terrasoft.BaseViewModelCollection} ########## ######### ######## ####### # ######
			 * ########### #######
			 */
			getSectionActions: function() {
				var actionMenuItems = this.callParent(arguments);
				actionMenuItems.addItem(this.getButtonMenuItem({
					Type: "Terrasoft.MenuSeparator",
					Caption: ""
				}));
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Caption": {bindTo: "SendToVisaMenuItemCaption"},
					"Click": {bindTo: "sendToVisa"},
					"Enabled": {bindTo: "isSingleSelected"}
				}));
				return actionMenuItems;
			},

			/**
			 * ######### ###### ### ######## # #######
			 * @param {Object} config
			 * @overridden
			 * @returns {Boolean}
			 */
			openCardInChain: function(config) {
				if (config && !config.hasOwnProperty("OpenProductSelectionModule")) {
					return this.callParent(arguments);
				}
				return ProductSalesUtils.openProductSelectionModuleInChain(config, this.sandbox);
			},

			/**
			 * @inheritdoc BaseSectionV2#initFixedFiltersConfig
			 * @overridden
			 */
			initFixedFiltersConfig: function() {
				var fixedFilterConfig = {
					entitySchema: this.entitySchema,
					filters: [
						{
							name: "PeriodFilter",
							caption: this.get("Resources.Strings.PeriodFilterCaption"),
							dataValueType: this.Terrasoft.DataValueType.DATE,
							columnName: "Date",
							startDate: {
								defValue: this.Terrasoft.startOfWeek(new Date())
							},
							dueDate: {
								defValue: this.Terrasoft.endOfWeek(new Date())
							}
						},
						{
							name: "Owner",
							caption: this.get("Resources.Strings.OwnerFilterCaption"),
							dataValueType: this.Terrasoft.DataValueType.LOOKUP,
							defValue: this.Terrasoft.SysValue.CURRENT_USER_CONTACT,
							filter: BaseFiltersGenerateModule.OwnerFilter,
							columnName: "Owner"
						}
					]
				};
				this.set("FixedFilterConfig", fixedFilterConfig);
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
