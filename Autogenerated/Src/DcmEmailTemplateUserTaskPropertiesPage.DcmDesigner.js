 /**
 * Parent: EmailTemplateUserTaskPropertiesPage => BaseActivityUserTaskPropertiesPage => BaseUserTaskPropertiesPage
 * => RootUserTaskPropertiesPage => ProcessFlowElementPropertiesPage => BaseProcessSchemaElementPropertiesPage
 */
define("DcmEmailTemplateUserTaskPropertiesPage", [],
	function() {
		return {

			/**
			 * Use base DCM schema.
			 * @type {Boolean}
			 */
			useBaseDcmSchema: true,
			
			methods: {
				
				/**
				 * @inheritdoc Terrasoft.MenuItemsMappingMixin#getMainRecordMappingConfig
				 * @override
				 */
				getMainRecordMappingConfig: function() {
					var mappingTag = this.tag;
					var disabledMappings = ["Sender"];
					var disabledIcons = ["EmailRecipientItem"];
					return {
						enabled: !Ext.Array.contains(disabledMappings, mappingTag),
						hideIcon: Ext.Array.contains(disabledIcons, mappingTag)
					};
				}
			},
			
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	}
);
