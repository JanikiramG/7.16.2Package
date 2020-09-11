define("BaseReportFilterPage", ["ConfigurationServiceProvider", "FastReportService", "css!BaseReportFilterPageCSS"], function() {
	return {
		messages: {
			"BackHistoryState": {
				"direction": Terrasoft.MessageDirectionType.PUBLISH,
				"mode": Terrasoft.MessageMode.BROADCAST
			},
			"GetReportConfig": {
				"direction": Terrasoft.MessageDirectionType.PUBLISH,
				"mode": Terrasoft.MessageMode.PTP
			}
		},
		
		methods: {

			// region Methods: Private

			/**
			 * @private
			 * @return {Object}
			 */
			_getGenerationConfig: function() {
				const reportConfig = this.publishGetReportConfigMessage();
				const filters = this.getFilters();
				if (!filters) {
					throw new Ext.create("Terrasoft.NullOrEmptyException");
				}
				return {
					templateId: reportConfig.reportId,
					caption: reportConfig.caption,
					entitySchemaName: reportConfig.sectionEntitySchemaName,
					filters: filters
				};
			},

			// endregion

			// region Methods: Protected

			/**
			 * @protected
			 * @return {Object}
			 */
			publishGetReportConfigMessage: function() {
				return this.sandbox.publish("GetReportConfig", null, ["GetReportConfigKey"]);
			},

			/**
			 * Returns report filter.
			 * @protected
			 * @abstract
			 * @return {Terrasoft.FilterGroup}
			 */
			getFilters: Terrasoft.abstractFn,

			// endregion

			// region Methods: Public

			/**
			 * Returns report filter page caption.
			 * @public
			 * @return {String}
			 */
			getReportCaption: function() {
				const reportConfig = this.publishGetReportConfigMessage();
				return reportConfig.caption;
			},

			/**
			 * Generates and downloads report.
			 * @public
			 */
			createReport: function() {
				const fastReportService = Ext.create("Terrasoft.FastReportService");
				fastReportService.generateReport(this._getGenerationConfig());
			},

			/**
			 * Closes report filter page.
			 * @public
			 */
			closePage: function() {
				this.sandbox.publish("BackHistoryState");
			}

			// endregion

		},

		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,

		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,

		diff: /**SCHEMA_DIFF*/[{
			"operation": "insert",
			"name": "MainContainer",
			"values": {
				"id": "MainContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"wrapClass": ["report-filter-page-main-container"],
				"items": []
			}
		}, {
			"operation": "insert",
			"name": "ReportCaptionLabel",
			"parentName": "MainContainer",
			"propertyName": "items",
			"values": {
				"id": "ReportCaptionLabel",
				"itemType": Terrasoft.ViewItemType.LABEL,
				"caption": {"bindTo": "getReportCaption"},
				"classes": {
					"labelClass": ["report-filter-page-caption"]
				}
			}
		}, {
			"operation": "insert",
			"name": "CreateReportButton",
			"parentName": "MainContainer",
			"propertyName": "items",
			"values": {
				"id": "CreateReportButton",
				"itemType": Terrasoft.ViewItemType.BUTTON,
				"style": Terrasoft.controls.ButtonEnums.style.BLUE,
				"caption": {"bindTo": "Resources.Strings.CreateReportButtonCaption"},
				"click": {"bindTo": "createReport"}
			}
		}, {
			"operation": "insert",
			"name": "CancelButton",
			"parentName": "MainContainer",
			"propertyName": "items",
			"values": {
				"id": "CancelButton",
				"itemType": Terrasoft.ViewItemType.BUTTON,
				"caption": {"bindTo": "Resources.Strings.CancelButtonCaption"},
				"click": {"bindTo": "closePage"}
			}
		}, {
			"operation": "insert",
			"name": "FilterContainer",
			"parentName": "MainContainer",
			"propertyName": "items",
			"values": {
				"id": "FilterContainer",
				"itemType": Terrasoft.ViewItemType.CONTAINER,
				"items": [],
				"wrapClass": ["report-filter-page-filter-container"],
			}
		}]/**SCHEMA_DIFF*/
	};
});
