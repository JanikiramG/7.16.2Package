namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Interface: ISysModuleStageHistoryRepository

	/// <summary>
	/// Provides methods for setting and retrieving stage history settings.
	/// </summary>
	public interface ISysModuleStageHistoryRepository
	{
		#region Methods: Public

		/// <summary>
		/// Finds stage setting.
		/// </summary>
		/// <param name="entitySchemaUId">Entity schema identifier.</param>
		/// <returns><see cref="StageHistorySetting"/></returns>
		StageHistorySetting Find(Guid entitySchemaUId);

		/// <summary>
		/// Gets stage setting.
		/// </summary>
		/// <param name="schemaName">Entity schema name.</param>
		/// <returns><see cref="StageHistorySetting"/></returns>
		StageHistorySetting Get(string schemaName);

		/// <summary>
		/// Saves stage setting.
		/// </summary>
		/// <param name="item"><see cref="StageHistorySetting"/></param>
		void Save(StageHistorySetting item);

		/// <summary>
		/// Gets all stage settings.
		/// </summary>
		IEnumerable<StageHistorySetting> GetAll();

		#endregion
	}

	#endregion

	#region Class: SysModuleStageHistoryRepository

	[DefaultBinding(typeof(ISysModuleStageHistoryRepository))]
	public class SysModuleStageHistoryRepository : ISysModuleStageHistoryRepository
	{

		#region Constants: Private

		private const string CacheKey = "StageHistorySetting";
		private const string SysModuleStageHistorySchemaName = "SysModuleStageHistory";

		#endregion

		#region Constructors: Public

		public SysModuleStageHistoryRepository(UserConnection userConnection) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private EntityCollection FetchSysModuleStageHistoryCollection() {
			var collection = new EntityCollection(UserConnection, SysModuleStageHistorySchemaName);
			collection.Load();
			return collection;
		}

		private IDictionary<Guid, StageHistorySetting> GetSafelyStageHistoryFromCache() {
			return GetStageHistoryFromCache() ?? new Dictionary<Guid, StageHistorySetting>();
		}

		private IDictionary<Guid, StageHistorySetting> GetStageHistoryFromCache() {
			return (IDictionary<Guid, StageHistorySetting>)UserConnection.ApplicationCache[CacheKey]; 
		}

		private void SetStageHistoryToCache(StageHistorySetting setting) {
			var cache = GetSafelyStageHistoryFromCache();
			cache[setting.EntitySchemaUId] = setting;
			UserConnection.ApplicationCache[CacheKey] = cache;
		}

		private IDictionary<Guid, StageHistorySetting> GetStageHistorySettings() {
			var settings = GetStageHistoryFromCache();
			if (settings == null) {
				FillStageHistorySettingsCache();
				settings = GetSafelyStageHistoryFromCache();
			}
			settings.Values.ForEach(value => {
				value.UserConnection = UserConnection;
			});
			return settings;
		}

		private void FillStageHistorySettingsCache() {
			UserConnection.ApplicationCache[CacheKey] = new Dictionary<Guid, StageHistorySetting>();
			var collection = FetchSysModuleStageHistoryCollection();
			foreach (var entity in collection) {
				CreateSettingFromEntity(entity);
			}
		}

		private void CreateSettingFromEntity(Entity entity) {
			var setting = new StageHistorySetting(UserConnection);
			setting.FillFromEntity(entity);
			SetStageHistoryToCache(setting);
		}

		private StageHistorySetting FindStageHistorySetting(Guid entitySchemaUId) {
			var settings = GetStageHistorySettings();
			settings.TryGetValue(entitySchemaUId, out var result);
			return result;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public IEnumerable<StageHistorySetting> GetAll() {
			var settings = GetStageHistorySettings();
			return settings.Values;
		}

		/// <inheritdoc />
		public void Save(StageHistorySetting setting) {
			setting.CheckArgumentNull(nameof(setting));
			EntitySchema schema = UserConnection.EntitySchemaManager
				.GetInstanceByName(SysModuleStageHistorySchemaName);
			var entity = schema.CreateEntity(UserConnection);
			entity.FetchFromDB(setting.Id);
			setting.FillEntity(entity);
			entity.Save(false);
			SetStageHistoryToCache(setting);
		}

		/// <inheritdoc />
		public StageHistorySetting Find(Guid entitySchemaUId) {
			var setting = FindStageHistorySetting(entitySchemaUId);
			return setting;
		}

		/// <inheritdoc />
		/// <exception cref="ItemNotFoundException">If can't find setting by <paramref name="schemaName"/>.</exception>
		public StageHistorySetting Get(string schemaName) {
			var schemaUId = UserConnection.EntitySchemaManager.GetItemByName(schemaName).UId;
			var setting = FindStageHistorySetting(schemaUId);
			if (setting == null) {
				throw new Common.ItemNotFoundException($"Schema name = {schemaName}");
			}
			return setting;
		}

		#endregion

	}

	#endregion
}

