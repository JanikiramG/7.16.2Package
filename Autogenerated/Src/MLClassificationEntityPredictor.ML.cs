namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using Core;
	using Core.Factories;
	using Terrasoft.ML.Interfaces;

	/// <summary>
	/// Classification implementation of <see cref="IMLEntityPredictor"/> and <see cref="IMLPredictor{TOut}"/>.
	/// </summary>
	/// <seealso cref="MLBaseEntityPredictor{List{Terrasoft.ML.Interfaces.ClassificationResult}}" />
	/// <seealso cref="IMLEntityPredictor" />
	[DefaultBinding(typeof(IMLEntityPredictor), Name = MLConsts.ClassificationProblemType)]
	[DefaultBinding(typeof(IMLPredictor<List<ClassificationResult>>), Name = MLConsts.ClassificationProblemType)]
	public class MLClassificationEntityPredictor : MLBaseEntityPredictor<List<ClassificationResult>>,
			IMLEntityPredictor, IMLPredictor<List<ClassificationResult>>
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLClassificationEntityPredictor"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLClassificationEntityPredictor(UserConnection userConnection) : base(userConnection) {
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Gets the problem type identifier.
		/// </summary>
		/// <value>
		/// The problem type identifier.
		/// </value>
		protected override Guid ProblemTypeId => new Guid(MLConsts.ClassificationProblemType);

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Predicts using the specified proxy.
		/// </summary>
		/// <param name="proxy">The proxy.</param>
		/// <param name="model">The model.</param>
		/// <param name="data">The input data.</param>
		/// <returns>
		/// Predicted result.
		/// </returns>
		protected override List<ClassificationResult> Predict(IMLServiceProxy proxy, MLModelConfig model,
				Dictionary<string, object> data) {
			return proxy.Classify(model.ModelInstanceUId, data);
		}

		/// <summary>
		/// Predicts results for the given batch of records. Not implemented for current problem type.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="dataForPrediction"></param>
		/// <param name="proxy">ML service proxy.</param>
		/// <returns>
		/// Prediction result.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		protected override List<List<ClassificationResult>> Predict(MLModelConfig model,
				IList<Dictionary<string, object>> dataForPrediction, IMLServiceProxy proxy) {
			throw new NotImplementedException();
		}

		protected override void SaveEntityPredictedValues(MLModelConfig model, Guid entityId,
				List<ClassificationResult> predictedResult) {
			var connectionArg = new ConstructorArgument("userConnection", _userConnection);
			var filter = ClassFactory.Get<MLBasePredictedValueFilter>(connectionArg);
			var predictedValues = new Dictionary<MLModelConfig, List<ClassificationResult>> {
				{ model, predictedResult }
			};
			PredictionSaver.SaveEntityPredictedValues(model.EntitySchemaId, entityId, predictedValues,
				filter.OnSetupPredictedValue);
		}

		/// <summary>
		/// Saves the prediction result.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedResult">The predicted result.</param>
		protected override void SavePrediction(MLModelConfig model, Guid entityId,
				List<ClassificationResult> predictedResult) {
			PredictionSaver.SavePrediction(model.Id, model.ModelInstanceUId, entityId, predictedResult);
		}

		#endregion

	}
}

