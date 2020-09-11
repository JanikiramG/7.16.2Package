define("BasePageV2", [], function() {
	return {
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		messages: {},
		mixins: {},
		methods: {

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onSaved
			 * @overridden
			 */
			onSaved: function() {
				this.setDuplicates(this.Terrasoft.emptyFn);
				this.callParent(arguments);
			}
		},
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
	};
});
