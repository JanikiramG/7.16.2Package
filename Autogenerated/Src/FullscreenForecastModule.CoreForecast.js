define("FullscreenForecastModule", ["BaseSchemaModuleV2", "FullscreenForecastTab"],
	function() {
		Ext.define("Terrasoft.configuration.FullscreenForecastModule", {
			extend: "Terrasoft.BaseSchemaModule",
			alternateClassName: "Terrasoft.FullscreenForecastModule",

			/**
			 * @inheritdoc BaseSchemaModule#initSchemaName
			 * @override
			 */
			initSchemaName: function() {
				this.schemaName = "FullscreenForecastTab";
			}

		});
		return Terrasoft.FullscreenForecastModule;
	});
