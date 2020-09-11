define("SysAdminUnitRoleBasePageV2", ["BusinessRuleModule", "SysAdminUnitRoleBasePageV2Resources"],
	function(BusinessRuleModule) {
		return {
			details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"parentName": "UsersTab",
					"name": "LDAPControlGroup",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": []
					}
				},
				{
					"operation": "insert",
					"name": "LDAPGroupBindingContainer",
					"parentName": "LDAPControlGroup",
					"propertyName": "items",
					"index": 0,
					"values": {
						"itemType": this.Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 16
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LDAPGroupBindingContainer",
					"propertyName": "items",
					"name": "SynchronizeWithLDAP",
					"values": {
						"value": "passGroupId",
						"bindTo": "SynchronizeWithLDAP",
						"contentType": this.Terrasoft.ContentType.BOOLEAN,
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 10
						},
						"labelConfig": {
							"caption": { bindTo: "Resources.Strings.SynchronizeWithLDAPCaption"}
						}
					}
				},
				{
					"operation": "insert",
					"name": "LDAPElement",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 14
						},
						"isRequired": {
							"bindTo": "SynchronizeWithLDAP",
							"bindConfig": {
								"converter": function(value) {
									if (!value && this.get("LDAPElement")) {
										this.set("LDAPElement", null);
										return !value;
									} else {
										return value;
									}
								}
							}
						},
						"bindTo": "LDAPElement",
						"caption": {
							"bindTo": "Resources.Strings.LDAPElementCaption"
						},
						"contentType": this.Terrasoft.ContentType.LOOKUP,
						"labelConfig": {
							"visible": true
						},
						"enabled": {"bindTo": "SynchronizeWithLDAP"}
					},
					"parentName": "LDAPGroupBindingContainer",
					"propertyName": "items",
					"index": 1
				}
			]/**SCHEMA_DIFF*/,
			attributes: {
				"LDAPElement": {
					lookupListConfig: {
						filter: function() {
							var filterGroup = new this.Terrasoft.createFilterGroup();
							filterGroup.add("GroupFilter", Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "Type", 3));
							filterGroup.add("NotExists", Terrasoft.createNotExistsFilter("[SysAdminUnit:LDAPElement].Id"));
							filterGroup.add("Active", Terrasoft.createColumnFilterWithParameter(
								this.Terrasoft.ComparisonType.EQUAL, "IsActive", true));
							return filterGroup;
						}
					},
					dependencies: [
						{
							columns: ["LDAPElement"],
							methodName: "passGroupId"
						}
					]
				},
				"ClearLdapLookUp": {
					dependencies: [
						{
							columns: ["SynchronizeWithLDAP"],
							methodName: "clearLDAPField"
						}
					]
				}
			},
			methods: {
				init: function() {
					this.callParent(arguments);
					this.sandbox.subscribe("DetailLoaded", function() {
						this.passGroupId();
					}, this, [this.sandbox.id + "_detail_UsersDetailV2"]);
				},

				onDataChange: function() {
					this.callParent(arguments);
					this.passGroupId();
				},

				passGroupId: function() {
					var isImportEnabled = false;
					var detailAdress = "_detail_UsersDetailV2";
					var ldapElement = this.get("LDAPElement");
					if (ldapElement) {
						var ldapGroupID = ldapElement.value;
						if (ldapGroupID) {
							isImportEnabled = true;
							this.sandbox.publish("IsImportEnabled", {
								id: ldapGroupID,
								isEnabled: isImportEnabled
							}, [this.sandbox.id + detailAdress]);
						}
					}
					else {
						this.sandbox.publish("IsImportEnabled", {
							id: null,
							isEnabled: isImportEnabled
						}, [this.sandbox.id + detailAdress]);
					}
					return ldapElement;
				},

				clearLDAPField: function() {
					var isRequired = this.get("SynchronizeWithLDAP");
					if (!isRequired && this.get("LDAPElement")) {
						this.set("LDAPElement", null);
						return !isRequired;
					}
					else {
						return isRequired;
					}
				}
			},
			messages: {
				"IsImportEnabled": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				},
				"DetailLoaded": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				}
			},
			rules: {
				"LDAPElement": {
					"RequireLDAPElementOnSynchronizeWithLDAP": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.REQUIRED,
						conditions: [
							{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "SynchronizeWithLDAP"
								},
								comparisonType: this.Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: true
								}
							}
						]
					},
					"EnableLDAPElementOnSynchronizeWithLDAP": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [
							{
								leftExpression: {
									type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
									attribute: "SynchronizeWithLDAP"
								},
								comparisonType: this.Terrasoft.ComparisonType.EQUAL,
								rightExpression: {
									type: BusinessRuleModule.enums.ValueType.CONSTANT,
									value: true
								}
							}
						]
					}
				}
			}
		};
	});
