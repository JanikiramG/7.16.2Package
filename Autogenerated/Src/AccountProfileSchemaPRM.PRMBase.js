/**
 * Account profile class.
 * @class Terrasoft.AccountProfileSchemaPRM
 */
define("AccountProfileSchemaPRM", ["ConfigurationConstants"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "Account",
			methods: {
				/**
				 * @inheritdoc Terrasoft.BaseProfileSchema#getLookupConfig
				 * @overridden
				 */
				getLookupConfig: function() {
					var config = this.callParent(arguments);
					var filter = this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Type", ConfigurationConstants.AccountType.Partner);
					if (this.isEmpty(config.filters)) {
						var filters = this.Terrasoft.createFilterGroup();
						config.filters = filters;
					}
					config.filters.add("AccountTypeFilter", filter);
					return config;
				}
			}
		};
	}
);
