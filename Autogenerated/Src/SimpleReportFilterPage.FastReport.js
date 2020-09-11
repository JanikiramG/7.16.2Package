define("SimpleReportFilterPage", ["css!SimpleReportFilterPageCSS"], function() {
	return {

		attributes: {
			"FilterCategory": {
				dataValueType: Terrasoft.DataValueType.TEXT,
				value: "FormBySelected"
			}
		},

		messages: {
			"GetFiltersCollection": {
				"direction": Terrasoft.MessageDirectionType.PUBLISH,
				"mode": Terrasoft.MessageMode.PTP
			}
		},

		methods: {

			// region Methods: Private

			/**
			 * @private
			 * @return {Terrasoft.FilterGroup}
			 */
			_createFilterBySelectedRecords: function() {
				const reportConfig = this.publishGetReportConfigMessage();
				const activeRow = reportConfig.activeRow;
				const selectedRows = reportConfig.selectedRows;
				const primaryColumnName = reportConfig.sectionEntitySchemaPrimaryColumnName;
				if (activeRow) {
					return Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, primaryColumnName, activeRow);
				}
				if (selectedRows && selectedRows.length > 0) {
					return Terrasoft.createColumnInFilterWithParameters(primaryColumnName, selectedRows);
				}
				return Terrasoft.createColumnIsNullFilter(primaryColumnName);
			},

			/**
			 * @private
			 * @return {Integer}
			 */
			_getSelectedRowsCount: function() {
				const reportConfig = this.publishGetReportConfigMessage();
				const activeRow = reportConfig.activeRow;
				const selectedRows = reportConfig.selectedRows;
				if (activeRow) {
					return 1;
				}
				if (selectedRows && selectedRows.length > 0) {
					return selectedRows.length;
				}
				return 0;
			},

			_getSelectdRowFilter: function() {
				const filterGroup = Ext.create("Terrasoft.FilterGroup");
				filterGroup.addItem(this._createFilterBySelectedRecords());
				return filterGroup;
			},

			// endregion

			// region Methods: Protected

			/**
			 * @inheritdoc Terrasoft.BaseReportFilterPage#getFilters.
			 * @overridden
			 */
			getFilters: function() {
				switch (this.$FilterCategory) {
					case "FormBySelected":
						return this._getSelectdRowFilter();
					case "FormByFiltered":
						return this.sandbox.publish("GetFiltersCollection");
					case "FormByAll":
						return Ext.create("Terrasoft.FilterGroup");
					default:
						throw new Ext.create("Terrasoft.InvalidOperationException");
				}
			},

			// endregion

			// region Methods: Public

			/**
			 * Fills number of rows in label caption.
			 * @public
			 * @param {String} value
			 * @return {String}
			 */
			formatFormBySelectedLabelCaption: function(value) {
				const selectedRowsCount = this._getSelectedRowsCount();
				return Ext.String.format(value, selectedRowsCount);
			}

			// endregion

		},

		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,

		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,

		diff: /**SCHEMA_DIFF*/[{
			"operation": "insert",
			"name": "FormByLabel",
			"parentName": "FilterContainer",
			"propertyName": "items",
			"values": {
				"id": "FormByLabel",
				"itemType": Terrasoft.ViewItemType.LABEL,
				"caption": {"bindTo": "Resources.Strings.FormByLabel"},
				"classes": {
					"labelClass": ["report-filter-page-filter-area-caption"]
				}
			}
		}, {
			"operation": "insert",
			"name": "FilterRadioGroup",
			"parentName": "FilterContainer",
			"propertyName": "items",
			"values": {
				"itemType": Terrasoft.ViewItemType.RADIO_GROUP,
				"value": {"bindTo": "FilterCategory"},
				"items": [{
					"name": "FormBySelectedRadioButton",
					"caption": {
						"bindTo": "Resources.Strings.FormBySelectedLabel",
						"bindConfig": {"converter": "formatFormBySelectedLabelCaption"}
					},
					"value": "FormBySelected"
				}, {
					"name": "FormByFilteredRadioButton",
					"caption": {"bindTo": "Resources.Strings.FormByFilteredLabel"},
					"value": "FormByFiltered"
				}, {
					"name": "FormByAllRadioButton",
					"caption": {"bindTo": "Resources.Strings.FormByAllLabel"},
					"value": "FormByAll"
				}]
			}
		}]/**SCHEMA_DIFF*/
	};
});
