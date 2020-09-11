 define("EmailItemSchema", [], function() {
	return {
		methods: {

			/**
			 * @inheritdoc Terrasoft.EmailItemSchema#getEntityDefaultValueColumnValue
			 * @overridden
			 */
			getEntityDefaultValueColumnValue: function(schemaName, entity) {
				if (schemaName === "Lead") {
					return entity.displayValue;
				}
				return this.callParent(arguments);
			}
		}
	};
});
