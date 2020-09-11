define("ContractSectionV2", ["GridUtilitiesV2", "VisaHelper"],
function(GridUtilitiesV2, VisaHelper) {
	return {
		entitySchemaName: "Contract",
		attributes: {
			/**
			 * ######### ###### #### "######### ## ###########"
			 */
			SendToVisaMenuItemCaption: {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: VisaHelper.resources.localizableStrings.SendToVisaCaption
			}
		},
		contextHelpId: "1071",
		diff: /**SCHEMA_DIFF*/[
		]/**SCHEMA_DIFF*/,
		messages: {},
		methods: {
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
			 * @inheritdoc Terrasoft.BaseSectionV2#initContextHelp
			 * @overridden
			*/
			initContextHelp: function() {
				this.set("ContextHelpId", 1071);
				this.callParent(arguments);
			}
		}
	};
});
