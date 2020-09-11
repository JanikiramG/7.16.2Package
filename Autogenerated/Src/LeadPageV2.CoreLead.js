define("LeadPageV2", ["LeadPageV2Resources", "BaseFiltersGenerateModule", "ProcessModuleUtilities",
		"LeadConfigurationConst", "ServiceHelper", "BusinessRuleModule", "ConfigurationEnums", "ConfigurationConstants",
		"BaseProgressBarModule", "EntityHelper", "LeadManagementUtilities",
		"css!BaseProgressBarModule", "css!LeadPageV2CSS", "SearchInInternetUtilities"],
	function(resources, BaseFiltersGenerateModule, ProcessModuleUtilities, LeadConfigurationConst, ServiceHelper,
			BusinessRuleModule, enums, ConfigurationConstants) {
		return {
			entitySchemaName: "Lead",
			mixins: {
				EntityHelper: "Terrasoft.EntityHelper",
				SearchInInternetUtilities: "Terrasoft.SearchInInternetUtilities"
			},
			attributes: {
				"LeadTypeStatus": {
					isRequired: true
				},
				"QualifyStatus": {
					lookupListConfig: {
						columns: ["Name", "StageNumber"]
					}
				},

				"UseProcessLeadManagement": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.BOOLEAN
				},
				/**
				 * Caption of the Qualification button.
				 */
				"QualificationProcessButtonCaption": {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.TEXT
				},
				/**
				 * Determines when keep the load mask visible.
				 */
				"LockBodyMask": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				},
				"QualifiedAccount": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					dependencies: [{
						columns: ["QualifiedContact"],
						methodName: "onQualifiedContactChanged"
					}]
				},
				/**
				 * Deduplication feature enabled flag.
				 */
				"IsDeduplicationEnabled": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				},
				"LeadManagementButtonVisible": {
					dataValueType: this.Terrasoft.DataValueType.BOOLEAN,
					type: this.Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: false
				}
			},
			details: /**SCHEMA_DETAILS*/{
				LeadsSimilarSearchResult: {
					schemaName: "LeadsSimilarSearchResultDetailV2",
					entitySchemaName: "Lead",
					filter: {
						masterColumn: "Id",
						detailColumn: "Id"
					}
				},
				SpecificationInLead: {
					schemaName: "LeadSpecificationDetailV2",
					entitySchemaName: "SpecificationInLead",
					filter: {
						masterColumn: "Id",
						detailColumn: "Lead"
					}
				},
				LeadEmail: {
					schemaName: "EmailDetailV2",
					filter: {
						masterColumn: "Id",
						detailColumn: "Lead"
					},
					defaultValues: {
						Lead: {
							masterColumn: "Id"
						}
					},
					filterMethod: "getEmailDetailFilter"
				}
			}/**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * Returns filter for Email detail.
				 * @protected
				 * @return {Terrasoft.CompareFilter} Filter object.
				 */
				getEmailDetailFilter: function() {
					var recordId = this.get("Id");
					var filterGroup = new Terrasoft.createFilterGroup();
					filterGroup.add("Lead", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Lead", recordId));
					var emailType = ConfigurationConstants.Activity.Type.Email;
					filterGroup.add("ActivityType", Terrasoft.createColumnFilterWithParameter(
						Terrasoft.ComparisonType.EQUAL, "Type", emailType));
					return filterGroup;
				},

				/**
				 * @inheritdoc Terrasoft.BaseSchemaViewModel#init
				 * @overridden
				 */
				init: function() {
					this.callParent(arguments);
					this.initSearchContactInInternetButtonMenu();
					this.initSearchAccountInInternetButtonMenu();
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initContainersVisibility
				 * @overridden
				 */
				initContainersVisibility: function() {
					this.callParent(arguments);
					if (!this.getIsFeatureEnabled("OldUI")) {
						this.set("IsActionDashboardContainerVisible", true);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initActionButtonMenu
				 * @param {Object} config Additional parameters.
				 * @overridden
				 */
				initActionButtonMenu: function(config) {
					if (Ext.isEmpty(config) || config.callParent !== true) {
						this.initLeadManagement(function() {
							this.initActionButtonMenu({
								callParent: true,
								args: arguments
							});
						}, this);
					} else {
						this.callParent(config.args);
					}
				},

				/**
				 * Returns id of qualified contact.
				 * @return {String} Id of qualified contact.
				 */
				getQualifiedContactId: function() {
					var qualifiedContact = this.get("QualifiedContact");
					if (qualifiedContact) {
						return qualifiedContact.value;
					}
				},

				/**
				 * QualifiedContact change event handler.
				 */
				onQualifiedContactChanged: function(callback, scope) {
					this.setQualifiedAccountByQualifiedContact();
					if (callback) {
						scope = scope || this;
						callback.call(scope);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#initContextHelp
				 * @overridden
				 */
				initContextHelp: function() {
					this.set("ContextHelpId", 1009);
					this.callParent(arguments);
				},

				/**
				 * Call method of deduplication lead service.
				 * @param {String} methodName Name of method.
				 * @param {Function} callback Callback function.
				 * @param {Object} config Additional parameters.
				 * @param {Object} scope Call context.
				 */
				callDeduplicationLeadServiceMethod: function(methodName, callback, config, scope) {
					ServiceHelper.callService("LeadService", methodName, callback, config, scope);
				},

				/**
				 * Returns query that selects QualifyStatuses.
				 * @protected
				 * @virtual
				 * @return {Terrasoft.EntitySchemaQuery} Query to EntitySchema.
				 */
				getQualifyStatusEntitySchemaQuery: function() {
					var entitySchemaQuery = Ext.create("Terrasoft.EntitySchemaQuery", {
						rootSchemaName: "QualifyStatus"
					});
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_COLUMN, "Id");
					entitySchemaQuery.addMacrosColumn(Terrasoft.QueryMacrosType.PRIMARY_DISPLAY_COLUMN, "Name");
					return entitySchemaQuery;
				},

				/**
				 * Sets value for the QualifyStatus.
				 * @protected
				 * @virtual
				 * @param {String} qualifyStatusId Unique identifier of the QualifyStatus.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Execution context.
				 */
				setQualifyStatus: function(qualifyStatusId, callback, scope) {
					var entitySchemaQuery = this.getQualifyStatusEntitySchemaQuery();
					entitySchemaQuery.getEntity(qualifyStatusId, function(response) {
						var entity = response.entity;
						if (entity) {
							this.set("QualifyStatus", {
								"value": entity.get("Id"),
								"displayValue": entity.get("Name")
							});
						}
						if (callback) {
							callback.call(scope || this);
						}
					}, this);
				},

				/**
				 * Initializes default value for the column QualifyStatus.
				 * @protected
				 */
				initDefQualifyStatus: function() {
					var operation = this.get("Operation");
					if (operation === enums.CardStateV2.EDIT) {
						return;
					}
					var qualifyStatusId = this.getQualifyStatus();
					if (qualifyStatusId !== LeadConfigurationConst.LeadConst.QualifyStatus.Qualification) {
						return;
					}
					var qualifiedContactId = this.getQualifiedContactId();
					if (qualifiedContactId && !Terrasoft.isEmptyGUID(qualifiedContactId)) {
						qualifyStatusId = LeadConfigurationConst.LeadConst.QualifyStatus.Distribution;
						this.setQualifyStatus(qualifyStatusId);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
				 * @overridden
				 */
				onEntityInitialized: function() {
					var primaryColumnValue = this.get("PrimaryColumnValue") || this.getPrimaryColumnValue();
					this.set("PrimaryColumnValue", primaryColumnValue);
					if (this.isNew) {
						this.setQualifiedAccountByQualifiedContact();
						this.initDefQualifyStatus();
					}
					this.initLeadManagementControls();
					this.initSearchInInternet();
					this.setIsDeduplicationEnabled();
					this.callParent(arguments);
				},

				/**
				 * Sets qualified account by qualified contact.
				 * @protected
				 */
				setQualifiedAccountByQualifiedContact: function() {
					var qualifiedAccount = this.get("QualifiedAccount");
					if (!qualifiedAccount) {
						var qualifiedContactId = this.getQualifiedContactId();
						if (qualifiedContactId) {
							this.getContactById(qualifiedContactId, this.setQualifiedAccountFormContact);
						}
					}
				},

				/**
				 * Returns contact by identifier.
				 * @param {GUID} contactId The contact identifier.
				 * @param {Function} callback Callback function.
				 * @protected
				 */
				getContactById: function(contactId, callback) {
					this.readEntity("Contact", contactId, ["Account"], callback);
				},

				/**
				 * Sets qualified account from contact.
				 * @param {Terrasoft.BaseViewModel} contact The contact.
				 */
				setQualifiedAccountFormContact: function(contact) {
					var account = contact.get("Account");
					if (account) {
						this.set("QualifiedAccount", account);
					}
				},

				/**
				 * Sets "Deduplication" feature enabled flag.
				 */
				setIsDeduplicationEnabled: function() {
					var isElasticDeduplicationEnabled = this.getIsFeatureEnabled("ESDeduplication");
					var isDeduplicationEnabled = this.getIsFeatureEnabled("Deduplication");
					var isEnabled = isElasticDeduplicationEnabled || isDeduplicationEnabled;
					this.set("IsDeduplicationEnabled", isEnabled);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#validateResponse
				 * @overridden
				 */
				validateResponse: function() {
					var result = this.callParent(arguments);
					if (!result) {
						this.set("LockBodyMask", false);
						this.hideBodyMask();
					}
					return result;
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onSaved
				 * @overridden
				 */
				onSaved: function(response, config) {
					if (config && config.lockBodyMask) {
						this.set("LockBodyMask", true);
					}
					this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#hideBodyMask
				 * @overridden
				 */
				hideBodyMask: function() {
					if (this.get("LockBodyMask") !== true) {
						this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.LeadPageV2#checkRequiredActionColumns
				 * @overridden
				 */
				checkRequiredActionColumns: function() {
					return true;
				},

				/**
				 * Validates that status is equal to Disqualified.
				 * @param {Object} qualifyStatus Status of the lead.
				 * @return {bool} Boolean result.
				 */
				getIsDisqualifiedStatus: function(qualifyStatus) {
					return (qualifyStatus && (qualifyStatus.value ===
						LeadConfigurationConst.LeadConst.QualifyStatus.Disqualified));
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#onGetEntityInfo
				 * @overridden
				 */
				onGetEntityInfo: function() {
					var entityInfo = this.callParent(arguments) || {};
					entityInfo.QualifyStatus = this.get("QualifyStatus");
					return entityInfo;
				},

				/**
				 * Calls method of the card page.
				 * @param {Object} config Configuration of call.
				 * @return {Object} Result of the method execution.
				 * @overridden
				 */
				onCardAction: function(config) {
					if (Ext.isObject(config)) {
						var method = this[config.methodName];
						return method.apply(config.scope || this, config.args);
					} else {
						return this.callParent(arguments);
					}
				},

				/**
				 * @inheritdoc Terrasoft.BasePageV2#getActions
				 * @overridden
				 */
				getActions: function() {
					var actionMenuItems = this.callParent(arguments);
					var menuSeparator = this.getButtonMenuItem({
						"Type": "Terrasoft.MenuSeparator"
					});
					actionMenuItems.addItem(menuSeparator);
					var disqualificationMenuItems = this.get("DisqualificationMenuItems");
					disqualificationMenuItems.each(function(item) {
						actionMenuItems.addItem(item);
					});
					return actionMenuItems;
				},

				/**
				 * Get search button menu items for lead Contact.
				 * @protected
				 * @return {Object} Search contact in internet items collection.
				 */
				getSearchContactInInternetMenuItems: function() {
					var searchContactInInternetMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					searchContactInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchLinkedIn"),
						"Enabled": true,
						"Click": {bindTo: "onSearchContactInLinkedInButtonClick"}
					}));
					searchContactInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchFacebook"),
						"Enabled": true,
						"Click": {bindTo: "onSearchContactInFacebookButtonClick"}
					}));
					return searchContactInInternetMenuItems;
				},

				/**
				 * Get search button menu items for lead Account.
				 * @protected
				 * @return {Object} Search account in internet items collection.
				 */
				getSearchAccountInInternetMenuItems: function() {
					var searchAccountInInternetMenuItems = this.Ext.create("Terrasoft.BaseViewModelCollection");
					searchAccountInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchLinkedIn"),
						"Enabled": true,
						"Click": {bindTo: "onSearchAccountInLinkedInButtonClick"}
					}));
					searchAccountInInternetMenuItems.addItem(this.getButtonMenuItem({
						"Caption": this.get("Resources.Strings.SearchGoogle"),
						"Enabled": true,
						"Click": {bindTo: "onSearchAccountInGoogleButtonClick"}
					}));
					return searchAccountInInternetMenuItems;
				},

				/**
				 * Initialize search button menu items for lead Contact.
				 * @protected
				 */
				initSearchContactInInternetButtonMenu: function() {
					var searchContactInInternetMenuItems = this.getSearchContactInInternetMenuItems();
					this.set("SearchContactInInternetMenuItems", searchContactInInternetMenuItems);
				},

				/**
				 * Initialize search button menu items for lead Account.
				 * @protected
				 */
				initSearchAccountInInternetButtonMenu: function() {
					var searchAccountInInternetMenuItems = this.getSearchAccountInInternetMenuItems();
					this.set("SearchAccountInInternetMenuItems", searchAccountInInternetMenuItems);
				},

				/**
				 * Search in LinkedIn by lead Contact and Account.
				 * @protected
				 */
				onSearchContactInLinkedInButtonClick: function() {
					var contact = this.get("Contact");
					var account = this.get("Account");
					if (this.Ext.isEmpty(contact) && this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchContactInLinkedInNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						var keywords = [contact, account];
						this.searchInLinkedIn(keywords);
					}
				},

				/**
				 * Search in LinkedIn by lead Account.
				 * @protected
				 */
				onSearchAccountInLinkedInButtonClick: function() {
					var account = this.get("Account");
					if (this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchAccountInLinkedInNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInLinkedIn([account]);
					}
				},

				/**
				 * Search in Facebook by lead Email.
				 * @protected
				 */
				onSearchContactInFacebookButtonClick: function() {
					var email = this.get("Email");
					if (this.Ext.isEmpty(email)) {
						var message = this.get("Resources.Strings.SearchContactInFacebookNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInFacebook([email]);
					}
				},

				/**
				 * Search in Google by lead Account.
				 * @protected
				 */
				onSearchAccountInGoogleButtonClick: function() {
					var account = this.get("Account");
					if (this.Ext.isEmpty(account)) {
						var message = this.get("Resources.Strings.SearchAccountInGoogleNotEnoughInfoMessage");
						this.showInformationDialog(message);
					} else {
						this.searchInGoogle([account]);
					}
				}
			},
			modules: /**SCHEMA_MODULES*/{
				"AccountProfile": {
					"config": {
						"schemaName": "LeadAccountProfileSchema",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								masterColumnName: "QualifiedAccount"
							}
						}
					}
				},
				"ContactProfile": {
					"config": {
						"schemaName": "LeadContactProfileSchema",
						"isSchemaConfigInitialized": true,
						"useHistoryState": false,
						"parameters": {
							"viewModelConfig": {
								masterColumnName: "QualifiedContact"
							}
						}
					}
				}
			}, /**SCHEMA_MODULES*/
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "LeadPageCategorizationContainer"
				},
				{
					"operation": "remove",
					"name": "LeadPageGeneralTabContentGroup"
				},
				{
					"operation": "remove",
					"name": "LeadPageAccountInfo"
				},
				{
					"operation": "remove",
					"name": "LeadPageCommunicationContainer"
				},
				{
					"operation": "remove",
					"name": "LeadPageAddressContainer"
				},
				{
					"operation": "move",
					"name": "Header",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"index": 1
				},
				{
					"operation": "merge",
					"name": "Header",
					"parentName": "LeftModulesContainer",
					"values": {
						"classes": {
							"wrapClassName": ["profile-container", "autofill-layout"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"name": "AccountProfile",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE
					}
				},
				{
					"operation": "insert",
					"parentName": "LeftModulesContainer",
					"propertyName": "items",
					"name": "ContactProfile",
					"values": {
						"itemType": Terrasoft.ViewItemType.MODULE
					}
				},
				{
					"operation": "insert",
					"name": "NeedInfoTab",
					"parentName": "Tabs",
					"propertyName": "tabs",
					"index": 1,
					"alias": {
						"name": "NeedInfoTabContainer"
					},
					"values": {
						"caption": {"bindTo": "Resources.Strings.NeedInfoTabCaption"},
						"items": []
					}
				},
				{
					"operation": "insert",
					"parentName": "NeedInfoTab",
					"propertyName": "items",
					"name": "SpecificationInLead",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "move",
					"parentName": "NeedInfoTab",
					"propertyName": "items",
					"name": "LeadProduct",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				},
				{
					"operation": "insert",
					"parentName": "GeneralInfoTab",
					"propertyName": "items",
					"index": 1,
					"name": "LeadsSimilarSearchResult",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL,
						"visible": {"bindTo": "IsDeduplicationEnabled"}
					}
				},
				{
					"operation": "insert",
					"parentName": "NeedInfoTab",
					"name": "LeadTypeControlGroup",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.CONTROL_GROUP,
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeControlGroup",
					"name": "LeadTypeBlock",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": []
					},
					"index": 0
				},
				{
					"operation": "insert",
					"parentName": "LeftContainer",
					"propertyName": "items",
					"name": "QualificationProcessButton",
					"values": {
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"style": Terrasoft.controls.ButtonEnums.style.GREEN,
						"caption": {"bindTo": "QualificationProcessButtonCaption"},
						"markerValue": {"bindTo": "QualificationProcessButtonCaption"},
						"classes": {"wrapperClass": ["actions-button-margin-right"]},
						"iconAlign": Terrasoft.controls.ButtonEnums.iconAlign.RIGHT,
						"imageConfig": resources.localizableImages.QualificationProcessButtonImage,
						"click": {"bindTo": "onLeadManagementButtonClick"},
						"layout": {
							"column": 6,
							"row": 0,
							"colSpan": 2
						},
						"visible": {"bindTo": "LeadManagementButtonVisible"}
					}
				},
				{
					"operation": "insert",
					"parentName": "ProfileContainer",
					"propertyName": "items",
					"name": "NewLeadDisqualifyReason",
					"values": {
						"bindTo": "LeadDisqualifyReason",
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"visible": {
							"bindTo": "QualifyStatus",
							"bindConfig": {"converter": "getIsDisqualifiedStatus"}
						}
					},
					"alias": {
						"name": "LeadDisqualifyReason",
						"excludeProperties": ["layout"],
						"excludeOperations": ["remove", "move"]
					}
				},
				{
					"operation": "insert",
					"name": "SearchInSocialNetworksButton",
					"parentName": "LeadPageRegisterInfoBlock",
					"propertyName": "items",
					"values": {
						"id": "search-social-networks-button",
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"classes": {
							"wrapperClass": ["photo-icon-wrapper"],
							"imageClass": ["field-img-btn"]
						},
						"controlConfig": {
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"iconAlign": this.Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
							"imageConfig": {"bindTo": "Resources.Images.SearchInternetButtonImage"},
							"menu": {
								"items": {
									"bindTo": "SearchContactInInternetMenuItems"
								}
							}
						},
						"layout": {
							"column": 10,
							"row": 0,
							"colSpan": 1
						},
						"markerValue": "searchInSocialNetworksButton"
					}
				},
				{
					"operation": "insert",
					"name": "SearchInGoogleButton",
					"parentName": "LeadPageRegisterInfoBlock",
					"propertyName": "items",
					"values": {
						"id": "search-google-button",
						"itemType": Terrasoft.ViewItemType.BUTTON,
						"classes": {
							"wrapperClass": ["photo-icon-wrapper"],
							"imageClass": ["field-img-btn"]
						},
						"controlConfig": {
							"style": this.Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
							"iconAlign": this.Terrasoft.controls.ButtonEnums.iconAlign.LEFT,
							"imageConfig": {"bindTo": "Resources.Images.SearchInternetButtonImage"},
							"menu": {
								"items": {
									"bindTo": "SearchAccountInInternetMenuItems"
								}
							}
						},
						"layout": {
							"column": 22,
							"row": 0,
							"colSpan": 1
						},
						"markerValue": "searchInGoogleButton"
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeBlock",
					"propertyName": "items",
					"name": "LeadTypeStatus",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 12
						},
						"itemType": Terrasoft.ViewItemType.ENUM,
						"isRequired": true
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadTypeBlock",
					"propertyName": "items",
					"name": "Commentary",
					"values": {
						"enabled": {"bindTo": "SourceDataEditable"},
						"contentType": Terrasoft.ContentType.LONG_TEXT,
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24,
							"rowSpan": 2
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "LeadPageDealInformationBlock",
					"propertyName": "items",
					"name": "OpportunityDepartment",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 12
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"enabled": {"bindTo": "SourceDataEditable"}
					}
				},
				{
					"operation": "insert",
					"parentName": "HistoryTab",
					"propertyName": "items",
					"name": "LeadEmail",
					"values": {
						"itemType": Terrasoft.ViewItemType.DETAIL
					}
				}
			]/**SCHEMA_DIFF*/,
			rules: {
				"Region": {
					"EnabledRegion": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"City": {
					"EnabledCity": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Title": {
					"EnabledTitle": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Industry": {
					"EnabledIndustry": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"AnnualRevenue": {
					"EnabledAnnualRevenue": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"FullJobTitle": {
					"EnabledFullJobTitle": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"BusinesPhone": {
					"EnabledBusinesPhone": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Fax": {
					"EnabledFax": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"AddressType": {
					"EnabledAddressType": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Zip": {
					"EnabledZip": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Address": {
					"EnabledAddress": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				},
				"Notes": {
					"EnabledNotes": {
						ruleType: BusinessRuleModule.enums.RuleType.BINDPARAMETER,
						property: BusinessRuleModule.enums.Property.ENABLED,
						conditions: [{
							leftExpression: {
								type: BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								attribute: "SourceDataEditable"
							},
							comparisonType: Terrasoft.ComparisonType.EQUAL,
							rightExpression: {
								type: BusinessRuleModule.enums.ValueType.CONSTANT,
								value: true
							}
						}]
					}
				}
			}
		};
	});
