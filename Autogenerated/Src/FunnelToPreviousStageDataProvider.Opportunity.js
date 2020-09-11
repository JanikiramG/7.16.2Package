define("FunnelToPreviousStageDataProvider", ["ext-base", "FunnelConversionDataProvider"],
	function(Ext) {
		/**
		 * @class Terrasoft.configuration.FunnelToPreviousStageDataProvider
		 * Class to prepare filter for funnel by conversion.
		 */
		Ext.define("Terrasoft.configuration.FunnelToPreviousStageDataProvider", {
			extend: "Terrasoft.FunnelConversionDataProvider",
			alternateClassName: "Terrasoft.FunnelToPreviousStageDataProvider",

			/**
			 * @inheritdoc Terrasoft.FunnelConversionDataProvider#prepareConversionResponse
			 * @overridden
			 */
			prepareConversionResponse: function(responseCollection) {
				this.callParent(arguments);
				var countStore = {};
				var thereIsSomeData;
				responseCollection.each(function(currentItem, itemNumber) {
					var itemValue = currentItem.get("yAxis") || 0;
					if (thereIsSomeData === undefined && itemValue === 0) {
						return;
					}
					thereIsSomeData = true;
					var bottomValue = 0;
					var prevValue;
					if (itemNumber !== 0 && (prevValue = countStore[itemNumber - 1]) > 0) {
						bottomValue = prevValue;
					} else {
						bottomValue = itemValue;
					}
					var stage = this.getItemStage(currentItem);
					var storeValue = itemValue;
					if (stage.end) {
						storeValue = prevValue;
					}
					countStore[itemNumber] = storeValue;
					currentItem.set("bottomConversionValue", bottomValue);
				}, this);
			}

		});
	}
);
