define("UsrTreatmentprograms1ad45794Section", ["ServiceHelper"], function(ServiceHelper) {
	return {
		entitySchemaName: "UsrTreatmentprograms",
			attributes: {			
			"PerformancesCount": {
        		"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
        		"dataValueType": Terrasoft.DataValueType.INTEGER,
        		"value": "0"
			}
		},
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {

			//Action to create new treatment sessions.
			getActions: function() 
				{
				var actionMenuItems = this.callParent(arguments);
					actionMenuItems.addItem(this.getButtonMenuItem({
						Type: "Terrasoft.MenuSeparator",
						Caption: ""
					}));
					actionMenuItems.addItem(this.getButtonMenuItem({
						"Caption": {bindTo: "Resources.Strings.CreateTreatSessions"},
						"Tag": "CreateTreamentsess"
					}));
					return actionMenuItems;
				},

				//Call the service
				CreateTreamentsess: function()
				{
					var tpID = this.$Id;
					var tpFrequency = this.$UsrTreatmentprogramfrequency.displayValue;

					// System setting to get the number of records to count
					Terrasoft.SysSettings.querySysSettingsItem("UsrNewTreatmentsessions",
					function(result) {
						this.set("TreatmentSessionsCount",result);
					}, this);
					var tsessionCount= this.get("TreatmentSessionsCount");
					
					var serviceData = {
						tpID: tpID,
						tpFrequency: tpFrequency,
						tsessionCount: tsessionCount
					};
					ServiceHelper.callService("CreateNewTreatmentSessions", "TreatmentSessions",
					function(response) {
						var result = response.CreatePerformancesResult;					
					}, serviceData, this);										
				}
		}
	};
});
