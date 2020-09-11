define("PortalOrderSection", [],
	function() {
		return {
			entitySchemaName: "Order",
			attributes: {},
			messages: {},
			mixins: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSectionV2#getDefaultDataViews
				 * @override
				 */
				getDefaultDataViews: function() {
					const dataViews = this.callParent(arguments);
					delete dataViews.AnalyticsDataView;
					return dataViews;
				}
			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	});
