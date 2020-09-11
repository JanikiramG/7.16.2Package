define("FunnelToFirstStageDataProvider", ["ext-base", "FunnelConversionDataProvider"],
	function(Ext) {

		/**
		 * @class Terrasoft.configuration.FunnelToFirstStageDataProvider
		 * Class to prepare filter for funnel first stage conversion.
		 */
		Ext.define("Terrasoft.configuration.FunnelToFirstStageDataProvider", {
			extend: "Terrasoft.FunnelConversionDataProvider",
			alternateClassName: "Terrasoft.FunnelToFirstStageDataProvider",

			/**
			 * @inheritdoc Terrasoft.FunnelConversionDataProvider#prepareConversionResponse
			 * @overridden
			 */
			prepareConversionResponse: function(responseCollection) {
				this.callParent(arguments);
				var firstStageValue;
				responseCollection.each(function(currentItem) {
					var itemValue = currentItem.get("yAxis") || 0;
					if (firstStageValue === undefined && itemValue !== 0) {
						firstStageValue = itemValue;
					}
					if (firstStageValue !== undefined) {
						currentItem.set("bottomConversionValue", firstStageValue);
					}
				}, this);
			}

		});
	}
);
