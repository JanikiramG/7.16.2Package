define("FastReportService", ["ConfigurationServiceProvider"], function() {

	Ext.define("Terrasoft.configuration.FastReportService", {
		extend: "Terrasoft.BaseObject",
		alternateClassName: "Terrasoft.FastReportService",

		// region Fields: Private

		/**
		 * @type {Number}
		 */
		_reportDownloadTimeout: 20 * 60 * 1000,

		// endregion

		// region Methods: Private

		/**
		 * @private
		 * @param {Object} generationConfig
		 * @param {String} generationConfig.templateId
		 * @param {String} generationConfig.caption
		 * @param {String} generationConfig.entitySchemaName
		 * @param {Terrasoft.FilterGroup} generationConfig.filters
		 * @return {Object}
		 */
		_createFastReportServiceRequest: function(generationConfig) {
			return {
				serviceName: "FastReportService",
				methodName: "CreateReport",
				data: {
					reportTemplateId: generationConfig.templateId,
					reportCaption: generationConfig.caption,
					reportSchemaName: generationConfig.entitySchemaName,
					reportFilters: generationConfig.filters.serialize()
				},
				timeout: this._reportDownloadTimeout
			};
		},

		/**
		 * @private
		 * @param {String} caption
		 * @param {String} key
		 */
		_downloadReport: function(caption, key) {
			const report = document.createElement("a");
			report.href = "../rest/FastReportService/GetReportFile/" + key;
			report.download = caption + ".pdf";
			if (Ext.isIE) {
				report.target = "_blank";
			}
			document.body.appendChild(report);
			report.click();
			document.body.removeChild(report);
		},

		//endregion

		// region Methods: Public

		/**
		 * Generates and downloads report by schema UId and filters.
		 * @public
		 * @param {Object} generationConfig
		 * @param {String} generationConfig.templateId
		 * @param {String} generationConfig.caption
		 * @param {String} generationConfig.entitySchemaName
		 * @param {Terrasoft.FilterGroup} generationConfig.filters
		 * @param {Function} callback
		 * @param {Object} scope
		 */
		generateReport: function(generationConfig, callback, scope) {
			const request = this._createFastReportServiceRequest(generationConfig);
			Terrasoft.ConfigurationServiceProvider.callService(request, function(response) {
				this._downloadReport(generationConfig.caption, response.CreateReportResult);
				Ext.callback(callback, scope);
			}, this);
		},

		//endregion
	});

	return Terrasoft.FastReportService;
});
