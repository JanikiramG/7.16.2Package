namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using global::Common.Logging;
	using Common;
	using Core;
	using Core.DB;
	using Core.Factories;

	#region Interface: IMLBatchPredictor

	/// <summary>
	/// Defines methods for batch prediction.
	/// </summary>
	public interface IMLBatchPredictor
	{

		#region Methods: Public

		/// <summary>
		/// Predicts data by the specified machine learning model.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="chunkPredictedHandler">Handler on each chunk predicted event. Invokes with dictionary where
		/// key is entity identifier and value is predicted result for that entity.</param>
		/// <exception cref="AggregateException">When at least one of chunk failed to predict.</exception>
		void Predict(MLModelConfig modelConfig, Action<Dictionary<Guid, object>> chunkPredictedHandler);

		/// <summary>
		/// Saves the predicted data to entities.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="predictedData">Dictionary where key is entity identifier and value is predicted
		/// result for that entity.</param>
		void SavePredictedData(MLModelConfig modelConfig, Dictionary<Guid, object> predictedData);

		#endregion

	}

	#endregion

	#region Class: MLBatchPredictor

	/// <summary>
	/// Base class for batch predictors.
	/// </summary>
	/// <typeparam name="TOut">The type of the prediction result.</typeparam>
	/// <seealso cref="Terrasoft.Configuration.ML.IMLBatchPredictor" />
	public abstract class MLBatchPredictor<TOut> : IMLBatchPredictor
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");
		private readonly int _predictionChunkSize = 500;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLBatchNumericPredictor"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLBatchPredictor(UserConnection userConnection) {
			_userConnection = userConnection;
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			PredictionSaver = ClassFactory.Get<MLPredictionSaver>(userConnectionArg);
		}

		#endregion

		#region Properties: Private

		private IMLDataLoader _dataLoader;
		private IMLDataLoader DataLoader => _dataLoader ?? (_dataLoader = InitDataLoader());

		#endregion

		#region Properties: Protected

		protected MLPredictionSaver PredictionSaver { get; private set; }

		#endregion

		#region Methods: Private

		private static TOut ConvertFromObject(object value) {
			if (value is TOut typedValue) {
				return typedValue;
			}
			try {
				return (TOut)Convert.ChangeType(value, typeof(TOut));
			} catch (InvalidCastException) {
				return default(TOut);
			}
		}

		private IMLDataLoader InitDataLoader() {
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			var config = new MLDataLoaderConfig {
				ChunkSize = _predictionChunkSize,
				MaxRecordsCount = -1
			};
			ConstructorArgument configArg = new ConstructorArgument("config", config);
			return ClassFactory.Get<IMLDataLoader>(userConnectionArg, configArg);
		}

		private void UpdateEntityTargetColumn(string entitySchemaName, string targetFieldName, Guid entityId,
				TOut value) {
			var query = new Update(_userConnection, entitySchemaName)
				.Set(targetFieldName, Column.Parameter(FormatValueForSaving(value)))
				.Where("Id").IsEqual(Column.Parameter(entityId));
			query.Execute();
		}

		private void UpdateEntitiesTargetColumn(MLModelConfig model, Dictionary<Guid, object> predictedData) {
			if (predictedData.IsNullOrEmpty()) {
				return;
			}
			var entitySchema = _userConnection.EntitySchemaManager.GetInstanceByUId(model.EntitySchemaId);
			var entitySchemaName = entitySchema.Name;
			foreach (KeyValuePair<Guid, object> prediction in predictedData) {
				Guid entityId = prediction.Key;
				var value = ConvertFromObject(prediction.Value);
				UpdateEntityTargetColumn(entitySchemaName, model.PredictedResultColumnName, entityId, value);
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Saves the prediction result.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceUId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="value">Prediction result value.</param>
		protected abstract void SavePredictionResult(Guid modelId, Guid modelInstanceUId, Guid entityId, TOut value);

		/// <summary>
		/// Predicts data for the given list of records.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="dataList">The data for prediction.</param>
		/// <returns>Batch prediction result list.</returns>
		protected virtual List<TOut> Predict(MLModelConfig model, IList<Dictionary<string, object>> dataList) {
			var connectionArg = new ConstructorArgument("userConnection", _userConnection);
			var predictor =
				ClassFactory.Get<IMLPredictor<TOut>>(model.ProblemType.ToString().ToUpper(), connectionArg);
			return predictor.Predict(model, dataList);
		}

		/// <summary>
		/// Formats the result value for saving.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Formatted value.</returns>
		protected virtual object FormatValueForSaving(TOut value) {
			return value;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Predicts data by the specified machine learning model.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="chunkPredictedHandler">Handler on each chunk predicted event. Invokes with dictionary where
		/// key is entity identifier and value is predicted result for that entity.</param>
		/// <exception cref="AggregateException">When at least one of chunk failed to predict.</exception>
		public void Predict(MLModelConfig modelConfig, Action<Dictionary<Guid, object>> chunkPredictedHandler) {
			var parameters = new Dictionary<string, object> {
				{ "BatchPredictedOn", modelConfig.BatchPredictedOn }
			};
			int chunkNumber = 0;
			var exceptions = new List<Exception>();
			Guid modelId = modelConfig.Id;
			var modelQueryAssembler = ClassFactory.Get<IMLModelQueryBuilder>(
				new ConstructorArgument("userConnection", _userConnection));
			Select select = modelQueryAssembler.BuildSelect(modelConfig.EntitySchemaId,
				modelConfig.BatchPredictionQuery, modelConfig.ColumnExpressions, modelConfig.BatchPredictionFilterData,
				parameters);
			DataLoader.LoadDataForPrediction(select, dataForPrediction => {
				chunkNumber++;
				if (dataForPrediction.Count == 0) {
					return;
				}
				IList<TOut> predictedValues;
				try {
					predictedValues = Predict(modelConfig, dataForPrediction);
				} catch (Exception ex) {
					_log.Warn($"Batch predict for chunk #{chunkNumber} failed - skipping. ModelId = {modelId}",
						ex);
					exceptions.Add(ex);
					return;
				}
				var results = new Dictionary<Guid, object>();
				for (int i = 0; i < dataForPrediction.Count; i++) {
					Dictionary<string, object> record = dataForPrediction[i];
					if (record.TryGetValue("Id", out object id) && Guid.TryParse(id.ToString(), out Guid recordId)) {
						if (results.ContainsKey(recordId)) {
							_log.Warn($"Prediction results for model " +
								$"{modelId} already contain key {recordId}. Check that select query " +
								$"for batch prediction returns unique value for column Id");
						} else {
							results.Add(recordId, predictedValues[i]);
							SavePredictionResult(modelId, modelConfig.ModelInstanceUId, recordId, predictedValues[i]);
						}
					} else {
						exceptions.Add(new Exception($"Rowset for model {modelId} contains a record without Id"));
					}
				}
				chunkPredictedHandler(results);
			});
			if (!exceptions.IsNullOrEmpty()) {
				throw new AggregateException(exceptions);
			}
		}

		/// <summary>
		/// Saves the predicted data to entities.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="predictedData">Dictionary where key is entity identifier and value is predicted
		/// result for that entity.</param>
		public void SavePredictedData(MLModelConfig modelConfig, Dictionary<Guid, object> predictedData) {
			if (predictedData.IsNullOrEmpty()) {
				_log.Info("MLBatchNumericPredictor.SavePredictedData: predictedData is empty. " +
					$"Model {modelConfig.Id}");
				return;
			}
			UpdateEntitiesTargetColumn(modelConfig, predictedData);
		}

		#endregion

	}

	#endregion

}

