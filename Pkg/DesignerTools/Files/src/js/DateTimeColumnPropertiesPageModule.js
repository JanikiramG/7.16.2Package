define("DateTimeColumnPropertiesPageModule", ["SchemaModelItemDesignerResources", "MaskHelper", "BaseModule", "page-wizard-component"], function(resources, MaskHelper) {
	Ext.define("Terrasoft.DateTimeColumnPropertiesPageModule", {
		extend: "Terrasoft.configuration.BaseModule",

		//region Methods: Public

		/**
		 * @override
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			const propertiesPage = document.createElement("ts-date-time-column-properties-page");
			renderTo.appendChild(propertiesPage);
			MaskHelper.hideBodyMask();
		}

		//endregion

	});
	return Terrasoft.DateTimeColumnPropertiesPageModule;
});
