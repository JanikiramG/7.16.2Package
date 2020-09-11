define("PortalSupplyPaymentProductDetailModalBox", [], function() {
	return {
		entitySchemaName: "VwSupplyPaymentProduct",
		methods: {
			/**
			 * @inheritdoc Terrasoft.ConfigurationGridUtilities#getCellControlsConfig
			 * @override
			 */
			getCellControlsConfig: function() {
				const controlsConfig = this.callParent(arguments);
				this.Ext.apply(controlsConfig, {
					enabled: false
				});
				return controlsConfig;
			}
		},
		diff: /**SCHEMA_DIFF*/[{
			"operation": "remove",
			"name": "okButton"
		}, {
			"operation": "remove",
			"name": "cancelButton"
		}]/**SCHEMA_DIFF*/
	};
});
