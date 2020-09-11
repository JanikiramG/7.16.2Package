define("PartnershipPage", ["ConfigurationConstants", "PRMEnums", "css!PartnershipCommonCSS"],
	function(ConfigurationConstants) {
		return {
			entitySchemaName: "Partnership",
			methods: {

				/**
				 * Adds filters for invoice detail
				 * @private
				 */
				invoiceDetailFilter: function() {
					var generalFilterGroup = new this.Terrasoft.createFilterGroup();
					generalFilterGroup.name = "generalFilterGroup";
					generalFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
					var invoiceFilterGroup = new this.Terrasoft.createFilterGroup();
					invoiceFilterGroup.name = "invoiceFilterGroup";
					var accountFilterGroup = new this.Terrasoft.createFilterGroup();
					accountFilterGroup.name = "accountFilterGroup";
					var partnerAccountFilterGroup = new this.Terrasoft.createFilterGroup();
					partnerAccountFilterGroup.name = "partnerAccountFilterGroup";
					partnerAccountFilterGroup.logicalOperation = this.Terrasoft.LogicalOperatorType.OR;
					var account = this.get("Account");
					var startDate = this.get("StartDate");
					var dueDate = this.get("DueDate");
					if (!this.Ext.isEmpty(account) && !this.Ext.isEmpty(startDate) && !this.Ext.isEmpty(dueDate)) {
						accountFilterGroup.add("AccountFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "Account", account.value));
						invoiceFilterGroup.add("OpportunityFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL, "[Opportunity:Id:Opportunity].Partner", account.value));
						invoiceFilterGroup.add("OpportunityTypeFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.EQUAL,
							"[Opportunity:Id:Opportunity].Type", ConfigurationConstants.Opportunity.Type.PartnerSale));
						partnerAccountFilterGroup.add("accountFilterGroup", accountFilterGroup);
						partnerAccountFilterGroup.add("invoiceFilterGroup", invoiceFilterGroup);
						generalFilterGroup.add("partnerAccountFilterGroup", partnerAccountFilterGroup);
						generalFilterGroup.add("StartDateFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.GREATER_OR_EQUAL, "StartDate", startDate));
						generalFilterGroup.add("DueDateFilter", this.Terrasoft.createColumnFilterWithParameter(
							this.Terrasoft.ComparisonType.LESS_OR_EQUAL, "DueDate", dueDate));
					}
					else {
						generalFilterGroup.add("InvoiceIdIsNullFilter", this.Terrasoft.createColumnIsNullFilter("Id"));
					}
					return generalFilterGroup;
				}
			},
			diff: /**SCHEMA_DIFF*/[
			]/**SCHEMA_DIFF*/
		};
	});
