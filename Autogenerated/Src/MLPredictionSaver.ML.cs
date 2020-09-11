namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Common;
	using Common.Json;
	using Core;
	using Core.DB;
	using Core.Entities;
	using global::Common.Logging;
	using Terrasoft.ML.Interfaces;
	using Terrasoft.ML.Interfaces.Responses;

	#region Class: MLPredictionSaver

	/// <summary>
	/// Provides a base class for saving prediction results.
	/// </summary>
	public class MLPredictionSaver
	{

		#region Constants: Private

		private const string HighSignificance = "High";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");

		#endregion

		#region Fields: Protected

		protected readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLPredictionSaver"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLPredictionSaver(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets a value indicating whether to use administrative rights while saving predictions.
		/// </summary>
		public bool UseAdminRights { get; set; } = true;

		#endregion

		#region Methods: Private

		private Entity GetEntity(Guid schemaUId, Guid entityId) {
			var entitySchema = _userConnection.EntitySchemaManager.GetInstanceByUId(schemaUId);
			Entity entity = entitySchema.CreateEntity(_userConnection);
			entity.UseAdminRights = UseAdminRights;
			if (!entity.FetchFromDB(entityId)) {
				_log.Warn($"Entity of schema {schemaUId} was not found by id {entityId}");
				return null;
			}
			return entity;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Select among classification results the one that is the most confident.
		/// </summary>
		/// <param name="classificationResults">Classification results.</param>
		/// <param name="confidentValueMethodId">Confident value selection method.</param>
		/// <param name="confidentValueLowEdge">Low edge of score for confident predicted value.</param>
		/// <returns>Chosen confident result or null.</returns>
		protected virtual ClassificationResult ChooseConfidentValue(List<ClassificationResult> classificationResults,
				Guid confidentValueMethodId, double confidentValueLowEdge = 0) {
			if (confidentValueMethodId.IsEmpty()) {
				confidentValueMethodId = new Guid(MLConsts.MLEngineSignificanceConfidentValueMethodId);
			}
			if (confidentValueMethodId == new Guid(MLConsts.MLEngineSignificanceConfidentValueMethodId)) {
				return classificationResults.FirstOrDefault(result => result.Significance == HighSignificance);
			} else if (confidentValueMethodId == new Guid(MLConsts.MaxProbabilityConfidentValueMethodId)) {
				return classificationResults.OrderByDescending(item => item.Probability)
					.FirstOrDefault(result => result.Probability >= confidentValueLowEdge);
			}
			throw new NotImplementedException($"{confidentValueMethodId} is not supported " +
				$"{nameof(confidentValueMethodId)}");
		}

		/// <summary>
		/// Sets the predicted results to entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="columnValueName">Name of the column value.</param>
		/// <param name="classificationResults">The classification results.</param>
		/// <param name="onSetEntityValue">Function, that will be invoked before setting predicted value to entity.
		/// If it returns <c>false</c>, the value won't be set.</param>
		/// <returns><c>true</c> if the value was set, otherwise - <c>false</c>.</returns>
		protected virtual bool SetPredictedResultsToEntity(Entity entity, string columnValueName,
				List<ClassificationResult> classificationResults,
				Func<Entity, string, ClassificationResult, bool> onSetEntityValue) {
			return SetPredictedResultsToEntity(entity, columnValueName, classificationResults, onSetEntityValue,
				new Guid(MLConsts.MLEngineSignificanceConfidentValueMethodId));
		}

		/// <summary>
		/// Sets the predicted results to entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="columnValueName">Name of the column value.</param>
		/// <param name="classificationResults">The classification results.</param>
		/// <param name="onSetEntityValue">Function, that will be invoked before setting predicted value to entity.
		/// If it returns <c>false</c>, the value won't be set.</param>
		/// <param name="confidentValueMethodId">Confident value selection method.</param>
		/// <param name="confidentValueLowEdge">Low edge of score for confident predicted value.</param>
		/// <returns><c>true</c> if the value was set, otherwise - <c>false</c>.</returns>
		protected virtual bool SetPredictedResultsToEntity(Entity entity, string columnValueName,
				List<ClassificationResult> classificationResults,
				Func<Entity, string, ClassificationResult, bool> onSetEntityValue,
				Guid confidentValueMethodId, double confidentValueLowEdge = 0) {
			var columnValue = entity.FindEntityColumnValue(columnValueName);
			var confidentResult = ChooseConfidentValue(classificationResults, confidentValueMethodId,
				confidentValueLowEdge);
			if (confidentResult == null) {
				return false;
			}
			if (onSetEntityValue != null && !onSetEntityValue(entity, columnValueName, confidentResult)) {
				return false;
			}
			entity.SetColumnValue(columnValue.Column, confidentResult.Value);
			return true;
		}

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <typeparam name="T">The type of predicted values.</typeparam>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <param name="valueTransformer">
		/// Optional mapping function, that should be applied to predicted value before saving.
		/// </param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		protected virtual bool SaveEntityPredictedValues<T>(Guid schemaUId, Guid entityId,
			Dictionary<MLModelConfig, T> predictedValues, Func<T, object> valueTransformer) {
			if (predictedValues.IsNullOrEmpty()) {
				return false;
			}
			Entity entity = GetEntity(schemaUId, entityId);
			if (entity == null) {
				return false;
			}
			foreach (KeyValuePair<MLModelConfig, T> prediction in predictedValues) {
				MLModelConfig model = prediction.Key;
				EntitySchemaColumn column = entity.FindEntityColumnValue(model.PredictedResultColumnName).Column;
				if (valueTransformer != null) {
					object transformedPredictionValue = valueTransformer(prediction.Value);
					entity.SetColumnValue(column, transformedPredictionValue);
				} else {
					entity.SetColumnValue(column, prediction.Value);
				}
			}
			return entity.Save();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <param name="onSetEntityValue">Function, that will be invoked before setting predicted value to entity.
		/// If it returns <c>false</c>, the value won't be set.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityPredictedValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, List<ClassificationResult>> predictedValues,
				Func<Entity, string, ClassificationResult, bool> onSetEntityValue = null) {
			if (predictedValues.IsNullOrEmpty()) {
				return false;
			}
			Entity entity = GetEntity(schemaUId, entityId);
			if (entity == null) {
				return false;
			}
			bool isAnyValueSet = false;
			predictedValues.ForEach(kv => {
				MLModelConfig model = kv.Key;
				List<ClassificationResult> classificationResults = kv.Value;
				isAnyValueSet |= SetPredictedResultsToEntity(entity, model.PredictedResultColumnName,
					classificationResults, onSetEntityValue, model.ConfidentValueMethodId, model.ConfidentValueLowEdge);
			});
			return isAnyValueSet && entity.Save();
		}

		/// <summary>
		/// Saves the scores to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="scoredValues">The scored values of entity for the several models.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityScoredValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, double> scoredValues) {
			return SaveEntityPredictedValues(schemaUId, entityId, scoredValues, score => (int)Math.Round(score * 100));
		}

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityRegressionValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, double> predictedValues) {
			return SaveEntityPredictedValues(schemaUId, entityId, predictedValues, null);
		}

		/// <summary>
		/// Saves the classification results.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="results">Result, returned by ML service.</param>
		public virtual void SavePrediction(Guid modelId, Guid modelInstanceId, Guid entityId,
				List<ClassificationResult> results) {
			Query delete = new Delete(_userConnection)
				.From("MLClassificationResult")
				.Where("Key").IsEqual(Column.Parameter(entityId, "Guid"))
				.And("ModelId").IsEqual(Column.Parameter(modelId, "Guid"));
			delete.Execute();
			foreach (ClassificationResult prediction in results) {
				var query = new Insert(_userConnection)
					.Into("MLClassificationResult")
					.Set("Id", Column.Parameter(Guid.NewGuid()))
					.Set("CreatedOn", new QueryParameter(DateTime.UtcNow))
					.Set("ModifiedOn", new QueryParameter(DateTime.UtcNow))
					.Set("ModelId", new QueryParameter(modelId))
					.Set("ModelInstanceUId", new QueryParameter(modelInstanceId))
					.Set("Key", new QueryParameter(entityId))
					.Set("Value", new QueryParameter(Guid.Parse(prediction.Value)))
					.Set("Probability", new QueryParameter(prediction.Probability))
					.Set("Significance", new QueryParameter(prediction.Significance));
				query.Execute();
			}
		}

		/// <summary>
		/// Saves the numeric prediction result to MLPrediction entity.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="result">Result, returned by ML service.</param>
		public virtual void SavePrediction(Guid modelId, Guid modelInstanceId, Guid entityId, double result) {
			SavePrediction(modelId, modelInstanceId, entityId, new ScoringOutput { Score = result });
		}

		/// <summary>
		/// Saves the numeric prediction result to MLPrediction entity.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="result">Result, returned by ML service.</param>
		public virtual void SavePrediction(Guid modelId, Guid modelInstanceId, Guid entityId, ScoringOutput result) {
			var query = new Insert(_userConnection)
				.Into("MLPrediction")
				.Set("Id", Column.Parameter(Guid.NewGuid()))
				.Set("CreatedOn", new QueryParameter(DateTime.UtcNow))
				.Set("ModifiedOn", new QueryParameter(DateTime.UtcNow))
				.Set("ModelId", new QueryParameter(modelId))
				.Set("ModelInstanceUId", new QueryParameter(modelInstanceId))
				.Set("Key", new QueryParameter(entityId))
				.Set("Probability", new QueryParameter(result.Score));
			if (!result.Contributions.IsNullOrEmpty()) {
				string contributions = Json.Serialize(result.Contributions);
				query = query
					.Set("FeatureContributions", new QueryParameter(contributions))
					.Set("Bias", new QueryParameter(result.Bias));
			}
			query.Execute();
		}

		/// <summary>
		/// Save recommendation prediction result using model parameters.
		/// </summary>
		/// <param name="modelConfig">Model config.</param>
		/// <param name="predictionResult">Prediction result.</param>
		public virtual void SaveRecommendationPrediction(MLModelConfig modelConfig, 
				RecommendationResponse predictionResult) {
			EntitySchema schema = _userConnection.EntitySchemaManager.GetInstanceByUId(modelConfig.CFResultSchemaUId);
			var entityCollection = new EntityCollection(_userConnection, schema);
			EntitySchemaColumn userColumn = schema.GetSchemaColumnByPath(modelConfig.CFResultUserColumnName);
			EntitySchemaColumn itemColumn = schema.GetSchemaColumnByPath(modelConfig.CFResultItemColumnName);
			EntitySchemaColumn valueColumn = modelConfig.CFResultValueColumnName.IsNotNullOrWhiteSpace()
				? schema.FindSchemaColumnByPath(modelConfig.CFResultValueColumnName)
				: null;
			EntitySchemaColumn modelColumn = modelConfig.CFResultModelColumnName.IsNotNullOrWhiteSpace() 
				? schema.FindSchemaColumnByPath(modelConfig.CFResultModelColumnName)
				: null;
			EntitySchemaColumn timestampColumn = modelConfig.CFResultTimestampColumnName.IsNotNullOrWhiteSpace()
				? schema.FindSchemaColumnByPath(modelConfig.CFResultTimestampColumnName)
				: null;
			foreach (RecommendationOutput output in predictionResult.Outputs) {
				foreach (RecommendedItem item in output.Items) {
					Entity entity = schema.CreateEntity(_userConnection);
					entity.UseAdminRights = UseAdminRights;
					entity.SetColumnValue("Id", Guid.NewGuid());
					entity.SetColumnValue(userColumn, output.UserId);
					entity.SetColumnValue(itemColumn, item.ItemId);
					if (valueColumn != null) {
						entity.SetColumnValue(valueColumn, item.Score);
					}
					if (modelColumn != null) {
						entity.SetColumnValue(modelColumn, modelConfig.Id);
					}
					if (timestampColumn != null) {
						entity.SetColumnValue(timestampColumn, DateTime.UtcNow);
					}
					entityCollection.Add(entity);
				}
			}
			entityCollection.Save();
		}

		#endregion

	}

	#endregion

}

