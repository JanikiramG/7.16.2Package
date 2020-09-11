define("EducationAndCertificateDetail", [], function() {
	return {
		entitySchemaName: "EducationActivity",
		attributes: {},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {

			/**
			 * Checks if current user is Ssp user.
			 * //TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
			 * @private
			 * @return {Boolean} True if type of current user is ssp, otherwise - false.
			 */
			_isSspCurrentUser: function() {
				return Terrasoft.CurrentUser.userType === Terrasoft.UserType.SSP;
			},

			/**
			 * @inheritDoc BaseGridDetailV2#getAddRecordButtonVisible
			 * @protected
			 */
			getAddRecordButtonVisible: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return !this._isSspCurrentUser();
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetail#getQuickFilterButton
			 * @overridden
			 */
			getShowQuickFilterButton: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},
			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getCopyRecordMenuItem
			 * @overridden
			 */
			getCopyRecordMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getEditRecordMenuItem
			 * @overridden
			 */
			getEditRecordMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getGridSortMenuItem
			 * @overridden
			 */
			getGridSortMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getDeleteRecordMenuItem
			 * @overridden
			 */
			getDeleteRecordMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getSwitchGridModeMenuItem
			 * @overridden
			 */
			getSwitchGridModeMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#addDetailWizardMenuItems
			 * @overridden
			 */
			addDetailWizardMenuItems: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			},

			/**
			 * @inheritdoc Terrasoft.BaseGridDetailV2#getExportToExcelFileMenuItem
			 * @overridden
			 */
			getExportToExcelFileMenuItem: function() {
				//TODO SD-6008 replace to !Terrasoft.utils.common.isSspCurrentUser() after release 7.14.2
				return this._isSspCurrentUser() ? null : this.callParent(arguments);
			}
		}
	};
});
