namespace Terrasoft.Configuration.ForecastV2
{
	using global::Common.Logging;
	using Newtonsoft.Json;
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: ForecastCalculatorExecutor

	/// <summary>
	/// Executes forecast columns calculation job.
	/// </summary>
	/// <seealso cref="Terrasoft.Core.IJobExecutor" />
	public class ForecastCalculatorExecutor : IJobExecutor
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger<ForecastCalculatorExecutor>();

		#endregion

		#region Methods: Private

		private IForecastCalculator GetForecastCalculator(UserConnection userConnection, string type) {
			return ClassFactory.Get<IForecastCalculator>(type,
				new ConstructorArgument("userConnection", userConnection));
		}

		private string GetLocalizableString(UserConnection userConnection, string name) {
			return userConnection.GetLocalizableString(GetType().Name, name) ?? string.Empty;
		}

		private void CreateReminding(UserConnection userConnection, Guid forecastId) {
			var remindingUtilities = ClassFactory.Get<RemindingUtilities>();
			var sheetRepository = ClassFactory.Get<IForecastSheetRepository>(
				new ConstructorArgument("userConnection", userConnection));
			var sheet = sheetRepository.GetSheet(forecastId);
			Guid entitySchemaUId = userConnection.EntitySchemaManager.GetItemByName("ForecastSheet").UId;
			var _currentUserContactId = userConnection.CurrentUser.ContactId;
			var config = new RemindingConfig(entitySchemaUId) {
				AuthorId = _currentUserContactId,
				ContactId = _currentUserContactId,
				SubjectId = forecastId,
				Description = GetLocalizableString(userConnection, "RemindingDescription"),
				PopupTitle = string.Format(GetLocalizableString(userConnection, "RemindingPopupTitle"),
					sheet.Name)
			};
			var message = new {
				forecastId
			};
			MsgChannelUtilities.PostMessage(userConnection, "UpdateForecasts", JsonConvert.SerializeObject(message));
			remindingUtilities.CreateReminding(userConnection, config);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Executes job operation.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="parameters">The parameters.</param>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			var forecastId = (Guid)parameters["ForecastId"];
			var periodIds = parameters["PeriodIds"] as List<Guid>;
			var isUseSystemUser = (bool)parameters["IsUseSystemUser"];
			_log.Info($"Forecast calculation started. ForecastId:{forecastId}"); 
			var userConnectionForCalculation = userConnection;
			if (isUseSystemUser) {
				userConnectionForCalculation = userConnection.AppConnection.SystemUserConnection;
			}
			IForecastCalculator objectValueColumnsCalculator = GetForecastCalculator(userConnectionForCalculation,
				ForecastConsts.ObjectValueColumnTypeName);
			var forecastParams = new ForecastCalcParams(forecastId, periodIds);
			objectValueColumnsCalculator.Calculate(forecastParams);
			IForecastCalculator formulaColumnsCalculator = GetForecastCalculator(userConnectionForCalculation,
				ForecastConsts.FormulaColumnTypeName);
			formulaColumnsCalculator.Calculate(forecastParams);
			_log.Info($"Forecast calculation ended. ForecastId:{forecastId}"); 
			CreateReminding(userConnection, forecastId);
		}

		#endregion

	}

	#endregion

}
