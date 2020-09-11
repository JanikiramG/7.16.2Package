namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Factories;

	#region Class: ProjectRepository

	/// <summary>
	/// Repository for Project entity.
	/// </summary>
	public class ProjectRepository
	{

		#region Constants: Private

		private const string ProjectIdParameterName = "ProjectId";
		private const string GuidTypeName = "Guid";

		#endregion

		#region Field: Protected
		
		protected UserConnection UserConnection;

		protected EntitySchema SchemaInstance;

		protected List<Entity> InsertQueue;

		protected bool ShouldSelectOnlyClonableColumns;
		
		#endregion
		
		#region Constructors: Public

		public ProjectRepository(UserConnection userConnection, bool shouldSelectOnlyClonableColumns) {
			UserConnection = userConnection;
			InsertQueue = new List<Entity>();
			SchemaInstance = userConnection.EntitySchemaManager.FindInstanceByName("Project");
			ShouldSelectOnlyClonableColumns = shouldSelectOnlyClonableColumns;
		}
		
		#endregion

		#region Methods: Private
		
		private HierarchicalSelectOptions GetSelectOptions(Guid projectId) {
			var hierarhicalOptions = new HierarchicalSelectOptions {
				PrimaryColumnName = "Id",
				ParentColumnName = "ParentProjectId",
				SelectType = HierarchicalSelectType.Children,
				IncludeLevelColumn = true
			};
			QueryCondition startingCondition = hierarhicalOptions.StartingPrimaryColumnCondition;
			startingCondition.LeftExpression = new QueryColumnExpression("Id");
			startingCondition.IsEqual(new QueryParameter(ProjectIdParameterName, projectId, GuidTypeName));
			return hierarhicalOptions;
		}
		
		#endregion
		
		#region Methods: Protected
		
		protected virtual IList<string> GetSelectColumns() {
			IEnumerable<EntitySchemaColumn> columns = SchemaInstance.Columns;
			if (ShouldSelectOnlyClonableColumns) {
				columns = columns.Where(e => e.IsValueCloneable || e.Name == "Id");
			}
			var columnNames = columns.Select(e => e.ColumnValueName).ToList();
			return columnNames;
		}

		protected virtual Select GetProjectBaseSelect(Guid projectId, IList<string> columns) {
			Select select = new Select(UserConnection).From("Project");
			foreach (string column in columns) {
				select = select.Column("Project", column).As(column);
			}

			return select;
		}

		protected virtual Entity ProcessReaderRow(IDataReader reader,
			IList<string> columns) {
			Entity entity = SchemaInstance.CreateEntity(UserConnection);
			foreach (string column in columns) {
				entity.SetColumnValue(column, reader.GetColumnValue(column));
			}
			entity.ForceSetColumnValue("Level", reader.GetColumnValue("Level"));
			return entity;
		}
		
		protected virtual void SetCopiedRecordsRights() {
			RightsHelper rightHelper = ClassFactory.Get<RightsHelper>(new ConstructorArgument("userConnection", 
				UserConnection.AppConnection.SystemUserConnection));
			foreach (var entity in InsertQueue) {
				var recordRecordId = entity.GetTypedColumnValue<string>("Id");
				rightHelper.SetRecordRight(UserConnection.CurrentUser.Id, "Project", recordRecordId,
					(int)EntitySchemaRecordRightOperation.Read, (int)EntitySchemaRecordRightLevel.AllowAndGrant);
				rightHelper.SetRecordRight(UserConnection.CurrentUser.Id, "Project", recordRecordId,
					(int)EntitySchemaRecordRightOperation.Edit, (int)EntitySchemaRecordRightLevel.AllowAndGrant);
				rightHelper.SetRecordRight(UserConnection.CurrentUser.Id, "Project", recordRecordId,
					(int)EntitySchemaRecordRightOperation.Delete, (int)EntitySchemaRecordRightLevel.AllowAndGrant);
				
			}
		}

		#endregion
		
		#region Methods: Public
		
		/// <summary>
		/// Get project with all subordinate works.
		/// </summary>
		/// <param name="projectId">Project identifier</param>
		public virtual EntityCollection GetHierarchyCollection(Guid projectId) {
			IList<string> columns = GetSelectColumns();
			Select select = GetProjectBaseSelect(projectId, columns);
			select.HierarchicalOptions = GetSelectOptions(projectId);
			EntityCollection result = new EntityCollection(UserConnection, SchemaInstance);
			using (DBExecutor executor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(executor)) {
					while (reader.Read()) {
						result.Add(ProcessReaderRow(reader, columns));
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Store item in queue before insert.
		/// </summary>
		/// <param name="entity">Project entity</param>
		public virtual void PrepareToInsert(Entity entity) {
			InsertQueue.Add(entity);
		}

		/// <summary>
		/// Insert all items in queue.
		/// </summary>
		public virtual void ExecuteInsert() {
			using (DBExecutor executor = UserConnection.EnsureDBConnection()) {
				executor.StartTransaction();
				try {
					foreach (Entity entity in InsertQueue) {
						Insert insert = entity.CreateInsert();
						insert.Execute();
					}
					
					executor.CommitTransaction();
				}
				catch (Exception e) {
					executor.RollbackTransaction();
					throw;
				}
			}
			SetCopiedRecordsRights();
			InsertQueue.Clear();
		}
		
		#endregion
	}
	
	#endregion
}
