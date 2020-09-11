namespace Terrasoft.Sync
{
	using System;
	using IntegrationApi.Interfaces;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: EntitySynchronizerHelper 

	/// <summary>
	/// Provides methods for parallel synchronization conflicts resolve.
	/// New entity, created using synchronization, registered in "EntitySynchronizer" lookup.
	/// Unique index violation prevent dublicate creation.
	/// </summary>
	[DefaultBinding(typeof(IEntitySynchronizerHelper))]
	public class EntitySynchronizerHelper: IEntitySynchronizerHelper
	{
		#region Constants: Private

		/// <summary>
		/// Resolve conflicts lookup entity name.
		/// </summary>
		private const string _entitySynchronizerName = "EntitySynchronizer";
		
		/// <summary>
		/// Records older than this value mast be removed.
		/// </summary>
		private const int _recordTtlDays = -3;

		#endregion

		#region Methods: Private
		
		/// <summary>
		/// Generates base <see cref="Select"/> to <see cref="EntitySynchronizerHelper._entitySynchronizerName"/>.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <returns><see cref="Select"/> instance.</returns>
		private Select GetEntitySynchronizerSelect(UserConnection userConnection) {
			return new Select(userConnection)
				.Column(Func.Count("Id"))
				.From(_entitySynchronizerName) as Select;
		}

		/// <summary>
		/// Checks if bpm enitity already synchronized to remote store.
		/// </summary>
		/// <param name="entityId"><see cref="Entity.Id"/></param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>,
		/// <param name="integrationSystem">Integration system name.</param>
		/// <returns>True, if entity already registered as synchronized.</returns>
		private bool GetEntityLockedForRemoteSync(string entityId, UserConnection userConnection,
				string integrationSystem = null) {
			Select select = GetEntitySynchronizerSelect(userConnection)
				.Where("EntityId").IsEqual(Column.Parameter(Guid.Parse(entityId)))
				.And("CreatedById").IsEqual(Column.Parameter(userConnection.CurrentUser.ContactId)) as Select;
			if (!string.IsNullOrEmpty(integrationSystem)) {
				select = select.And("IntegrationSystem").IsEqual(Column.Parameter(integrationSystem)) as Select;
			}
			return select.ExecuteScalar<int>() > 0;
		}
		
		/// <summary>
		/// Checks if remote enitity already synchronized to bpm.
		/// </summary>
		/// <param name="remoteItemUniqueKey">Unique string for item in remote store.</param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system name.</param>
		/// <returns>True, if entity already registered as synchronized.</returns>
		private bool GetEntityLockedForLocalSync(string remoteItemUniqueKey, UserConnection userConnection,
				string integrationSystem = null) {
			Select select = GetEntitySynchronizerSelect(userConnection)
				.Where("RemoteKey").IsEqual(Column.Parameter(remoteItemUniqueKey)) as Select;
			if (!string.IsNullOrEmpty(integrationSystem)) {
				select = select.And("IntegrationSystem").IsEqual(Column.Parameter(integrationSystem)) as Select;
			}
			return select.ExecuteScalar<int>() > 0;
		}
		
		/// <summary>
		/// Creates record in <see cref="EntitySynchronizerHelper._entitySynchronizerName"/> lookup.
		/// </summary>
		/// <param name="entityKey">Entity unique key.</param>
		/// <param name="direction">Sync direction.</param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system name.</param>
		private void CreateEntitySynchronizer(string entityKey, bool direction, UserConnection userConnection,
				string integrationSystem = null) {
			string remoteItemUniqueKey = direction ? Guid.NewGuid().ToString() : entityKey;
			Guid entityId = direction ? Guid.Parse(entityKey) : Guid.NewGuid();
			var entitySynchronizerSchema = userConnection.EntitySchemaManager.GetInstanceByName(_entitySynchronizerName);
			var entitySynchronizer = entitySynchronizerSchema.CreateEntity(userConnection);
			entitySynchronizer.SetDefColumnValues();
			entitySynchronizer.SetColumnValue("EntityId", entityId);
			entitySynchronizer.SetColumnValue("RemoteKey", remoteItemUniqueKey);
			entitySynchronizer.SetColumnValue("IntegrationSystem", integrationSystem);
			entitySynchronizer.Save();
		}
		
		/// <summary>
		/// Removes records older than <see cref="EntitySynchronizerHelper._recordTtlDays"/> days for current user.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		private void RemoveEntitySynchrinizer(UserConnection userConnection) {
			var delete = GetBaseEntitySynchronizerDelete(userConnection)
					.And("CreatedOn").IsLess(Column.Parameter(DateTime.Now.AddDays(_recordTtlDays))) as Delete;
			delete.Execute();
		}

		/// <summary>
		/// Creates delete query for current user EntitySynchronizer items.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <returns><see cref="Delete"/> instance.</returns>
		private Delete GetBaseEntitySynchronizerDelete(UserConnection userConnection) {
			return new Delete(userConnection)
				.From(_entitySynchronizerName).WithHints(new RowLockHint())
				.Where("CreatedById").IsEqual(Column.Parameter(userConnection.CurrentUser.ContactId)) as Delete;
		}

		/// <summary>
		/// Checks if enitity locked for synchronization.
		/// </summary>
		/// <param name="entityKey">Unique string for entity.</param>
		/// <param name="direction">Sync direction.</param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system name.</param>
		/// <returns>True, if entity already locked for synchronization.</returns>
		private bool GetEntityLockedForSync(string entityKey, bool direction, UserConnection userConnection,
				string integrationSystem = null) {
			return direction
					? GetEntityLockedForRemoteSync(entityKey, userConnection, integrationSystem)
					: GetEntityLockedForLocalSync(entityKey, userConnection, integrationSystem);
		}
		
		/// <summary>
		/// Try to lock enitity for synchronization.
		/// </summary>
		/// <param name="entityKey">Unique string for entity.</param>
		/// <param name="direction">Sync direction.</param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system key.</param>
		/// <returns>True, if entity successfully locked for synchronization.</returns>
		private bool CanCreateNewEntity(string entityKey, bool direction, UserConnection userConnection,
				string integrationSystem = null) {
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction();
				try {
					if (!GetEntityLockedForSync(entityKey, direction, userConnection, integrationSystem)) {
						CreateEntitySynchronizer(entityKey, direction, userConnection, integrationSystem);
						dbExecutor.CommitTransaction();
						return true;
					}
					dbExecutor.CommitTransaction();
				} catch (DbOperationException) {
					dbExecutor.RollbackTransaction();
				}
			}
			return false;
		}
		
		#endregion
		
		#region Methods: Public

		/// <summary>
		/// Checks if entity synchronization to bpm allowed for current user.
		/// </summary>
		/// <param name="remoteItemUniqueKey">Unique string for item in remote store.</param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system key.</param>
		/// <returns>True, if entity synchronization allowed for current user.</returns>
		public bool CanCreateEntityInLocalStore(string remoteItemUniqueKey, UserConnection userConnection,
				string integrationSystem = null) {
			return CanCreateNewEntity(remoteItemUniqueKey, false, userConnection, integrationSystem);
		}

		/// <summary>
		/// Checks if entity synchronization to remote storage allowed for current user.
		/// </summary>
		/// <param name="entityId"><see cref="Entity.Id"/></param>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		/// <param name="integrationSystem">Integration system key.</param>
		/// <returns>True, if entity synchronization allowed for current user.</returns>
		public bool CanCreateEntityInRemoteStore(Guid entityId, UserConnection userConnection,
				string integrationSystem = null) {
			return CanCreateNewEntity(entityId.ToString(), true, userConnection, integrationSystem);
		}

		/// <summary>
		/// Removes records older than <see cref="EntitySynchronizerHelper._recordTtlDays"/> days for current user.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection/> instance.</param>
		public void ClearEntitySynchronizer(UserConnection userConnection) {
			RemoveEntitySynchrinizer(userConnection);
		}

		/// <summary>
		/// Removes current user locked records from <paramref name="integrationSystem"/>.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="integrationSystem">Integration system code.</param>
		public void UnlockEntities(UserConnection userConnection, string integrationSystem) {
			var delete = GetBaseEntitySynchronizerDelete(userConnection)
				.And("IntegrationSystem").IsEqual(Column.Parameter(integrationSystem));
			delete.Execute();
		}

		#endregion

	}

	#endregion

}

