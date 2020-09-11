define("OpportunityPageV2", ["MLConfigurationConsts", "MLPredictionPageMixin"],
	function(MLConfigurationConsts) {
		return {
			entitySchemaName: "Opportunity",
			mixins: ["Terrasoft.MLPredictionPageMixin"],
			attributes: {
				"TrainedScoreModelExists": {
					dataValueType: Terrasoft.DataValueType.BOOLEAN,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				}
			},
			details: /**SCHEMA_DETAILS*/ {} /**SCHEMA_DETAILS*/,
			methods: {

				/**
				 * @inheritdoc BasePageV2#onEntityInitialized
				 * @override
				 */
				onEntityInitialized: function() {
					this.callParent(arguments);
					this.queryWasAnyModelTrained("PredictiveProbability", MLConfigurationConsts.ProblemTypes.Scoring);
				},

				getProbabilityMetricValue: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("PredictiveProbability");
				},

				getProbabilityMetricCaption: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("Resources.Strings.PredictiveProbabilityCaption");
				},

				getProbabilityMetricHint: function() {
					if (!this.$TrainedScoreModelExists) {
						return this.callParent(arguments);
					}
					return this.get("Resources.Strings.PredictiveProbabilityMetricHint");
				}
			},
			diff: /**SCHEMA_DIFF*/ [] /**SCHEMA_DIFF*/
		};
	});
