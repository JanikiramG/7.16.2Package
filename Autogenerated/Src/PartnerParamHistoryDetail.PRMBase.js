define("PartnerParamHistoryDetail", [], function() {
	return {
		entitySchemaName: "PartnerParamHistory",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "remove",
				"name": "AddRecordButton"
			}
		]/**SCHEMA_DIFF*/,
		methods: {
			getCopyRecordMenuItem: Terrasoft.emptyFn,
			getEditRecordMenuItem: Terrasoft.emptyFn,
			getDeleteRecordMenuItem: Terrasoft.emptyFn,
			getGridSettingsMenuItem: Terrasoft.emptyFn,
			addDetailWizardMenuItems: Terrasoft.emptyFn
		}
	};
});
