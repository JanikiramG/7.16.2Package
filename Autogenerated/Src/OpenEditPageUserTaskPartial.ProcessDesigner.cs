namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using CoreEntityCollection = Terrasoft.Core.Entities.EntityCollection;
	using CoreEntitySchema = Terrasoft.Core.Entities.EntitySchema;
	using CoreEntitySchemaColumn = Terrasoft.Core.Entities.EntitySchemaColumn;

	#region Class: OpenEditPageUserTask

	/// <summary>
	/// Represents user task to open edit page.
	/// </summary>
	public partial class OpenEditPageUserTask
	{

		#region Methods: Protected

		/// <inheritdoc />
		protected override bool InternalExecute(ProcessExecutingContext context) {
			bool isRedo = (Status == ProcessStatus.Error && CurrentActivityId == Guid.Empty &&
				!ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, UId));
			bool isRunning = !CurrentActivityId.Equals(Guid.Empty) && !IsActivityCompleted;
			if (!isRunning || isRedo) {
				var editMode = (RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode);
				bool isActivityEntitySchema = GetIsActivityEntitySchema();
				Entity activity = null;
				IProcessEngine processEngine = UserConnection.ProcessEngine;
				if (isActivityEntitySchema) {
					if (editMode == RecordEditMode.New) {
						activity = CreateActivity();
						RecordId = CurrentActivityId;
					} else {
						CurrentActivityId = RecordId;
					}
				} else {
					Entity accompaningActivity = CreateAccompaningActivity();
					CoreEntitySchema activityEntitySchema = GetActivityEntitySchema();
					Guid resultColumnUId = activityEntitySchema.Columns.GetByName("Status").UId;
					processEngine.AddProcessListener(accompaningActivity, UId,
						GetConditionData(resultColumnUId, accompaningActivity));
					if (editMode == RecordEditMode.New) {
						RecordId = Guid.NewGuid();
					}
				}
				string serializedFilters = IsMatchConditions && DataSourceFilters.IsNotNullOrEmpty()
					? ConvertToProcessDataSourceFilters(ObjectSchemaId, DataSourceFilters)
					: null;
				if (activity == null) {
					if (editMode != RecordEditMode.New) {
						processEngine.AddProcessListener(RecordId, ObjectSchemaId, UId, serializedFilters);
					} else {
						processEngine.AddProcessListener(RecordId, ObjectSchemaId, UId, null, null,
							EntityChangeType.Inserted);
					}
				} else {
					processEngine.AddProcessListener(activity, UId, serializedFilters);
				}
			}
			InteractWithUser(context, isRunning, ShowExecutionPage);
			return false;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public override bool CompleteExecuting(params object[] parameters) {
			bool isActivityEntitySchema = GetIsActivityEntitySchema();
			Guid activityStatusId = isActivityEntitySchema
				? Guid.Empty
				: ProcessUserTaskUtilities.GetActivityStatus(UserConnection, CurrentActivityId);
			IProcessEngine processEngine = UserConnection.ProcessEngine;
			if (GetIsMatchedConditions()) {
				if (!isActivityEntitySchema && activityStatusId != ActivityConsts.CanceledStatusUId) {
					activityStatusId = ActivityConsts.CompletedStatusUId;
				}
				processEngine.RemoveActivityProcessListener(CurrentActivityId, UId, activityStatusId);
				if (!GetIsActivityEntitySchema()) {
					var editMode = (RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode);
					EntityChangeType entityChangeType = editMode == RecordEditMode.New
						? EntityChangeType.Inserted
						: EntityChangeType.Updated;
					processEngine.RemoveProcessListener(RecordId, ObjectSchemaId, UId, entityChangeType);
				}
				if (GenerateDecisionsFromColumn) {
					ResultParameter = GetResultParameter();
				}
				return base.CompleteExecuting(parameters);
			}
			if ((RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode) == RecordEditMode.New) {	
				string serializedFilters = IsMatchConditions && DataSourceFilters.IsNotNullOrEmpty()
					? ConvertToProcessDataSourceFilters(ObjectSchemaId, DataSourceFilters)
					: null;
				processEngine.AddProcessListener(RecordId, ObjectSchemaId, UId, serializedFilters);
				EditMode = (int)RecordEditMode.Existing;
			}
			if (activityStatusId == ActivityConsts.NewStatusUId) {
				ProcessUserTaskUtilities.SetActivityStatus(UserConnection, CurrentActivityId,
					ActivityConsts.InProgressUId);
			}
			return false;
		}

		/// <inheritdoc />
		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			ProcessUserTaskUtilities.AssignNotificationData(notification, Recommendation, StartIn, StartInPeriod);
			return notification;
		}

		/// <inheritdoc />
		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
			IProcessEngine processEngine = UserConnection.ProcessEngine;
			processEngine.RemoveActivityProcessListener(CurrentActivityId, UId, ActivityConsts.CanceledStatusUId);
			if (!GetIsActivityEntitySchema()) {
				var editMode = (RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode);
				EntityChangeType entityChangeType = editMode == RecordEditMode.New
					? EntityChangeType.Inserted
					: EntityChangeType.Updated;
				processEngine.RemoveProcessListener(RecordId, ObjectSchemaId, UId, entityChangeType);
			}
		}

		/// <inheritdoc />
		public override string GetExecutionData() {
			CoreEntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId);
			var defaultColumnValues = new Dictionary<string, object>();
			foreach (var columnValue in RecordColumnValues.Values) {
				var column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				if ((column.DataValueType is LookupDataValueType || column.DataValueType is MultiLookupDataValueType) &&
				    ((Guid)columnValue.Value).IsEmpty()) {
					continue;
				}
				defaultColumnValues[column.Name] = SerializeEntityColumn(column, columnValue.Value);
			}
			var editMode = (RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode);
			if (editMode == RecordEditMode.New) {
				EntitySchemaColumnCollection columns = entitySchema.Columns;
				defaultColumnValues["ProcessListeners"] =
					SerializeEntityColumn(columns.GetByName("ProcessListeners"), (int)EntityChangeType.Inserted);
			}
			string actionName = GetActionName();
			string informationOnStep = LocalizableString.IsNullOrEmpty(InformationOnStep)
				? GetParameterValue("InformationOnStep")?.ToString() ?? string.Empty
				: InformationOnStep.Value;
			return SerializeToString(new {
				processId = ProcessUserTaskUtilities.GetParentProcessId(Owner),
				procElUId = UId,
				name = Name,
				isProcessExecutedBySignal = ProcessUserTaskUtilities.GetIsProcessExecutedBySignal(Owner),
				processName = Owner.Name,
				action = actionName,
				entitySchemaName = entitySchema.Name,
				recordId = RecordId,
				activityRecordId = CurrentActivityId,
				recommendation = GetActivityTitle(),
				informationOnStep,
				defaultValues = defaultColumnValues.Count > 0 ? defaultColumnValues : null,
				executionContext = ExecutionContext,
				completeExecution = actionName == "add",
				pageTypeId = PageTypeUId == Guid.Empty ? string.Empty : PageTypeUId.ToString(),
				nextProcElUId = "nextProcElUIdValue"
			});
		}

		/// <summary>
		/// Determines whether the conditions is satisfied.
		/// </summary>
		/// <returns><c>true</c> when conditions are successfully checked; otherwise - <c>false</c>.</returns>
		public virtual bool GetIsMatchedConditions() {
			if (!IsMatchConditions || DataSourceFilters.IsNullOrEmpty()) {
				return true;
			}
			CoreEntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId);
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchema.Name) {
				UseAdminRights = false
			};
			esq.AddColumn(entitySchema.PrimaryColumn.Name);
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			if (esq.Filters.Count == 0) {
				return true;
			}
			if (esq.Filters.Count == 1) {
				if (esq.Filters[0] is EntitySchemaQueryFilterCollection filterGroup && filterGroup.Count == 0) {
					return true;
				}
			}
			Entity entity = esq.GetEntity(UserConnection, RecordId);
			return entity != null;
		}

		/// <summary>
		/// Returns value of the result parameter.
		/// </summary>
		/// <returns></returns>
		public virtual Guid GetResultParameter() {
			if (string.IsNullOrEmpty(DecisionalColumnMetaPath)) {
				return Guid.Empty;
			}
			Guid resultParameterId = Guid.Empty;
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId);
			var columnSchema = entitySchema.GetSchemaColumnByMetaPath(DecisionalColumnMetaPath);
			var esq = new EntitySchemaQuery(entitySchema) {
				UseAdminRights = false
			};
			var column = esq.AddColumn(columnSchema.Name);
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", RecordId));
			CoreEntityCollection resultCollection = esq.GetEntityCollection(UserConnection);
			if (resultCollection.Count != 0) {
				resultParameterId = resultCollection.First.Value.GetTypedColumnValue<Guid>(column.ValueQueryAlias);
			}
			return resultParameterId;
		}

		/// <summary>
		/// Returns entity of the accompanying Activity.
		/// </summary>
		/// <returns>A new instance of the entity.</returns>
		public virtual Entity CreateAccompaningActivity() {
			CoreEntitySchema activitySchema = GetActivityEntitySchema();
			Entity activity = activitySchema.CreateEntity(UserConnection);
			activity.UseAdminRights = false;
			string title = GetActivityTitle();
			activity.SetColumnValue("Title", title);
			activity.SetDefColumnValues();
			activity.SetColumnValue("TypeId", ActivityConsts.TaskTypeUId);
			DateTime startDate = GetDateTime(UserConnection.CurrentUser.GetCurrentDateTime(), StartIn,
				(ProcessDurationPeriod)StartInPeriod);
			activity.SetColumnValue("StartDate", startDate);
			DateTime dateTime = GetDateTime(startDate, Duration, (ProcessDurationPeriod)DurationPeriod);
			activity.SetColumnValue("DueDate", dateTime);
			activity.SetColumnValue("ActivityCategoryId", ActivityCategory);
			activity.SetColumnValue("ShowInScheduler", ShowInScheduler);
			if (OwnerId != Guid.Empty) {
				activity.SetColumnValue("OwnerId", OwnerId);
				if (RemindBefore != 0) {
					activity.SetColumnValue("RemindToOwner", true);
					dateTime = GetDateTime(startDate, -1 * RemindBefore, (ProcessDurationPeriod)RemindBeforePeriod);
					activity.SetColumnValue("RemindToOwnerDate", dateTime);
				}
			}
			SpecifyActivityColumnValues(activity);
			activity.PrimaryColumnValue = Guid.NewGuid();
			IsActivityCompleted = false;
			CurrentActivityId = activity.PrimaryColumnValue;
			return activity;
		}

		/// <summary>
		/// Returns date and time with the specified offset period.
		/// </summary>
		/// <param name="dateTime">Date time.</param>
		/// <param name="offset">Offset value.</param>
		/// <param name="offsetPeriod">Offset period.</param>
		/// <returns></returns>
		public virtual DateTime GetDateTime(DateTime dateTime, int offset, ProcessDurationPeriod offsetPeriod) {
			return ProcessUserTaskUtilities.NewDate(dateTime, offset, offsetPeriod);
		}

		/// <summary>
		/// Returns type of the activity.
		/// </summary>
		/// <returns>Lookup value.</returns>
		public virtual Guid GetActivityType() {
			CoreEntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId);
			foreach (var columnValue in RecordColumnValues.Values) {
				CoreEntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				if (column.Name == "Type" && columnValue.Value != null) {
					var typeId = (Guid)columnValue.Value;
					if (typeId != Guid.Empty) {
						return typeId;
					}
				}
			}
			return PageTypeUId;
		}

		/// <summary>
		/// Returns title of the activity.
		/// </summary>
		/// <returns>Activity title.</returns>
		public virtual string GetActivityTitle() {
			return ProcessUserTaskUtilities.GetActivityTitle(this, Recommendation, CurrentActivityId);
		}

		/// <summary>
		/// Returns serialized filter that matches final status column values.
		/// </summary>
		/// <param name="resultColumnUId">The status column identifier.</param>
		/// <param name="activity">The activity.</param>
		public virtual string GetConditionData(Guid resultColumnUId, Entity activity) {
			return ProcessUserTaskUtilities.GetConditionData(UserConnection, resultColumnUId, activity);
		}

		/// <summary>
		/// Serializes value of the entity column.
		/// </summary>
		/// <param name="schemaColumn">Schema column.</param>
		/// <param name="columnValue">Column value.</param>
		/// <returns></returns>
		public virtual object SerializeEntityColumn(CoreEntitySchemaColumn schemaColumn, object columnValue) {
			if (schemaColumn == null || columnValue == null) {
				return string.Empty;
			}
			if (schemaColumn.DataValueType is BooleanDataValueType) {
				return DataTypeUtilities.ValueAsType<bool>(columnValue);
			}
			if (schemaColumn.IsLookupType) {
				var primaryColumnValue = Column.Parameter(DataTypeUtilities.ValueAsType<Guid>(columnValue));
				var referenceSchema = schemaColumn.ReferenceSchema;
				var displayValueSelect = 
					new Select(UserConnection)
						.Column(referenceSchema.PrimaryDisplayColumn.Name)
					.From(referenceSchema.Name)
					.Where(referenceSchema.PrimaryColumn.Name).IsEqual(primaryColumnValue) as Select;
				return new {
					value = columnValue,
					displayValue = displayValueSelect?.ExecuteScalar<string>()
				};
			}
			if (schemaColumn.DataValueType is DateTimeDataValueType dateTimeDataValueType) {
				var dateTime = (DateTime)columnValue;
				if (dateTime == DateTime.MinValue) {
					return null;
				}
				if (dateTime.Kind != DateTimeKind.Unspecified) {
					columnValue = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
				}
				string value = DateTimeDataValueType.Serialize(columnValue, TimeZoneInfo.Utc);
				return new {
					dataValueType = (int)dateTimeDataValueType.ToEnum(),
					value
				};
			}
			return DataTypeUtilities.ValueAsType<string>(columnValue);
		}

		/// <summary>
		/// Determines whether the current entity schema is Activity.
		/// </summary>
		/// <returns></returns>
		public virtual bool GetIsActivityEntitySchema() {
			return ObjectSchemaId == GetActivityEntitySchemaUId();
		}

		/// <summary>
		/// Record edit mode.
		/// </summary>
		/// <returns>Edit mode of the record.</returns>
		public virtual string GetActionName() {
			var editMode = (RecordEditMode)Enum.ToObject(typeof(RecordEditMode), EditMode);
			if (editMode == RecordEditMode.New) {
				if (GetIsActivityEntitySchema() || GetIsExecuted()) {
					return "edit";
				} 
				return "add";
			}
			return "edit";
		}

		/// <summary>
		/// Returns UId of the Activity schema.
		/// </summary>
		public virtual Guid GetActivityEntitySchemaUId() {
			return ActivityConsts.ActivityEntitySchemaUId;
		}

		/// <summary>
		/// Creates entity of the Activity.
		/// </summary>
		/// <returns>A new instance of the entity.</returns>
		public virtual Entity CreateActivity() {
			CoreEntitySchema activitySchema = GetActivityEntitySchema();
			Entity activity = activitySchema.CreateEntity(UserConnection);
			activity.UseAdminRights = false;
			string activityTitle = GetActivityTitle();
			activity.SetColumnValue("Title", activityTitle);
			activity.SetDefColumnValues();
			foreach (KeyValuePair<string, object> columnValue in RecordColumnValues.Values) {
				CoreEntitySchemaColumn column = activitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
				if ((column.DataValueType is LookupDataValueType || column.DataValueType is MultiLookupDataValueType) &&
						((Guid)columnValue.Value).IsEmpty()) {
					continue;
				}
				activity.SetColumnValue(column, columnValue.Value);
			}
			var columnDocument = activity.Schema.Columns.FindByName("Document");
			if (columnDocument != null) {
				object document = activity.GetColumnValue(columnDocument);
				if (document != null) {
					Document = (Guid)document;
				}
			}
			SpecifyActivityColumnValues(activity);
			CurrentActivityId = activity.PrimaryColumnValue;
			IsActivityCompleted = false;
			PageTypeUId = GetActivityType();
			return activity;
		}

		/// <summary>
		/// Returns instance of the Activity schema.
		/// </summary>
		/// <returns>Activity schema.</returns>
		public virtual CoreEntitySchema GetActivityEntitySchema() {
			return UserConnection.EntitySchemaManager.GetInstanceByName("Activity");
		}

		/// <summary>
		/// Determines whether the current process element is executed.
		/// </summary>
		/// <returns></returns>
		public virtual bool GetIsExecuted() {
			CoreEntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(ObjectSchemaId);
			var select = 
				(Select)new Select(UserConnection)
					.Column("Id")
				.From(entitySchema.Name)
				.Where("Id").IsEqual(Column.Parameter(RecordId));
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					return dataReader.Read();
				}
			}
		}

		/// <summary>
		/// Specifies column values of the activity.
		/// </summary>
		/// <param name="activity">Activity entity.</param>
		public virtual void SpecifyActivityColumnValues(Entity activity) {
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Account", Account);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Contact", Contact);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Lead", Lead);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Opportunity", Opportunity);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Document", Document);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Invoice", Invoice);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Case", Case);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Contract", Contract);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Change", Change);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Release", Release);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Problem", Problem);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Project", Project);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Order", Order);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Requests", Requests);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Listing", Listing);
			ActivityUserTaskHelper.SpecifyActivityLookupColumnValue(activity, "Property", Property);
			activity.SetColumnValue("ProcessElementId", UId);
			string allowedResult = GetResultAllowedValues();
			activity.SetColumnValue("AllowedResult", allowedResult);
		}

		#endregion

	}

	#endregion

}
