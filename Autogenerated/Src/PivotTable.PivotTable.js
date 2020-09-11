define("PivotTable", ["PivotTableResources", "PivotTableComponent", "css!PivotTable", "GoogleTagManagerUtilities"],
		function(resources) {
	/**
	 * Component for rendering pivot-table web components
	 */
	Ext.define("Terrasoft.controls.PivotTable", {
		extend: "Terrasoft.controls.Component",
		alternateClassName: "Terrasoft.PivotTable",

		mixins: {
			customEvent: "Terrasoft.mixins.CustomEventDomMixin"
		},

		/**
		 * @protected
		 */
		options: null,

		/**
		 * @protected
		 */
		getControlConfigEventName: "getPivotTableConfig",

		/**
		 * @protected
		 */
		setControlConfigEventName: "setPivotTableConfig",

		/**
		 * @inheritDoc Terrasoft.Component#tpl
		 * @override
		 */
		tpl: [
			/*jshint white:false */
			/*jshint quotmark:true */
			//jscs:disable
			'<div id=\"{id}-wrap\" style=\"{styles}\" class=\"ts-pivot-table-wrapper\">',
			'<ts-pivot-table id=\"{id}\" data-qa=\"pivot-table\">',
			'</ts-pivot-table>',
			'</div>',
			//jscs:enable
			/*jshint quotmark:false */
			/*jshint white:true */
		],

		/**
		 * @inheritDoc
		 * @override
		 */
		init: function() {
			this.callParent(arguments);
			const customEvent = this.mixins.customEvent;
			customEvent.init();
			customEvent
				.subscribe(this.getControlConfigEventName)
				.subscribe(function() {
					const config = this.getControlConfig();
					customEvent.publish(this.setControlConfigEventName, config);
				}.bind(this));
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		initDomEvents: function() {
			this.callParent(arguments);
			const el = this.pivotTableEl;
			if (el) {
				el.on("metricsArrived", this.handleMetricsArrived, this);
			}
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		clearDomListeners: function() {
			this.callParent(arguments);
			const el = this.pivotTableEl;
			if (el) {
				el.un("metricsArrived", this.handleMetricsArrived, this);
			}
		},

		/**
		 * Sends metrics to google tag manager.
		 * @protected
		 * @param {Object} event Browser event object.
		 * @param {Object} event.browserEvent
		 * @param {Object} event.browserEvent.detail
		 * @param {Number} event.browserEvent.detail.dataLoadMs Data loaded time in ms.
		 * @param {Number} event.browserEvent.detail.dataAggregationMs Aggregation time in ms.
		 * @param {Number} event.browserEvent.detail.dataRecordsCount Count of records.
		 * @param {Number} event.browserEvent.detail.executionMs Workflow time in ms.
		 * @param {Boolean} event.browserEvent.detail.success workflow is success.
		 */
		handleMetricsArrived: function(event) {
			const pivotTableMetric = event.browserEvent.detail || {};
			const sendMetric = this.getGoogleTagManagerData(pivotTableMetric);
			Terrasoft.GoogleTagManagerUtilities.actionModule(sendMetric);
		},

		/**
		 * Returns data to send to google tag manager.
		 * @protected
		 * @param {Object} pivotTableMetric
		 * @param {Number} pivotTableMetric.dataLoadMs Data loaded time in ms.
		 * @param {Number} pivotTableMetric.dataAggregationMs Aggregation time in ms.
		 * @param {Number} pivotTableMetric.dataRecordsCount Count of records.
		 * @param {Number} pivotTableMetric.executionMs Workflow time in ms.
		 * @param {Boolean} pivotTableMetric.success Aggregation workflow is success.
		 * @return {Object} Google tag manager data.
		 */
		getGoogleTagManagerData: function(pivotTableMetric) {
			const description = Ext.String.format(
				"dataLoadMs={0},dataAggregationMs={1},success={2}",
				pivotTableMetric.dataLoadMs, pivotTableMetric.dataAggregationMs,
				pivotTableMetric.success
			);
			return {
				moduleName: "DashboardModule",
				schemaName: "PivotTable",
				loadTime: pivotTableMetric.executionMs,
				totalRowsCount: pivotTableMetric.dataRecordsCount,
				description: description
			};
		},

		/**
		 * Returns control configuration.
		 * @protected
		 */
		getControlConfig: function() {
			return {
				resources: resources
			};
		},

		/**
		 * @inheritDoc
		 * @override
		 */
		onDestroy: function() {
			this.mixins.customEvent.destroy();
			this.callParent(arguments);
		},

		/**
		 * @inheritDoc Terrasoft.Component#getSelectors
		 * @override
		 */
		getSelectors: function() {
			return {
				wrapEl: "#" + this.id + "-wrap",
				pivotTableEl: "#" + this.id
			};
		},

		/**
		 * @inheritDoc Terrasoft.Component#getTplData
		 * @override
		 */
		getTplData: function() {
			const tplData = this.callParent(arguments);
			this.selectors = this.getSelectors();
			const pivotTableTplData = {
				options: this.options
			};
			Ext.apply(tplData, pivotTableTplData);
			return tplData;
		},

		/**
		 * @inheritDoc Terrasoft.Component#getBindConfig
		 * @override
		 */
		getBindConfig: function() {
			const bindConfig = this.callParent(arguments);
			const pivotTableBindConfig = {
				options: {
					changeMethod: "setOptions"
				}
			};
			Ext.apply(pivotTableBindConfig, bindConfig);
			return pivotTableBindConfig;
		},

		/**
		 * Sets pivot table options.
		 * @param {Object} options Pivot table options.
		 * @param {String} options.serializeEsq Serialized entity schema query 
		 * for pivot table data source.
		 * @param {Object} options.aggregationOptions Aggregations options.
		 * { 
		 * 		rows: ['column1', 'column2'], 
		 * 		columns: ['column3', 'column4'], 
		 * 		aggregates: [{"aggregationField":"column5","aggregationType":number}]
		 * }
		 */
		setOptions: function(options) {
			if (!options) {
				return;
			}
			this.options = options;
			if (this.rendered) {
				this.setElementOptions();
			}
		},

		/**
		 * @inheritDoc Terrasoft.Component#onAfterRender
		 * @override
		 */
		onAfterRender: function() {
			this.callParent(arguments);
			if (this.options) {
				this.setElementOptions();
			}
		},

		/**
		 * Set pivot element options.
		 * @protected
		 */
		setElementOptions: function() {
			this.pivotTableEl.dom.options = this.options;
		}

	});

	return Terrasoft.PivotTable;

});
