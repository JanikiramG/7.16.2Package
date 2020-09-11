namespace Terrasoft.Configuration.ForecastV2
{
	using global::Common.Logging;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using Terrasoft.Core.Store;

	#region Interface: IForecastSheetRepository

	/// <summary>
	/// Provides methods to retrieve information about the forecast.
	/// </summary>
	public interface IForecastSheetRepository
	{
		/// <summary>
		/// Gets the sheet.
		/// </summary>
		/// <param name="forecastId">The forecast identifier.</param>
		/// <returns><see cref="Sheet"/></returns>
		Sheet GetSheet(Guid forecastId);
	}

	/// <summary>
	/// Forecast sheet.
	/// </summary>
	public class Sheet
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the period type identifier.
		/// </summary>
		/// <value>
		/// The period type identifier.
		/// </value>
		public Guid PeriodTypeId { get; set; }

		/// <summary>
		/// Gets or sets the setting.
		/// </summary>
		/// <value>
		/// The setting.
		/// </value>
		public SheetSetting Setting { get; set; }

		/// <summary>
		/// Gets or sets the forecast entity identifier.
		/// </summary>
		/// <value>
		/// The forecast entity identifier.
		/// </value>
		public Guid ForecastEntityUId { get; set; }

		/// <summary>
		/// Gets or sets the forecast entity in cell identifier.
		/// </summary>
		/// <value>
		/// The forecast entity in cell identifier.
		/// </value>
		public Guid ForecastEntityInCellUId { get; set; }

		/// <summary>
		/// Returns hierarchy collection from settings.
		/// </summary>
		/// <returns>Hierarchy items collection</returns>
		public IEnumerable<HierarchySettingItem> GetHierarchyItems() {
			return Setting?.Hierarchy ?? new HierarchySettingItem[0];
		}

		/// <summary>
		/// Returns entity in forecast's value column by current sheet.
		/// </summary>
		/// <param name="sheet">Forecast Sheet.</param>
		/// <param name="userConnection">User connection.</param>
		/// <returns>Value column.</returns>
		public EntitySchemaColumn GetEntityInForecastValueColumn(UserConnection userConnection) {
			EntitySchema schema = userConnection.EntitySchemaManager.GetInstanceByUId(ForecastEntityInCellUId);
			return schema.Columns.FindByName("Value");
		}

		/// <summary>
		/// Returns entity in forecast cell entity reference column.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <returns>Entity reference column</returns>
		public EntitySchemaColumn GetEntityReferenceColumn(UserConnection userConnection) {
			EntitySchema forecastEntityInCell = userConnection.EntitySchemaManager
				.FindInstanceByUId(ForecastEntityInCellUId);
			EntitySchemaColumn column = forecastEntityInCell?.Columns.FirstOrDefault(c =>
				c.ReferenceSchemaUId == ForecastEntityUId && !c.IsInherited);
			return column;
		}
	}

	/// <summary>
	/// Forecast sheet setting.
	/// </summary>
	[Serializable]
	public class SheetSetting
	{
		/// <summary>
		/// Gets or sets the hierarchy.
		/// </summary>
		/// <value>
		/// The hierarchy.
		/// </value>
		public IEnumerable<HierarchySettingItem> Hierarchy { get; set; }
	}

	/// <summary>
	/// Forecast sheet hierarchy setting item.
	/// </summary>
	[Serializable]
	public class HierarchySettingItem
	{
		/// <summary>
		/// Gets or sets the column path.
		/// </summary>
		/// <value>
		/// The column path.
		/// </value>
		public string ColumnPath { get; set; }
		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		/// <value>
		/// The level.
		/// </value>
		public int Level { get; set; }
	}

	#endregion

	#region Class: ForecastSheetCacheListener

	[EntityEventListener(SchemaName = "ForecastSheet")]
	public class ForecastSheetCacheListener : BaseEntityEventListener
	{

		#region Methods: Private

		private void ClearCache(UserConnection userConnection, Guid forecastId) {
			var group = userConnection.ApplicationCache.WithLocalCaching(ForecastSheetRepository.CacheGroupName);
			string key = forecastId.ToString();
			group.Remove(key);
		}

		#endregion

		#region Methods: Public

		/// <summary>Hadles entity Saving event.</summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" />
		/// instance containing the event data.</param>
		public override void OnSaving(object sender, EntityBeforeEventArgs e) {
			base.OnSaving(sender, e);
			var entity = (Entity)sender;
			ClearCache(entity.UserConnection, entity.PrimaryColumnValue);
		}

		/// <summary>Hadles entity Deleting event.</summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" />
		/// instance containing the event data.</param>
		public override void OnDeleting(object sender, EntityBeforeEventArgs e) {
			base.OnDeleting(sender, e);
			var entity = (Entity)sender;
			ClearCache(entity.UserConnection, entity.PrimaryColumnValue);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastSheetRepository

	/// <summary>
	/// Provides methods to retrieve information about the forecast.
	/// </summary>
	/// <seealso cref="IForecastSheetRepository" />
	[DefaultBinding(typeof(IForecastSheetRepository))]
	public class ForecastSheetRepository : IForecastSheetRepository
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("Forecast");

		#endregion

		#region Fields: Public

		public static readonly string CacheGroupName = "ForecastSheet";

		#endregion

		#region Constructors: Public

		public ForecastSheetRepository(UserConnection userConnection) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private Sheet GetSheet(Entity entity) {
			var result = new Sheet();
			result.Id = entity.PrimaryColumnValue;
			result.Name = entity.GetTypedColumnValue<string>(ForecastConsts.Name);
			result.PeriodTypeId = entity.GetTypedColumnValue<Guid>(ForecastConsts.PeriodType);
			result.ForecastEntityUId = entity.GetTypedColumnValue<Guid>(ForecastConsts.ForecastEntity);
			result.ForecastEntityInCellUId = entity.GetTypedColumnValue<Guid>(ForecastConsts.ForecastEntityInCell);
			var settingJson = entity.GetTypedColumnValue<string>(ForecastConsts.Setting);
			result.Setting = GetSetting(settingJson);
			return result;
		}

		private SheetSetting GetSetting(string settingJson) {
			try {
				return Json.Deserialize<SheetSetting>(settingJson);
			}
			catch (Exception e) {
				_log.ErrorFormat("An error occurred while JSON not valid: {0}, Message: {1}, StackTrace: {2}",
					settingJson, e.Message, e.StackTrace);
			}
			return new SheetSetting();
		}

		private Entity GetEntity(Guid forecastId) {
			EntitySchemaQuery esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, ForecastConsts.ForecastSheet);
			esq.Cache = UserConnection.ApplicationCache.WithLocalCaching(CacheGroupName);
			esq.CacheItemName = forecastId.ToString();
			esq.AddAllSchemaColumns();
			Entity entity = esq.GetEntity(UserConnection, forecastId);
			return entity;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the sheet.
		/// </summary>
		/// <param name="forecastId">The forecast identifier.</param>
		/// <returns><see cref="Sheet"/></returns>
		public Sheet GetSheet(Guid forecastId) {
			forecastId.CheckArgumentEmpty(nameof(forecastId));
			Entity entity = GetEntity(forecastId);
			return GetSheet(entity);
		}

		#endregion

	}

	#endregion

}

