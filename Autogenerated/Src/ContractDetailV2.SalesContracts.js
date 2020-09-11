define("ContractDetailV2", [],
function() {
	return {
		entitySchemaName: "Contract",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[],/**SCHEMA_DIFF*/
		methods: {
			/**
			 * ######### ########## ########## ### ###### #######,
			 * ####### ########## ####### # ####### #########.
			 * @override
			 */
			getLookupFilters: function() {
				var config = this.callParent();
				config.filters.addItem(this.Terrasoft.createColumnFilterWithParameter(
					Terrasoft.ComparisonType.EQUAL, "Type.IsSlave", true));
				return config;
			}
		}
	}
});
