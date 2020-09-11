/**
 * Edit page schema of process element Call user task.
 * Parent: BaseActivityUserTaskPropertiesPage
 */
define("CallUserTaskPropertiesPage", [], function() {
	return {
		methods: {
			/**
			 * @inheritDoc ProcessFlowElementPropertiesPage#getResultParameterAllValues
			 * @overridden
			 */
			getResultParameterAllValues: function(callback, scope) {
				var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "ActivityCategoryResultEntry"
				});
				esq.addColumn("ActivityResult.Id", "ActivityResultId");
				esq.addColumn("ActivityResult.Name", "ActivityResultName");
				var filter = esq.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL,
					"ActivityCategory.ActivityType.Code", "Call", this.Terrasoft.DataValueType.TEXT);
				esq.filters.add("CodeFilter", filter);
				esq.execute(function(result) {
					var resultParameterValues = {};
					if (result.success === true) {
						result.collection.each(function(item) {
							var id = item.get("ActivityResultId");
							var name = item.get("ActivityResultName");
							resultParameterValues[id] = name;
						});
					}
					callback.call(scope, resultParameterValues);
				});
			}
		},
		diff: []
	};
});
