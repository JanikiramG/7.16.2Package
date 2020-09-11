define("OrderProductDetailV2", [],
	function() {
		return {
			entitySchemaName: "OrderProduct",
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
				 * @overridden
				 */
				getCopyRecordMenuItem: function () {
					if (Terrasoft.isCurrentUserSsp()) {
						return false;
					}
					return this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
				 * @overridden
				 */
				getEditRecordMenuItem: function () {
					if (Terrasoft.isCurrentUserSsp()) {
						return false;
					}
					return this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.ProductDetailV2#getAddRecordOperationMenuItem
				 * @overridden
				 */
				getAddRecordOperationMenuItem: function () {
					if (Terrasoft.isCurrentUserSsp()) {
						return false;
					}
					return this.callParent(arguments);
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);
