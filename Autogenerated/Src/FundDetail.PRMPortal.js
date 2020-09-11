define("FundDetail", [],
		function() {
	return {
		entitySchemaName: "Fund",
		methods: {

			/**
			 * @inheritDoc BaseGridDetailV2#getAddRecordButtonVisible
			 * @override
			 */
			getAddRecordButtonVisible: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetail#getQuickFilterButton
			 * @override
			 */
			getShowQuickFilterButton: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getGridSortMenuItem
			 * @override
			 */
			getGridSortMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @override
			 */
			getSwitchGridModeMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
			 * @override
			 */
			addDetailWizardMenuItems: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getExportToExcelFileMenuItem
			 * @override
			 */
			getExportToExcelFileMenuItem: function() {
				return Terrasoft.isCurrentUserSsp() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addRecordOperationsMenuItems
			 * @override
			 */
			addRecordOperationsMenuItems: function() {
				if (Terrasoft.isCurrentUserSsp()){
					return;
				}
				this.callParent(arguments);
			}
		}
	};
});
