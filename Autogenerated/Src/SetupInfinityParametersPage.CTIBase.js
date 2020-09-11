define("SetupInfinityParametersPage", ["terrasoft", "SetupCallCenterUtilities"],
	function(Terrasoft, SetupCallCenterUtilities) {
		return {
			attributes: {

				/**
				 * ##### ####### Infinity.
				 * @type {String}
				 */
				"ServerAddress": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true,
					"value": ""
				},

				/**
				 * ### ##### Infinity.
				 * @type {String}
				 */
				"Line": {
					"dataValueType": Terrasoft.DataValueType.TEXT,
					"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					"isRequired": true,
					"value": ""
				}
			},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSetupTelephonyParametersPage#init.
				 * @overridden
				 */
				init: function(callback, scope) {
					this.callParent(arguments);
				},

				/**
				 * ########## ###### ############ ########## #########.
				 * ##### - ######## ######### #####, ######## - ######### ###########.
				 * @protected
				 * @overridden
				 * @returns {Object} ###### ############ ########## #########.
				 */
				getConnectionParamsConfig: function() {
					var baseConnectionParams = this.callParent();
					return Ext.merge(baseConnectionParams, {
						"ServerAddress": "ConnectionString",
						"Line": "Line"
					});
				}

			},
			diff: [
				{
					"operation": "insert",
					"parentName": "controlsContainer",
					"propertyName": "items",
					"name": "ServerAddress",
					"values": {
						"isRequired": true,
						"generator": "SetupCallCenterUtilities.generateTextEdit"
					}
				},
				{
					"operation": "insert",
					"parentName": "controlsContainer",
					"propertyName": "items",
					"name": "Line",
					"values": {
						"isRequired": true,
						"generator": "SetupCallCenterUtilities.generateTextEdit"
					}
				}
			]
		};
	});
