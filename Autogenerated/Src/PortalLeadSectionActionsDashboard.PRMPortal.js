define("PortalLeadSectionActionsDashboard", ["LeadSectionActionsDashboard",
		"PortalLeadSectionActionsDashboardResources"],
	function() {
		return {
			attributes: {},
			messages: {},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "remove",
					"name": "CallMessageTab"
				},
				{
					"operation": "remove",
					"name": "EmailMessageTab"
				},
				{
					"operation": "remove",
					"name": "TaskMessageTab"
				},
				{
					"operation": "remove",
					"name": "SocialMessageTab"
				},
				{
					"operation": "remove",
					"name": "DashboardTab"
				}
			],/**SCHEMA_DIFF*/
			methods: {}
		};
	}
);
