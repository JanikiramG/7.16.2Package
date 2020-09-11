define("MobileDesignerEnums", ["MobileDesignerEnumsResources"], function() {

	Ext.ns("Terrasoft.MobileDesignerEnums");

	/**
	 * Mobile page settings types.
	 * @enum
	 */
	Terrasoft.MobileDesignerEnums.SettingsType = {
		GridPage: "GridPage",
		RecordPage: "RecordPage",
		Actions: "Actions"
	};

	/**
	 * Embedded detail types.
	 * @enum
	 */
	Terrasoft.MobileDesignerEnums.EmbeddedDetailType = {
		File: "File",
		Visa: "Visa"
	};

	/**
	 * Column view types.
	 * @enum
	 */
	Terrasoft.MobileDesignerEnums.ColumnViewType = {
		Preview: "preview",
		Map: "map",
		Url: "url",
		Phone: "phone",
		Email: "email",
		File: "file",
		Normal: "normal"
	};

	/**
	 * Business rule types.
	 */
	Terrasoft.MobileDesignerEnums.BusinessRuleTypes = {
		Requirement: "Terrasoft.RequirementRule",
		Activation: "Terrasoft.ActivationRule",
		Visibility: "Terrasoft.VisibilityRule",
		MutualFiltration: "Terrasoft.MutualFiltrationRule",
		Filtration: "Terrasoft.FiltrationRule",
		Comparison: "Terrasoft.ComparisonRule",
		RegExp: "Terrasoft.RegExpRule",
		Custom: "Terrasoft.CustomRule",
		FileAndLinksBusinessRule: "Terrasoft.FileAndLinksBusinessRule"
	};

	/**
	 * Business rule events.
	 */
	Terrasoft.MobileDesignerEnums.BusinessRuleEvents = {
		Save: "save",
		ValueChanged: "valuechanged",
		Load: "load"
	};

});
