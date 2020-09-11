define("UsrTreatmentprograms1Page", ["ServiceHelper"], function(ServiceHelper) {
	return {
		entitySchemaName: "UsrTreatmentprograms",
		attributes: {
			"MaxActiveDailyPrograms": {
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
        		"dataValueType": Terrasoft.DataValueType.INTEGER,
        		"value": "0"
			},
			"ActiveDailyPrograms": {
        		"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
        		"dataValueType": Terrasoft.DataValueType.INTEGER,
        		"value": "0"
			},
			"TreatmentSessionsCount": {
        		"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
        		"dataValueType": Terrasoft.DataValueType.INTEGER,
        		"value": "0"
			}
		},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "UsrTreatmentprogramsFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "UsrTreatmentprograms"
				}
			},
			"UsrSchemad8b25c6eDetailacae828d": {
				"schemaName": "UsrSchemad8b25c6eDetail",
				"entitySchemaName": "UsrTreatmentsessions",
				"filter": {
					"detailColumn": "UsrTreatmentPrograms",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"UsrOwner": {
				"d818473c-811c-4946-afef-a9bfef8c6307": {
					"uId": "d818473c-811c-4946-afef-a9bfef8c6307",
					"enabled": true,
					"removed": false,
					"ruleType": 1,
					"baseAttributePatch": "Type",
					"comparisonType": 3,
					"autoClean": false,
					"autocomplete": false,
					"type": 0,
					"value": "60733efc-f36b-1410-a883-16d83cab0980",
					"dataValueType": 10
				}
			}
		}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			
			//Calling the Validation Method on Active Field
            setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("UsrIsActive", this.ActiveProgramsValidator);
				this.addColumnValidator("UsrTreatmentprogramfrequency", this.ActiveProgramsValidator);
				},				
				ActiveProgramsValidator: function() {
					
					//System setting Max daily program
					Terrasoft.SysSettings.querySysSettingsItem("UsrMaximumnumberofactivedailysessions",
					function(result) {
						this.set("MaxActiveDailyPrograms",result);
					}, this);
					var MaxActiveDailyProgramsCount= this.get("MaxActiveDailyPrograms");
					var esqresult = "";

					//Entityschemaquery for Treatment program section
					var esq = Ext.create("Terrasoft.EntitySchemaQuery", {rootSchemaName: "UsrTreatmentprograms"});
					esq.addColumn("UsrIsActive", "ActiveRecords");
					esq.addColumn("UsrTreatmentprogramfrequency.Name","PublicationFrequency");
					var esqFirstFilter = esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "UsrIsActive", "true");
					var esqSecondFilter = esq.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "UsrTreatmentprogramfrequency.Name", "Daily");
					esq.filters.add("esqFirstFilter", esqFirstFilter);
					esq.filters.add("esqSecondFilter", esqSecondFilter);
					
					//Aggregation to get the Count of resulting Query
					esq.addAggregationSchemaColumn("UsrIsActive", Terrasoft.AggregationType.COUNT, "ActiveRecords1", Terrasoft.AggregationEvalType.ALL);
					esq.getEntityCollection(function (result) {
						if (!result.success) {
						return;
						}
						esqresult = result.collection.getByIndex(0) != null ? result.collection.getByIndex(0).get("ActiveRecords1") : null;
						this.set("ActiveDailyPrograms",esqresult);
						},this);

						var invalidMessage = "";
						var ActiveDailyProgramsCount = this.get("ActiveDailyPrograms");
						var treatfreq = (this.get("UsrTreatmentprogramfrequency") !== null && this.get("UsrTreatmentprogramfrequency") !== undefined) ? this.get("UsrTreatmentprogramfrequency").displayValue : null;
						var isActive = this.get("UsrIsActive") !== undefined ? this.get("UsrIsActive") : false;						
						if(ActiveDailyProgramsCount >= MaxActiveDailyProgramsCount && treatfreq==="Daily" && isActive===true)
						{
							invalidMessage = this.get("Resources.Strings.ADPValidationMessage");
						}
					return {
						invalidMessage: invalidMessage
					};
				},

				//Action to add new treatment sessions in detail edit page
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

				// Method to call the serive to add new treatment sessions
				CreateTreamentsess: function()
				{
					var tpID = this.$Id;
					if(this.$UsrTreatmentprogramfrequency === "")
					{
						this.showInformationDialog("Please select Treatment Frequency");
						return false;
					}
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

					//Service request
					ServiceHelper.callService("CreateNewTreatmentSessions", "TreatmentSessions",
					function(response) {
						var result = response.CreatePerformancesResult;					
					}, serviceData, this);										
				},

				init: function() {
					this.callParent(arguments);
					Terrasoft.ServerChannel.on(Terrasoft.EventName.ON_MESSAGE, this.onWebSocketMessageReceived, this);
				},

				//Receive the message from back end
				onWebSocketMessageReceived: function(scope, message) {
					if(!message || message.Header.Sender !== "JKR")
					{
						return;
					}
					if(message.Body === "RefereshUI")
					{
						this.reloadEntity();
						this.showInformationDialog("Treatment sessions are added successfully.");
					}
				}
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "UsrNamed365d85f-214c-4a2e-beb9-1193ed1d0bea",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrName",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "STRING935b6f3c-ea46-44bc-9da0-edbae0eb98de",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrTitle",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "STRING4572935d-0ca1-40d6-8c2a-41c4aa30ca59",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrCode",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LOOKUPbeb226bc-e003-4416-b6a6-e179018f6728",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrTreatmentprogramfrequency",
					"enabled": true,
					"contentType": 5
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "LOOKUPa8dda024-2120-4a9d-8d05-02f8b82c5f61",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrOwner",
					"enabled": true,
					"contentType": 5
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "STRINGe1e834ec-26c5-44ca-b22c-845313fd35df",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrNotes1",
					"enabled": true,
					"contentType": 0
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "BOOLEAN01884d8f-e9c8-4876-b99c-c162076763b3",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "UsrIsActive",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "Tab0bbaf39aTabLabel",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.Tab0bbaf39aTabLabelTabCaption"
					},
					"items": [],
					"order": 0
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "UsrSchemad8b25c6eDetailacae828d",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "Tab0bbaf39aTabLabel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesAndFilesTabCaption"
					},
					"items": [],
					"order": 1
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Files",
				"values": {
					"itemType": 2
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "NotesControlGroup",
				"values": {
					"itemType": 15,
					"caption": {
						"bindTo": "Resources.Strings.NotesGroupCaption"
					},
					"items": []
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "Notes",
				"values": {
					"bindTo": "UsrNotes",
					"dataValueType": 1,
					"contentType": 4,
					"layout": {
						"column": 0,
						"row": 0,
						"colSpan": 24
					},
					"labelConfig": {
						"visible": false
					},
					"controlConfig": {
						"imageLoaded": {
							"bindTo": "insertImagesToNotes"
						},
						"images": {
							"bindTo": "NotesImagesCollection"
						}
					}
				},
				"parentName": "NotesControlGroup",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 2
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
