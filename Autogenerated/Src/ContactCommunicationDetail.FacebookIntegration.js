define("ContactCommunicationDetail", [], function() {
		return {
			attributes: {
				/**
				 * ####### ########### ######### #### Facebook # #### ########## ####.
				 */
				FacebookMenuItemEnabled: {
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					value: false
				}
			},

			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#updateFacebookProfileInfo
				 * @overridden
				 */
				updateFacebookProfileInfo: function() {
					this.callParent(arguments);
					var facebookProfileExists = this.get("FacebookProfileExists");
					this.set("FacebookMenuItemEnabled", !facebookProfileExists);
				},

				/**
				 * @inheritdoc Terrasoft.BaseCommunicationDetail#modifyFacebookMenuItem
				 * @overridden
				 */
				modifyFacebookMenuItem: function(facebookMenuItem) {
					this.callParent(arguments);
					facebookMenuItem.set("Enabled", {
						bindTo: "FacebookMenuItemEnabled"
					});
				}
			}
		}
	});
