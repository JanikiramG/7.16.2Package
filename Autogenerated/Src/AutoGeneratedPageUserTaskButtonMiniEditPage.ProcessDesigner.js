﻿/**
 * Parent: BaseProcessMiniEditPage
 */
define("AutoGeneratedPageUserTaskButtonMiniEditPage", ["terrasoft",
		"AutoGeneratedPageUserTaskButtonMiniEditPageResources"],
	function(Terrasoft, resources) {
	return {
		attributes: {
			/**
			 * Title of button.
			 * @type {Terrasoft.dataValueType.TEXT}
			 */
			"Caption": {
				"dataValueType": this.Terrasoft.DataValueType.TEXT,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.NameCaption,
				"isRequired": true
			},
			/**
			 * Code of button
			 * @type {Terrasoft.dataValueType.TEXT}
			 */
			"Name": {
				"dataValueType": this.Terrasoft.DataValueType.TEXT,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.CodeCaption,
				"isRequired": true
			},
			/**
			 * Style of button.
			 * @type {Terrasoft.dataValueType.LOOKUP}
			 */
			"Style": {
				"dataValueType": this.Terrasoft.DataValueType.LOOKUP,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.StyleCaption,
				"isRequired": true
			},
			/**
			 * Signal of button.
			 * @type {Terrasoft.dataValueType.TEXT}
			 */
			"GenerateSignal": {
				"dataValueType": this.Terrasoft.DataValueType.TEXT,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.GenerateSignalCaption
			},
			/**
			 * Enabled property of button.
			 * @type {Terrasoft.dataValueType.BOOLEAN}
			 */
			"IsEnabled": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.IsEnabledCaption,
				"doAutoSave": true,
				"initMethod": "initProperty"
			},
			/**
			 * Perform validation property of button.
			 * @type {Terrasoft.dataValueType.BOOLEAN}
			 */
			"PerformValidation": {
				"dataValueType": this.Terrasoft.DataValueType.BOOLEAN,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
				"caption": resources.localizableStrings.PerformValidationCaption,
				"doAutoSave": true,
				"initMethod": "initProperty"
			},
			/**
			 * Parent view model's collection.
			 * @type {Terrasoft.dataValueType.COLLECTION}
			 */
			"ParentCollection": {
				"dataValueType": this.Terrasoft.DataValueType.COLLECTION,
				"type": this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		methods: {
			//region Methods: Protected

			/**
			 * The event handler for preparing of the data drop-down StyleList.
			 * @protected
			 * @param {Object} filter Filters for data preparation.
			 * @param {Terrasoft.Collection} list The data for the drop-down list.
			 */
			prepareStyleList: function(filter, list) {
				if (!list) {
					return;
				}
				list.clear();
				list.loadAll(this.get("StyleCollection"));
			},

			/**
			 * @inheritdoc BaseSchemaViewModel#setValidationConfig
			 * @overridden
			 */
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("Name", this.nameValidator);
				this.addColumnValidator("Name", this.duplicateValueValidator);
				this.addColumnValidator("Caption", this.duplicateValueValidator);
			}

			//endregion
		},
		diff: /**SCHEMA_DIFF*/ [{
			"operation": "insert",
			"parentName": "Controls",
			"propertyName": "items",
			"name": "Caption",
			"values": {
				"itemType": this.Terrasoft.ViewItemType.TEXT,
				"value": {
					"bindTo": "Caption"
				},
				"isRequired": true,
				"classes": {
					"labelClass": ["t-label-proc"]
				},
				"layout": {
					"column": 0,
					"row": 0,
					"colSpan": 24
				},
				"wrapClass": ["top-caption-control"]
			}
		}, {
			"operation": "insert",
			"parentName": "Controls",
			"propertyName": "items",
			"name": "Name",
			"values": {
				"itemType": this.Terrasoft.ViewItemType.TEXT,
				"value": {
					"bindTo": "Name"
				},
				"isRequired": true,
				"classes": {
					"labelClass": ["t-label-proc"]
				},
				"layout": {
					"column": 0,
					"row": 1,
					"colSpan": 24
				},
				"wrapClass": ["top-caption-control"]
			}
		},
		{
			"operation": "insert",
			"name": "Style",
			"parentName": "Controls",
			"propertyName": "items",
			"values": {
				"contentType": this.Terrasoft.ContentType.ENUM,
				"controlConfig": {
					"prepareList": {
						"bindTo": "prepareStyleList"
					}
				},
				"layout": {
					"column": 0,
					"row": 2,
					"colSpan": 24
				},
				"wrapClass": ["top-caption-control"]
			}
		},
		{
			"operation": "insert",
			"parentName": "Controls",
			"propertyName": "items",
			"name": "GenerateSignal",
			"values": {
				"itemType": this.Terrasoft.ViewItemType.TEXT,
				"value": {
					"bindTo": "GenerateSignal"
				},
				"classes": {
					"labelClass": ["t-label-proc"]
				},
				"layout": {
					"column": 0,
					"row": 3,
					"colSpan": 24
				},
				"wrapClass": ["top-caption-control"]
			}
		},
		{
			"operation": "insert",
			"parentName": "Controls",
			"propertyName": "items",
			"name": "IsEnabled",
			"values": {
				"layout": {
					"column": 0,
					"row": 4,
					"colSpan": 24
				},
				"wrapClass": ["t-checkbox-control"]
			}
		},
		{
			"operation": "insert",
			"parentName": "Controls",
			"propertyName": "items",
			"name": "PerformValidation",
			"values": {
				"layout": {
					"column": 0,
					"row": 5,
					"colSpan": 24
				},
				"wrapClass": ["t-checkbox-control"]
			}
		}] /**SCHEMA_DIFF*/
	};
});
