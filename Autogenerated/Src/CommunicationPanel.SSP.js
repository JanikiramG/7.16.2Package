define("CommunicationPanel", ["terrasoft"],
	function(Terrasoft) {
		return {
			messages: {},
			attributes: {},
			methods: {
				/**
				 * Defines whether current user is portal or not.
				 * @private
				 * @return {boolean} true - if current user is not portal user
				 */
				getIsNotPortalUser: function() {
					return !Terrasoft.isCurrentUserSsp();
				}
			},
			diff: [
				{
					"operation": "merge",
					"name": "email",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "remindings",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "esnFeed",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				},
				{
					"operation": "merge",
					"name": "centerNotification",
					"values": {
						"visible": {
							"bindTo": "getIsNotPortalUser"
						}
					}
				}
			]
		};
	});
