namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using System.Reflection;
	using Core.Entities;
	using Terrasoft.Common;
	using Terrasoft.Core.Store;

	#region Enums: Public

	public enum NotificationProviderType
	{
		Visa = 0,
		Reminding = 1,
		Notification = 2,
		ESNNotification = 3,
		Anniversary = 4
	}

	#endregion

	#region Class: NotificationUtilities

	public class NotificationUtilities
	{
		#region Contants: Private

		private const string SysImageEntitySchemaTpl = "SysImage{0}Schema";
		private const string FinallyVisaStatusesKey = "FinallyVisaStatuses";

		#endregion

		#region Fields: Private

		private static Guid[] _finallyVisaStatuses;
		private static readonly ICacheStore _store;
		private static readonly object _locker = new Object();

		#endregion

		#region Constructors : Protected

		static NotificationUtilities() {
			_store = Store.Cache[CacheLevel.Workspace];
			_finallyVisaStatuses = _store.GetValue<Guid[]>(FinallyVisaStatusesKey);
		}

		#endregion

		#region Methods: Private

		private static Guid LoadSysImageBySchemaName(UserConnection userConnection, string name) {
			Select select = GetSysImageBySchemaNameSelect(userConnection, name);
			Guid result = Guid.Empty;
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						result = reader.GetColumnValue<Guid>("Id");
					}
				}
			}
			return result;
		}

		private static Select GetSysImageBySchemaNameSelect(UserConnection userConnection, string name) {
			var select = new Select(userConnection);
			select
				.Top(1)
				.Column("NotificationsSettings", "SysImageId").As("Id")
				.From("NotificationsSettings")
					.InnerJoin("SysSchema")
						.On("SysSchema", "UId").IsEqual("NotificationsSettings", "SysEntitySchemaUId")
				.Where("SysSchema", "Name").IsEqual(Column.Parameter(name));
			return select;
		}

		private static Guid GetSysImageCache(string key) {
			return (Guid)(_store.GetValue<object>(key) ?? Guid.Empty);
		}

		private static string GetSysImageCacheKey(string name) {
			return string.Format(SysImageEntitySchemaTpl, name);
		}


		private static void SaveToCacheStore(string key, object value) {
			_store[key] = value;
		}

		private static Guid[] LoadFinallyVisaStatuses(UserConnection userConnection) {
			Select select = GetLoadFinallyVisaStatusesSelect(userConnection);
			ICollection<Guid> finallyStatuses = new List<Guid>();
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						finallyStatuses.Add(reader.GetColumnValue<Guid>("Id"));
					}
				}
			}
			return finallyStatuses.ToArray();
		}

		private static Select GetLoadFinallyVisaStatusesSelect(UserConnection userConnection) {
			Select select =
				new Select(userConnection).Column("VisaStatus", "Id")
					.From("VisaStatus")
					.Where("VisaStatus", "IsFinal")
					.IsEqual(Column.Parameter(true)) as Select;
			return select;
		}

		#endregion

		#region Methods: Public

		public Type GetClassType(string className) {
			return Type.GetType(className);
		}

		public object GetClassInstance(string className, object[] parameters) {
			Type classType = GetClassType(className);
			return Activator.CreateInstance(classType, parameters);
		}

		public MethodInfo GetMethodInfo(string className, string methodName) {
			Type type = GetClassType(className);
			return type.GetMethod(methodName);
		}

		public object GetMethodResult(string className, string methodName, object[] parameters) {
			object instance = GetClassInstance(className, parameters);
			MethodInfo methodInfo = GetMethodInfo(className, methodName);
			if (methodInfo == null) {
				return null;
			}
			return methodInfo.Invoke(instance, null);
		}

		public List<string> GetNotificationProviderClassNames(NotificationProviderType type,
				UserConnection userConnection) {
			var result = new List<string>();
			if (userConnection.GetIsFeatureEnabled("NotificationV2") && type != NotificationProviderType.Visa) {
				return result;
			}
			var providersSelect = new Select(userConnection)
				.Column("NotificationProvider", "ClassName")
				.From("NotificationProvider")
				.Where("Type").IsEqual(Column.Parameter((int)type)) as Select;
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				using (var dataReader = providersSelect.ExecuteReader(dbExecutor)) {
					int columnIndex = dataReader.GetOrdinal("ClassName");
					while (dataReader.Read()) {
						result.Add(dataReader.GetString(columnIndex));
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Returns unique identification of the system image by schema name.
		/// </summary>
		/// <param name="userConnection">Specified instance of <see cref="Terrasoft.Core.UserConnection"/>.</param>
		/// <param name="name">Name of the manager item instance.</param>
		/// <returns>Unique identification of the system image by schema name.</returns>
		[Obsolete("Will be removed 7.12.2")]
		public static Guid GetSysImageBySchemaName(UserConnection userConnection, string name) {
			lock (_locker) {
				string key = GetSysImageCacheKey(name);
				Guid imageId = GetSysImageCache(key);
				if (imageId.Equals(Guid.Empty)) {
					imageId = LoadSysImageBySchemaName(userConnection, name);
					SaveToCacheStore(key, imageId);
				}
				return imageId;
			}
		}


		/// <summary>
		/// Returns final visa statuses.
		/// </summary>
		/// <param name="userConnection">Specified instance of <see cref="Terrasoft.Core.UserConnection"/>.</param>
		/// <returns>Final visa statuses.</returns>
		public static Guid[] GetFinallyVisaStatuses(UserConnection userConnection) {
			lock (_locker) {
				if (_finallyVisaStatuses != null && _finallyVisaStatuses.Any()) {
					return _finallyVisaStatuses;
				}
				_finallyVisaStatuses = LoadFinallyVisaStatuses(userConnection);
				SaveToCacheStore(FinallyVisaStatusesKey, _finallyVisaStatuses);
				return _finallyVisaStatuses;
			}
		}
		
		/// <summary>
		/// Returns sysAdminUnitId for contact.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="contactId">Contact uniqueidentifier.</param>
		/// <returns>SysAdminUnit uniqueidentifier.</returns>
		public static Guid GetSysAdminUnitId(UserConnection userConnection, Guid contactId) {
			var currentUser = userConnection.CurrentUser;
			if (currentUser.ContactId == contactId) {
				return currentUser.Id;
			}
			var entitySchemaManager = userConnection.EntitySchemaManager;
			var esq = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit") {
				UseAdminRights = false,
				IgnoreDisplayValues = true,
				CanReadUncommitedData = true,
				Cache = userConnection.ApplicationCache.WithLocalCaching("NotificationUsers"),
				CacheItemName = contactId.ToString()
			};
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var queryFilterItem = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactId);
			esq.Filters.Add(queryFilterItem);
			var entities = esq.GetEntityCollection(userConnection);
			if (entities.IsEmpty()) {
				return Guid.Empty;
			}
			var entity = entities.First.Value;
			return entity.GetTypedColumnValue<Guid>(esq.PrimaryQueryColumn.Name);
		}

		#endregion

	}

	#endregion
}

