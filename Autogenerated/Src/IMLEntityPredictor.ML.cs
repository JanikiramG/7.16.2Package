namespace Terrasoft.Configuration.ML
{
	using System;

	/// <summary>
	/// Interface for prediction and saving the prediction result in entity.
	/// </summary>
	public interface IMLEntityPredictor
	{
		/// <summary>
		/// Predicts and saves the prediction result in entity.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Prediction result.</returns>
		object PredictAndSave(Guid modelId, Guid entityId);
	}
}

