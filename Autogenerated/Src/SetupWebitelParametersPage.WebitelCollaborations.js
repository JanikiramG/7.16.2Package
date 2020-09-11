define("SetupWebitelParametersPage", ["terrasoft"],
	function(Terrasoft) {
		return {
			attributes: {

				/**
				 * Auto-connection.
				 * @type {Boolean}
				 */
				"IsAutoLogin": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				},

				/**
				 * Use Webitel CTI.
				 * @type {Boolean}
				 */
				"UseWebitelCti": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				},

				/**
				 * Use Web phone.
				 * @type {Boolean}
				 */
				"UseWebPhone": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": true
				},

				/**
				 * Use incoming call ring notification.
				 * @type {Boolean}
				 */
				"UseNotificationSound": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": true
				},

				/**
				 * Use video.
				 * @type {Boolean}
				 */
				"UseVideo": {
					"dataValueType": Terrasoft.DataValueType.BOOLEAN,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"value": false
				}
			},
			methods: {

				/**
				 * @inheritdoc BaseSetupTelephonyParametersPage#init
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent([function() {
						this.on("change:UseWebPhone", this.onUseWebPhoneChanged);
						callback.call(scope || this);
					}, this]);
				},

				/**
				 * Processes change of the field "Use web phone".
				 * @param {Backbone.Model} model Model.
				 * @param {Boolean} useWebPhone Value of "Use Web Phone" field.
				 */
				onUseWebPhoneChanged: function(model, useWebPhone) {
					if (!useWebPhone) {
						this.set("UseVideo", false);
						this.set("UseNotificationSound", false);
					}
				},

				/**
				 * @inheritdoc BaseSetupTelephonyParametersPage#getConnectionParamsConfig
				 * @overridden
				 */
				getConnectionParamsConfig: function() {
					var baseConnectionParams = this.callParent();
					return Ext.merge(baseConnectionParams, {
						"IsAutoLogin": "isAutoLogin",
						"UseWebitelCti": "useWebitelCti",
						"UseWebPhone": "useWebPhone",
						"UseNotificationSound": "useNotificationSound",
						"UseVideo": "useVideo"
					});
				}
			},
			diff: [
				{
					"operation": "insert",
					"parentName": "controlsContainerBottom",
					"propertyName": "items",
					"name": "IsAutoLogin",
					"values": {
						"generator": "SetupCallCenterUtilities.generateBottomCheckBoxControl"
					}
				},
				{
					"operation": "insert",
					"parentName": "controlsContainerBottom",
					"propertyName": "items",
					"name": "UseWebitelCti",
					"values": {
						"generator": "SetupCallCenterUtilities.generateBottomCheckBoxControl",
						"visible": false
					}
				},
				{
					"operation": "insert",
					"parentName": "controlsContainerBottom",
					"propertyName": "items",
					"name": "UseWebPhone",
					"values": {
						"generator": "SetupCallCenterUtilities.generateBottomCheckBoxControl"
					}
				},
				{
					"operation": "insert",
					"parentName": "controlsContainerBottom",
					"propertyName": "items",
					"name": "UseNotificationSound",
					"values": {
						"generator": "SetupCallCenterUtilities.generateBottomCheckBoxControl",
						"enabled": {"bindTo": "UseWebPhone"}
					}
				},
				{
					"operation": "insert",
					"parentName": "controlsContainerBottom",
					"propertyName": "items",
					"name": "UseVideo",
					"values": {
						"generator": "SetupCallCenterUtilities.generateBottomCheckBoxControl",
						"visible": true,
						"enabled": {"bindTo": "UseWebPhone"}
					}
				}
			]
		};
	});
