(function() {
	require.config({
		paths: {
			"page-wizard-component": Terrasoft.getFileContentUrl("DesignerTools", "src/js/page-wizard-component.js"),
			"DateTimeColumnPropertiesPageModule": Terrasoft.getFileContentUrl("DesignerTools", "src/js/DateTimeColumnPropertiesPageModule.js")
		},
		shim: {
			"page-wizard-component": {
				deps: ["ng-core"]
			}
		}
	});
}());
