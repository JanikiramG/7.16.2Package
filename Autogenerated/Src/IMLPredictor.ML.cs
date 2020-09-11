namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Interface for implementations of predictors for ML tasks.
	/// </summary>
	/// <typeparam name="TOut">The type of the out.</typeparam>
	public interface IMLPredictor<TOut>
	{
		/// <summary>
		/// Tries to predict.
		/// </summary>
		/// <param name="modelConfig">ML model configuration.</param>
		/// <param name="data">The input data.</param>
		/// <param name="result">The result of prediction.</param>
		/// <returns>If can't predict returns <c>false</c>.</returns>
		bool TryPredict(MLModelConfig modelConfig, Dictionary<string, object> data, out TOut result);

		/// <summary>
		/// Predicts result by given input data.
		/// </summary>
		/// <param name="modelConfig">ML model identifier.</param>
		/// <param name="data">The input data.</param>
		/// <returns>Prediction result.</returns>
		TOut Predict(Guid modelId, Dictionary<string, object> data);

		/// <summary>
		/// Predicts result by data from given entity.
		/// </summary>
		/// <param name="modelConfig">ML model identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Prediction result.</returns>
		TOut Predict(Guid modelId, Guid entityId);

		/// <summary>
		/// Predicts results for the given list of records.
		/// </summary>
		/// <param name="modelConfig">ML model configuration.</param>
		/// <param name="dataList">List of records.</param>
		/// <returns>Prediction result.</returns>
		List<TOut> Predict(MLModelConfig modelConfig, IList<Dictionary<string, object>> dataList);
	}
}

