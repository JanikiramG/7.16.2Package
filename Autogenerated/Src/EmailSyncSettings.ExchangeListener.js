﻿define("EmailSyncSettings", ["ExchangeNUIConstants"],
		function(ExchangeNUIConstants) {
	return {
		entitySchemaName: "MailboxSyncSettings",
		methods: {

			//region Methods: Private

			/**
			 * Returns listener service method name.
			 * @private
			 * @return {String} Listener service method name.
			 */
			_getListenerMethodName: function() {
				let hasFolders = true;
				if (!this.$LoadAllEmailsFromMailBox) {
					let selectedFolders = this.getSelectedFoldersTree(this.$FoldersGridData, "SelectedRows");
					hasFolders = selectedFolders.getCount() > 1;
				}
				return this.$EnableMailSynhronization && hasFolders ? "RecreateListener" : "StopListener";
			},

			//endregion

			//region Methods: Protected

			/**
			 * Returns true, if "ExchangeListenerEnabled" feature is disabled, false - otherwise.
			 * @protected
			 * @return True, if "ExchangeListenerEnabled" feature is disabled, false - otherwise.
			 */
			isExchangeListenerFeatureDisabled: function() {
				return !((this.getIsFeatureEnabled("ExchangeListenerEnabled")
					&& this.$ServerTypeId === ExchangeNUIConstants.MailServer.Type.Exchange)
					|| (this.getIsFeatureEnabled("ExchangeListenerEnabled")
						&& this.getIsFeatureEnabled("EmailIntegrationV2")
						&& this.$ServerTypeId === ExchangeNUIConstants.MailServer.Type.Imap));
			},

			/**
			 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
			 * @overridden
			 */
			init: function(callback, scope) {
				this.callParent([function() {
					this.Ext.callback(callback, scope || this);
					this.setUpOriginalSettings();
				}, this]);
			},

			/**
			 * @inheritdoc Terrasoft.BaseSyncSettingsTab#onSaved
			 * @overridden
			 */
			onSaved: function(callback, scope) {
				if (!this.isExchangeListenerFeatureDisabled()) {
					this.$AutomaticallyAddNewEmails = false;
				}
				this.callParent(arguments);
				if (this.isExchangeListenerFeatureDisabled()) {
					this.Ext.callback(callback, scope || this);
					return;
				}
				if (!this.Ext.Object.equals(this.$OriginalMailSyncPeriod, this.$MailSyncPeriod) ||
						this.$OriginalLoadAllEmailsFromMailBox !== this.$LoadAllEmailsFromMailBox ||
						!this.Ext.Array.equals(this.$OriginalSelectedRows, this.$SelectedRows) ||
						this.$OriginalEnableMailSynhronization !== this.$EnableMailSynhronization) {
					this.Terrasoft.chain(
						this.recreateListener,
						this.createEmailSyncJob,
						this.setUpOriginalSettings,
						function () {
							if (callback) {
								callback.call(scope || this);
							}
					}, this);
				}
			},

			/**
			 * Recreates exchange server subscriptions.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			recreateListener: function(callback, scope) {
				this.callService({
					serviceName: "ExchangeEventsService",
					methodName: this._getListenerMethodName(),
					data: {
						"mailboxId": this.$Id
					}
				}, callback, scope || this);
			},

			/**
			 * Creates email synchronization job.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			createEmailSyncJob: function(callback, scope) {
				if (!this.$EnableMailSynhronization) {
					this.Ext.callback(callback, scope || this);
					return;
				}
				this.callService({
					serviceName: "MailboxSettingsService",
					methodName: "CreateEmailSyncJob",
					data: {
						create: true,
						interval: 0,
						serverId: this.$MailServer.value,
						senderEmailAddress: this.$SenderEmailAddress
					}
				}, callback, scope || this);
			},

			/**
			 * Sets up original mailbox settings.
			 * @protected
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			setUpOriginalSettings: function(callback, scope) {
				this.$SelectedRows = this.$SelectedRows || [];
				this.$OriginalMailSyncPeriod = this.$MailSyncPeriod;
				this.$OriginalSelectedRows = this.$SelectedRows;
				this.$OriginalLoadAllEmailsFromMailBox = this.$LoadAllEmailsFromMailBox;
				this.$OriginalEnableMailSynhronization = this.$EnableMailSynhronization;
				this.Ext.callback(callback, scope || this);
			}

			//endregion

		},
		diff: [{
			"operation": "merge",
			"name": "AutomaticallyAddNewEmails",
			"values": {
				"visible": {"bindTo": "isExchangeListenerFeatureDisabled"}
			}
		}]
	};
});
