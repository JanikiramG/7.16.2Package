namespace Terrasoft.Configuration.ForecastV2
{
	using Newtonsoft.Json.Linq;
	using Newtonsoft.Json;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Factories;
	using Terrasoft.UI.WebControls.ResourceHandlers;
	using global::Common.Logging;

	#region Class: ForecastColumnEntityEventListener

	/// <summary>
	/// ForecastColumn entity save event handler
	/// </summary>
	[EntityEventListener(SchemaName = "ForecastColumn")]
	public class ForecastColumnEntityEventListener : BaseEntityEventListener
	{

		#region Class: DTO

		private class FilterPeriod
		{
			[JsonProperty("Id")]
			public string Id { get; set; }
		}

		private class Filters
		{
			[JsonProperty("filterPeriods")]
			public IEnumerable<FilterPeriod> FilterPeriods { get; set; }
		}

		private class Profile
		{
			[JsonProperty("filters")]
			public Filters Filters { get; set; }
		}

		#endregion

		#region Fields: Private

		private bool _isSettingsChanged;
		private bool _isFormulaColumn;
		private static readonly ILog _log = LogManager.GetLogger(nameof(ForecastColumnEntityEventListener));

		#endregion

		#region Methods: Private

		private bool IsSettingsChanged(Entity entity) {
			var changedColumns = entity.GetChangedColumnValues();
			return changedColumns.Any(columm => columm.Name.Equals("Settings"));
		}

		private UserProfileResourceHandler GetUserProfileResourceHandler(UserConnection userConnection, string profileKey) {
			return ClassFactory.Get<UserProfileResourceHandler>(
					new ConstructorArgument("userConnection", userConnection),
					new ConstructorArgument("resourceName", profileKey));
		}

		private IEnumerable<Guid> GetPeriodsId(UserConnection userConnection, Guid forecastId) {
			string profileKey = "ForecastProfile";
			UserProfileResourceHandler handler = GetUserProfileResourceHandler(userConnection, profileKey);
			byte[] profileByte = handler.Fetch();
			string profileDataStr = Encoding.UTF8.GetString(profileByte);
			if (string.IsNullOrEmpty(profileDataStr)) {
				return Enumerable.Empty<Guid>();
			}
			Profile profile;
			try {
				var profileData = (JObject)Json.Deserialize(profileDataStr);
				var filtersObj = profileData.Value<JObject>(forecastId.ToString());
				profile = Json.Deserialize<Profile>(filtersObj.ToString());
			} catch (Exception ex) {
				_log.Error(ex);
				return Enumerable.Empty<Guid>();
			}
			var periodsId = profile?.Filters?.FilterPeriods?.Select(period => {
				return new Guid(period.Id);
			});
			return periodsId;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles entity Saving event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" /> instance containing the event data.</param>
		public override void OnSaving(object sender, EntityBeforeEventArgs e) {
			base.OnSaving(sender, e);
			var entity = (Entity)sender;
			var userConnection = entity.UserConnection;
			if (!userConnection.GetIsFeatureEnabled("CalcFormulaOnSave")) {
				return;
			}
			var columnType = entity.GetTypedColumnValue<Guid>("TypeId");
			_isSettingsChanged = IsSettingsChanged(entity);
			_isFormulaColumn = columnType.Equals(ForecastConsts.FormulaColumnTypeId);
		}

		/// <summary>Handles entity Saved event.</summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityAfterEventArgs"/> instance containing the event data.</param>
		public override void OnSaved(object sender, EntityAfterEventArgs e) {
			base.OnSaved(sender, e);
			var entity = (Entity)sender;
			var userConnection = entity.UserConnection;
			if (!userConnection.GetIsFeatureEnabled("CalcFormulaOnSave")) {
				return;
			}
			if (_isSettingsChanged && _isFormulaColumn) {
				var forecastId = entity.GetTypedColumnValue<Guid>("SheetId");
				IEnumerable<Guid> periodsId = GetPeriodsId(userConnection, forecastId);
				var calculator = ClassFactory.Get<IForecastCalculator>(ForecastConsts.FormulaColumnTypeName,
					new ConstructorArgument("userConnection", userConnection));
				calculator.Calculate(new ForecastCalcParams(forecastId, periodsId));
			}
		}

		#endregion

	}

	#endregion
}

