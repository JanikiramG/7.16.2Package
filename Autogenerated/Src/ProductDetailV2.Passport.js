define("ProductDetailV2", ["terrasoft", "OrderUtilities"], function() {
		return {
			mixins: {
				OrderUtilities: "Terrasoft.OrderUtilities"
			},
			methods: {
				/**
				 * @inheritdoc Terrasoft.GridUtilitiesV2#createViewModel
				 * @param {Object} config
				 * @overridden
				 */
				createViewModel: function(config) {
					this.callParent(arguments);
					this.updateViewModel(config.viewModel);
				},

				/**
				 * Modifies view model for editable section
				 * Wraps save method for OrderProductDetailV2
				 * @param {Terrasoft.BasePageV2} viewModel
				 * @private
				 */
				updateViewModel: function(viewModel) {
					if (this.entitySchemaName !== "OrderProduct") {
						return;
					}
					viewModel.save = this.needToChangeInvoice({
						getId: function() {
							return this.get("Order") && this.get("Order").value;
						},
						name: "Order",
						validateColumns: ["TotalAmount"]
					}, viewModel.save.bind(viewModel), this);
				}
			}
		};
	}
);
