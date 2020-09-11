define("PortalSupplyPaymentDetailV2", [],
	function() {
		return {
			entitySchemaName: "SupplyPaymentElement",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetail#getAddTypedRecordButtonVisible
				 */
				getAddTypedRecordButtonVisible: function() {
					return false;
				},

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
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#getModuleInfoResponse
				 * @override
				 */
				getModuleInfoResponse: function() {
					const parentResponse = this.callParent(arguments);
					parentResponse.schemaName = "PortalSupplyPaymentProductDetailModalBox";
					return parentResponse;
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#getModalBoxProductDetailId
				 * @override
				 */
				getModalBoxProductDetailId: function() {
					return this.sandbox.id + "_PortalSupplyPaymentProductDetailModalBox";
				},

				/**
				 * @inheritdoc Terrasoft.SupplyPaymentDetailV2#onClearProductsButtonClick
				 * @override
				 */
				onClearProductsButtonClick: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
				 * @override
				 */
				getDeleteRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @override
				 */
				getCopyRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @override
				 */
				getEditRecordMenuItem: this.Terrasoft.emptyFn,

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
				 * @override
				 */
				getSwitchGridModeMenuItem: this.Terrasoft.emptyFn
			},
			diff: [
				{
					"operation": "remove",
					"name": "activeRowActionSave"
				},
				{
					"operation": "remove",
					"name": "activeRowActionOpenCard"
				},
				{
					"operation": "remove",
					"name": "activeRowActionCancel"
				},
				{
					"operation": "remove",
					"name": "activeRowActionRemove"
				}
			]
		};
	}
);
