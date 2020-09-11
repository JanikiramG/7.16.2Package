define("ProductSelectionSchema", [], function() {
	return {
		methods: {
			/**
			 * @inheritdoc Terrasoft.ProductSelectionSchema#getEditableColumns
			 * @override
			 */
			getEditableColumns: function() {
				let parentColumns = this.callParent(arguments);
				if (this.Terrasoft.isCurrentUserSsp()) {
					parentColumns = this.Terrasoft.without(parentColumns, "Price");
				}
				return parentColumns;
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
