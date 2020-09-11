define("QualifyStatusInLeadDetailV2", function() {
	return {
		entitySchemaName: "LeadInQualifyStatus",
		methods: {
			/**
			 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilters
			 * @override
			 */
			getFilters: function() {
				const filters = this.callParent();
				filters.add("isDisplayedFilter",
					this.Terrasoft.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "QualifyStatus.IsDisplayed", true
					)
				);
				return filters;
			},

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#addRecordOperationsMenuItems
			 * @override
			 */
			addRecordOperationsMenuItems: this.Terrasoft.emptyFn,

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#getAddRecordButtonVisible
			 * @override
			 */
			getAddRecordButtonVisible: function() {
				return false;
			},

			/**
			 * @inheritDoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @override
			 */
			getSwitchGridModeMenuItem: this.Terrasoft.emptyFn,

			/**
			 * @inheritDoc Terrasoft.GridUtilitiesV2#getFilterDefaultColumnName
			 * @override
			 */
			getFilterDefaultColumnName: function() {
				return "QualifyStatus";
			}
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "DataGrid",
				"values": {
					"primaryDisplayColumnName": "QualifyStatus",
					"type": "listed"
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
