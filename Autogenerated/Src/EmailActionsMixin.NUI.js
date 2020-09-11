define("EmailActionsMixin", ["ExchangeNUIConstants"],
	function(ExchangeNUIConstants) {
		/**
		 * @class Terrasoft.configuration.mixins.EmailActionsMixin
		 * The mixin can add signature to body.
		 */
		Ext.define("Terrasoft.configuration.mixins.EmailActionsMixin", {
			alternateClassName: "Terrasoft.EmailActionsMixin",

			//region Properties: Private

			/**
			 * Custom signature meta teg.
			 * @private
			 */
			_signatureMetateg: "<signature>",

			/**
			 * Signature indentation meta teg.
			 * @private
			 */
			_indentation: "<br>",

			//endregion

			//region Methods: Private

			/**
			 * Adds filters to select mailbox sync settings query.
			 * @private
			 * @param {Object} selectMailboxSyncSettings Select mailbox sync settings query.
			 */
			addSelectMailboxQueryFilters: function(selectMailboxSyncSettings) {
				selectMailboxSyncSettings.filters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
				const filterName = "FilterEmailSettings";
				const filterIsEmailForSendName = "FilterIsEmailForSendName";
				const filterIsSharedName = "FilterIsSharedName";
				const filtersGroup = selectMailboxSyncSettings.createFilterGroup();
				filtersGroup.name = "FilterGroup";
				filtersGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
				const filterSettings = selectMailboxSyncSettings.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "SysAdminUnit",
							this.Terrasoft.core.enums.SysValue.CURRENT_USER.value);
				const filterIsEmailForSend = selectMailboxSyncSettings.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "SendEmailsViaThisAccount", true);
				const filterIsShared = selectMailboxSyncSettings.createColumnFilterWithParameter(
						this.Terrasoft.ComparisonType.EQUAL, "IsShared", true);
				filtersGroup.add(filterName, filterSettings);
				filtersGroup.add(filterIsSharedName, filterIsShared);
				selectMailboxSyncSettings.filters.add(filtersGroup.name, filtersGroup);
				selectMailboxSyncSettings.filters.add(filterIsEmailForSendName, filterIsEmailForSend);
			},

			/**
			 * Puts two indentation before html text.
			 * @private
			 * @param {String} html Html to be putted indentation.
			 */
			_addDefaultIndentation: function(html) {
				let indentation = this._indentation.repeat(2);
				return indentation.concat(html);
			},

			/**
			 * Puts indentation before html text.
			 * @private
			 * @param {String} html Html to be putted indentation.
			 */
			_addSingleIndentation: function(html) {
				return this._indentation.concat(html);
			},

			/**
			 * Formating signature turning it into custom meta tags.
			 * @private
			 * @param {String} signature Html signature.
			 * @returns {String} Formated signature.
			 */
			_formatedSignature: function(signature) {
				if (this.isEmpty(signature) || signature.indexOf(this._signatureMetateg) === -1) {
					signature = this.Ext.String.format("<signature>{0}</signature>", signature || "");
				}
				return signature;
			},

			/**
			 * Replace signature in the mail body.
			 * @private
			 * @param {String} body Html body text.
			 * @param {String} newSignature New signature html text.
			 */
			_replaceSignatureInBody: function(body, newSignature) {
				if (body.indexOf(this._signatureMetateg) > -1) {
					body = body.replace(this.getSignatureRegExp(), newSignature);
				} else {
					body = body.concat(newSignature);
				}
				return body;
			},

			/**
			 * Combine html body text, with forward or reply action considers.
			 * @private
			 * @param {String} textTemplate Html body text.
			 * @param {Boolean} isForwardOrReplyAction Sign that body set on forward or reply action.
			 * @return {String} Combined html body text.
			 */
			_getBody: function(textTemplate, isForwardOrReplyAction) {
				let body = this.get("Body");
				if (isForwardOrReplyAction) {
					if(this.get("UseSignature")) {
						body = textTemplate;
					}
					else {
						let emptySignature = this._formatedSignature(Terrasoft.emptyString);
						emptySignature = this._addDefaultIndentation(emptySignature);
						body = emptySignature.concat(textTemplate);
					}
				} else {
					let signature = this._formatedSignature(textTemplate);
					this.set("Signature", signature);
					signature = (this.get("UseSignature") && !this.isEmpty(this.$ProcessElementId))
						? this._addSingleIndentation(signature)
						: this._addDefaultIndentation(signature);
					body = this.isEmpty(body) ? signature : this._replaceSignatureInBody(body, signature);
				}
				return body;
			},

			//endregion

			//region Methods: Protected

			/**
			 * Sets body signature.
			 * @protected
			 * @param {String} sender Email sender.
			 */
			setBodySignature: function(sender) {
				let signature = "";
				if (this.get("UseSignature") || (sender && sender.useSignature)) {
					signature = (sender && sender.signature) || signature;
					this.set("UseSignature", true);
				}
				const response = {
					textTemplate: signature,
					success: true
				};
				this.processSignature(response, false);
			},

			/**
			 * Processes signature.
			 * @protected
			 * @virtual
			 * @param {Object} response Response with text template.
			 * @param {Boolean} isForwardOrReplyAction Sign that body set on forward or reply action.
			 */
			processSignature: function(response, isForwardOrReplyAction) {
				this.hideBodyMask();
				if (response.success) {
					this.set("Body", this._getBody(response.textTemplate, isForwardOrReplyAction));
				}
			},

			/**
			 * Calls service for getting signature with replaced macroses.
			 * @param {String} textTemplate Template config for service.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 * @param {Boolean} isForwardOrReplyAction Sign that body set on forward or reply action.
			 * @protected
			 */
			executeSignatureMacrosServiceRequest: function(textTemplate, callback, scope, isForwardOrReplyAction) {
				this.showBodyMask();
				const serviceRequest = this.Ext.create("Terrasoft.MacrosHelperServiceRequest", {
					contractName: "GetTemplate",
					entityId: Terrasoft.SysValue.CURRENT_USER_CONTACT.value,
					entityName: "Contact",
					textTemplate: textTemplate
				});
				serviceRequest.execute(function(response) {
					this.Ext.callback(callback, scope || this, [response, isForwardOrReplyAction]);
				}, this);
			},

			/**
			 * Adds signature to item.
			 * @protected
			 * @param {Object} item without signature.
			 * @param {Object|String} mailboxSyncSettingsItem with signature and UseSignature flags.
			 * @return {Object|String} item with signature.
			 */
			getItemWithSignature: function(item, mailboxSyncSettingsItem) {
				const signature = mailboxSyncSettingsItem.get("Signature");
				const useSignature = mailboxSyncSettingsItem.get("UseSignature");
				if (this.isSignatureExist(useSignature, signature)) {
					const isStringItem = this.Ext.isString(item);
					if (isStringItem) {
						const movedSignature = this._addDefaultIndentation(signature);
						item = movedSignature.concat(item);
					} else {
						item.signature = signature;
					}
					item.useSignature = mailboxSyncSettingsItem.get("UseSignature");
				}
				return item;
			},

			/**
			 * Checks if signature exists.
			 * @protected
			 * @param {Boolean} useSignature Flag use signature.
			 * @param {String} signature Mailbox signature.
			 */
			isSignatureExist: function(useSignature, signature) {
				return useSignature && this.isNotEmpty(signature);
			},

			/**
			 * Sets sender selected by user.
			 * @protected
			 */
			setSenderFromSenderEnum: function() {
				const senderEnum = this.get("SenderEnum");
				if (this.isNotEmpty(senderEnum && senderEnum.displayValue) &&
					senderEnum.value !== "oldKey") {
					this.set("Sender", senderEnum.displayValue);
				} else if (this.isEmpty(senderEnum)) {
					this.set("Sender", "");
				}
				if (this.canAddSignature()) {
					this.setBodySignature(senderEnum);
				}
			},

			/**
			 * Checks if we can insert a signature.
			 * @returns {boolean} Default true value.
			 * @protected
			 * @virtual
			 */
			canAddSignature: function() {
				return true;
			},
			/**
			 * Returns senders select query.
			 * @protected
			 * @return {Object} Select query.
			 */
			getSenderQuery: function() {
				let selectMailboxSyncSettings = this.Ext.create("Terrasoft.EntitySchemaQuery", {
					rootSchemaName: "MailboxSyncSettings"
				});
				selectMailboxSyncSettings.addColumn("Id");
				selectMailboxSyncSettings.addColumn("SysAdminUnit.Contact.Name");
				selectMailboxSyncSettings.addColumn("SysAdminUnit.Id");
				selectMailboxSyncSettings.addColumn("SenderEmailAddress");
				selectMailboxSyncSettings.addColumn("MailServer.Type.Id");
				selectMailboxSyncSettings.addColumn("SenderDisplayValue");
				selectMailboxSyncSettings.addColumn("IsDefault");
				selectMailboxSyncSettings.addColumn("SendEmailsViaThisAccount");
				selectMailboxSyncSettings.addColumn("Signature");
				selectMailboxSyncSettings.addColumn("UseSignature");
				this.addSelectMailboxQueryFilters(selectMailboxSyncSettings);
				return selectMailboxSyncSettings;
			},

			/**
			 * Gets column display value of given mailbox sync settings item.
			 * @protected
			 * @param {Terrasoft.Entity} item Mailbox sync settings item.
			 * @return {String} Column display value.
			 */
			getColumnDisplayValue: function(item) {
				const senderDisplayValue = item.get("SenderDisplayValue");
				const ownerName = this.isNotEmpty(senderDisplayValue) ||
				item.get("MailServer.Type.Id") === ExchangeNUIConstants.MailServer.Type.Exchange
					? senderDisplayValue
					: item.get("SysAdminUnit.Contact.Name");
				return this.Ext.String.format(
					this.get("Resources.Strings.EmailFormatString"),
					ownerName,
					item.get("SenderEmailAddress")).trim();
			},

			/**
			 * Calls macros processing for mailboxes signatures.
			 * @protected
			 * @param {Terrasoft.Collection} collection Mailboxes collection
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function scope.
			 */
			processMacrosesInSignatures: function(collection, callback, scope) {
				let generatorFn = function(newItem) {
					return function(next) {
						this.executeSignatureMacrosServiceRequest(newItem.$Signature, function(response) {
							newItem.$Signature = response.textTemplate || newItem.$Signature;
							this.Ext.callback(next);
						}, this);
					}.bind(this);
				}.bind(this);
				Terrasoft.chainForArray(collection, generatorFn, callback, scope);
			},

			/**
			 * Adds signature from body to template.
			 * @protected
			 * @param {String} templateBody Template body.
			 * @return {String} Template body with signature.
			 */
			addSignatureToTemplate: function(templateBody) {
				templateBody = templateBody.replace(this.getEmptySignature(), "<br/><br/>" + this.$Signature);
				return templateBody;
			},

			/**
			 * Wrap body content in blockquote html tag.
			 * @protected
			 * @param {Strings} body Body
			 * @returns {Strings} Wrapped blockquote tag body content.
			 */
			getQuotesBody: function(body) {
				if(this.getIsFeatureDisabled("IsQuotesBody")){
					return body;
				}
				const bodyGroups = body.match(/<body.*?>([\s\S]*)<\/body>/);
				const quotesTemplate = this.get("Resources.Strings.ReplyBodyQuotesHtmlTemplate");
				const innerBody = bodyGroups && bodyGroups[1] || body;
				const quotedBodyTemplate = Ext.String.format(quotesTemplate, innerBody);
				return body.replace(innerBody, quotedBodyTemplate);
			},

			//endregion

			//region Methods: Public

			/**
			 * Returns empty signature.
			 * @public
			 * @returns {String} Empty signature.
			 */
			getEmptySignature: function() {
				return "<signature></signature>";
			},

			/**
			 * Returns signature regular expression.
			 * @public
			 * @returns {Object} Signature regular expression.
			 */
			getSignatureRegExp: function() {
				return /((<br.{1,8}>)|(\\r\\n)){0,2}<signature>[\s\S]*?<\/signature>/;
			},

			/**
			 * Set enum to SenderEnum.
			 * @param {Terrasoft.Entity} item Mailbox sync settings item.
			 * @param {Function} callback Callback function.
			 */
			setSenderEnum:function(item, callback) {
				if (item.get("IsDefault") && item.get("SendEmailsViaThisAccount")) {
					let lookupValue = this.getMailboxLookupValue(item);
					lookupValue = this.getItemWithSignature(lookupValue, item);
					this.set("SenderEnum", lookupValue);
					Ext.callback(callback, this, [item]);
				}
			},

			/**
			 * Gets default mailbox sync settings item.
			 * @param collection
			 * @returns {Terrasoft.Entity} Default mailbox sync settings item.
			 */
			getDefaultMailbox: function (collection) {
				const currentUserId = Terrasoft.SysValue.CURRENT_USER.value;
				const currentUserDefaultMailbox = collection.firstOrDefault(function (item) {
					return item.get("SysAdminUnit.Id") === currentUserId && item.get("IsDefault");
				}, collection);
				const defaultMailbox = collection.firstOrDefault(function(item) {
					return item.get("IsDefault");
				});
				return currentUserDefaultMailbox || defaultMailbox;
			},

			/**
			 * Gets lookup value.
			 * @public
			 * @param {Terrasoft.Entity} item Mailbox sync settings item.
			 * @returns {Object} Lookup value.
			 */
			getMailboxLookupValue: function (item) {
				const columnDisplayValue = this.getColumnDisplayValue(item);
				return {
					displayValue: columnDisplayValue,
					value: item.get("Id")
				};
			},

			/**
			 * Checks if page has process data.
			 * @virtual
			 * @return {Boolean} Reply actions visibility.
			 */
			hasProcessData: function() {
				return false;
			}

			//endregion

		});
	});