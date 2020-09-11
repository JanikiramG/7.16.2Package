namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Reflection;
	using System.Text;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.WebService;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ProcessUserTaskUtilities

	public sealed class ProcessUserTaskUtilities : BaseProcessUserTaskUtilities
	{

		#region Constructors: Private

		private ProcessUserTaskUtilities() {
		}

		#endregion

		#region Methods: Private

		private static readonly ILog _log = LogManager.GetLogger("Process");

		private static EntitySchemaQuery CreateActivityConnectionEsq(EntitySchemaManager manager, Guid schemaUId) {
			var esq = new EntitySchemaQuery(manager, "EntityConnection") {
				CanReadUncommitedData = true,
				IgnoreDisplayValues = true,
				UseAdminRights = false
			};
			esq.AddColumn("ColumnUId");
			esq.CacheItemName = BaseProcessUserTaskUtilities.ProcessUserTaskSchemaManagerCacheItemName;
			var entityFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchemaUId",
				schemaUId);
			esq.Filters.Add(entityFilter);
			return esq;
		}

		private static LocalizableString GetSchemaElementCaption(ProcessActivity processElement) {
			BaseProcessSchemaElement schemaElement = processElement.GetSchemaElement();
			LocalizableString schemaElementCaption = schemaElement.Caption;
			return LocalizableString.IsNullOrEmpty(schemaElementCaption)
				? new LocalizableString("Terrasoft.Core",
					string.Concat("ProcessSchema", processElement.Schema.Name, ".Caption"))
				: schemaElementCaption;
		}

		#endregion

		#region Methods: Public

		public static DateTime NewDate(DateTime oldDate, int offset, ProcessDurationPeriod offsetPeriod) {
			var newDate = new DateTime();
			switch (offsetPeriod) {
				case ProcessDurationPeriod.Minutes:
					newDate = oldDate.AddMinutes(offset);
					break;
				case ProcessDurationPeriod.Hours:
					newDate = oldDate.AddHours(offset);
					break;
				case ProcessDurationPeriod.Days:
					newDate = oldDate.AddDays(offset);
					break;
				case ProcessDurationPeriod.Weeks:
					newDate = oldDate.AddDays(offset * 7);
					break;
				case ProcessDurationPeriod.Months:
					newDate = oldDate.AddMonths(offset);
					break;
			}
			return newDate;
		}

		/// <summary>
		/// Indicates that the given process is executed by signal.
		/// </summary>
		/// <param name="process">The process.</param>
		/// <returns><c>true</c> if the process executed by signal. Otherwise - <c>false</c>.
		/// </returns>
		public static bool GetIsProcessExecutedBySignal(Process process) {
			Process owner = process;
			bool result = owner.IsProcessExecutedBySignal;
			while (!result && owner.Owner != null) {
				owner = owner.Owner;
				result = owner.IsProcessExecutedBySignal;
			}
			return result;
		}

		public static void SetEntityColumnValue(Entity entity, string columnName, object columnValue) {
			var column = entity.Schema.Columns.FindByName(columnName);
			if (column != null && !DataTypeUtilities.ValueIsNullOrEmpty(columnValue)) {
				entity.SetColumnValue(column, columnValue);
			}
		}

		[Obsolete("7.15.1 | Method is not in use and will be removed in upcoming releases")]
		public static void InteractWithUser(ProcessUserTask userTask, ProcessExecutingContext context,
				UserConnection userConnection, bool isRunning, bool showExecutionPage) {
			userTask.InteractWithUser(context, isRunning, showExecutionPage);
		}

		[Obsolete("7.15.1 | Method is not in use and will be removed in upcoming releases")]
		public static void OpenUserTaskExecutionPage(ProcessUserTask currentUserTask, UserConnection userConnection) {
			var method = typeof(BaseProcessUserTaskUtilities).GetMethod("OpenExecutionPage", 
				BindingFlags.Static | BindingFlags.NonPublic);
			method.Invoke(null, new object[] { currentUserTask, userConnection });
		}

		public static Guid AddProcessEntryPoint(UserConnection userConnection, Guid entitySchemaUId, Guid entityId,
				Guid processElementUId) {
			if (entitySchemaUId == Guid.Empty || entityId == Guid.Empty) {
				return Guid.Empty;
			}
			Guid entryPointId = Guid.NewGuid();
			DataValueType guidDataValueType = userConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var idParameter = new QueryParameter("Id", entryPointId, guidDataValueType);
			var entitySchemaUIdParameter = new QueryParameter("EntitySchemaUId", entitySchemaUId, guidDataValueType);
			var entityIdParameter = new QueryParameter("EntityId", entityId, guidDataValueType);
			var processElementIdParameter = new QueryParameter("processElementId", processElementUId,
				guidDataValueType);
			var currentDateTimeParameter = new QueryParameter("CurrentDateTime", userConnection.CurrentUser
				.GetCurrentDateTime(), "DateTime");
			var currentUserContactIdParameter = new QueryParameter(userConnection.CurrentUser.ContactId);
			var isActiveParameter = new QueryParameter("isActive", true, "Boolean");
			var entryPointInsert = new Insert(userConnection)
				.Into("EntryPoint")
					.Set("Id", idParameter)
					.Set("CreatedOn", currentDateTimeParameter)
					.Set("CreatedById", currentUserContactIdParameter)
					.Set("ModifiedOn", currentDateTimeParameter)
					.Set("ModifiedById", currentUserContactIdParameter)
					.Set("EntitySchemaUId", entitySchemaUIdParameter)
					.Set("EntityId", entityIdParameter)
					.Set("SysProcessElementDataId", processElementIdParameter)
					.Set("IsActive", isActiveParameter);
			entryPointInsert.Execute();
			string entitySchemaName = userConnection.EntitySchemaManager.GetItemByUId(entitySchemaUId).Name;
			QueryColumnExpression columnExpression = Column.SourceColumn("ProcessListeners") |
				Column.Parameter(((int)EntityChangeType.Updated).ToString(CultureInfo.InvariantCulture));
			var update =
				new Update(userConnection, entitySchemaName)
					.Set("ProcessListeners", columnExpression)
				.Where("Id")
				.IsEqual(entityIdParameter);
			update.Execute();
			return entryPointId;
		}

		public static void DeactivateProcessEntryPoint(UserConnection userConnection, Guid entryPointId,
				Guid entitySchemaUId, Guid entityId) {
			if (entitySchemaUId == Guid.Empty) {
				return;
			}
			DataValueType guidDataValueType = userConnection.DataValueTypeManager.GetInstanceByName("Guid");
			var currentDateTimeParameter = new QueryParameter("CurrentDateTime",
				userConnection.CurrentUser.GetCurrentDateTime(), "DateTime");
			var currentUserContactIdParameter = new QueryParameter("ContactId", userConnection.CurrentUser.ContactId,
				guidDataValueType);
			var entryPointUpdate = new Update(userConnection, "EntryPoint")
					.Set("ModifiedOn", currentDateTimeParameter)
					.Set("ModifiedById", currentUserContactIdParameter)
					.Set("IsActive", new QueryParameter("isActive", false, "Boolean"))
				.Where("Id").IsEqual(new QueryParameter("Id", entryPointId, guidDataValueType));
			entryPointUpdate.Execute();
			string entitySchemaName = userConnection.EntitySchemaManager.GetItemByUId(entitySchemaUId).Name;
			var entityIdParameter = new QueryParameter("EntityId", entityId, guidDataValueType);
			var processListenersSelect =
				new Select(userConnection)
					.Column("Id")
				.From("SysEntityCommonPrcEl")
				.Where("RecordId").IsEqual(entityIdParameter)
				.And("RecordChangeType").IsEqual(Column.Parameter(EntityChangeType.Updated));
			var select =
				new Select(userConnection)
					.Column("Id")
				.From("EntryPoint")
				.Where("EntityId").IsEqual(entityIdParameter)
				.And("IsActive").IsEqual(Column.Parameter(true))
				.Union(processListenersSelect);
			var columnExpression = new QueryColumnExpression(ArithmeticOperation.Subtraction,
				Column.SourceColumn("ProcessListeners"), Column.Parameter((int)EntityChangeType.Updated));
			var update =
				new Update(userConnection, entitySchemaName)
					.Set("ProcessListeners", columnExpression)
				.Where("Id").IsEqual(entityIdParameter)
				.And().Not().Exists(select);
			update.Execute();
		}

		public static Guid GetParentProcessId(Process process) {
			Process parentProcess = process;
			Guid processId = parentProcess.UId;
			while (parentProcess != null) {
				processId = parentProcess.UId;
				parentProcess = parentProcess.Owner;
			}
			return processId;
		}

		public static bool GetIsActivityCreated(UserConnection userConnection, Guid processElementId) {
			var activitySelect =
				(Select)new Select(userConnection)
					.Column("Id")
				.From("Activity")
				.Where("ProcessElementId")
				.IsEqual(new QueryParameter("ProcessElementId", processElementId, "Guid"));
			return activitySelect.ExecuteScalar<Guid>() != Guid.Empty;
		}

		public static Guid GetActivityStatus(UserConnection userConnection, Guid activityId) {
			var select =
				(Select)new Select(userConnection)
					.Column("StatusId")
				.From("Activity")
				.Where("Id").IsEqual(Column.Parameter(activityId));
			return select.ExecuteScalar<Guid>();
		}

		public static void SetActivityStatus(UserConnection userConnection, Guid activityId, Guid activityStatusId) {
			var update =
				new Update(userConnection, "Activity")
					.Set("StatusId", Column.Parameter(activityStatusId))
				.Where("Id").IsEqual(Column.Parameter(activityId));
			update.Execute();
		}

		/// <summary>
		/// Converts a set of filters to process format.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="entitySchema">Entity schema.</param>
		/// <param name="processActivity">Process activity.</param>
		/// <param name="dataSourceFilters">Serialized filters.</param>
		/// <returns>Set of filters in the process format.</returns>
		public static string ConvertToProcessDataSourceFilters(UserConnection userConnection, EntitySchema entitySchema,
				ProcessActivity processActivity, string dataSourceFilters) {
			userConnection.CheckArgumentNull("userConnection");
			entitySchema.CheckArgumentNull("entitySchema");
			processActivity.CheckArgumentNull("processActivity");
			dataSourceFilters.CheckArgumentNullOrEmpty("dataSourceFilters");
			var userConnectionArgument = new ConstructorArgument("userConnection", userConnection);
			var processDataSourceFiltersConverter = ClassFactory
				.Get<IProcessDataSourceFiltersConverter>(userConnectionArgument);
			return processDataSourceFiltersConverter.ConvertToProcessDataSourceFilters(processActivity,
				entitySchema.UId, dataSourceFilters);
		}

		public static DataSourceFilterCollection ConvertToProcessDataSourceFilterCollection(
				UserConnection userConnection, EntitySchema entitySchema, ProcessActivity processActivity,
				string dataSourceFilters) {
			if (string.IsNullOrEmpty(dataSourceFilters)) {
				return null;
			}
			var converter = new ProcessDataSourceFiltersJsonConverter(userConnection, entitySchema, processActivity) {
				PreventRegisteringClientScript = true
			};
			var converters = new List<Newtonsoft.Json.JsonConverter> { converter };
			return (DataSourceFilterCollection)Json.Deserialize(dataSourceFilters, typeof(DataSourceFilterCollection),
				converters);
		}

		/// <summary>
		/// Initializes the specified EntitySchemaQuery filters.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="processActivity">Process activity.</param>
		/// <param name="entitySchema">Entity schema.</param>
		/// <param name="esq">Instance of the EntitySchemaQuery class.</param>
		/// <param name="dataSourceFilters">Serialized filters.</param>
		public static void SpecifyESQFilters(UserConnection userConnection, ProcessActivity processActivity,
				EntitySchema entitySchema, EntitySchemaQuery esq, string dataSourceFilters) {
			userConnection.CheckArgumentNull("userConnection");
			processActivity.CheckArgumentNull("processActivity");
			entitySchema.CheckArgumentNull("entitySchema");
			esq.CheckArgumentNull("esq");
			if (string.IsNullOrEmpty(dataSourceFilters)) {
				return;
			}
			IEntitySchemaQueryFilterItem esqFilter;
			var userConnectionArgument = new ConstructorArgument("userConnection", userConnection);
			var processDataContractFilterConverter = ClassFactory
				.Get<IProcessDataContractFilterConverter>(userConnectionArgument);
			if (processDataContractFilterConverter.GetIsDataContractFilter(dataSourceFilters)) {
				ServiceConfig.Initialize();
				esqFilter = processDataContractFilterConverter.ConvertToEntitySchemaQueryFilterItem(esq,
					processActivity.Owner, dataSourceFilters);
			} else {
				DataSourceFilterCollection filterCollection = ConvertToProcessDataSourceFilterCollection(userConnection,
					entitySchema, processActivity, dataSourceFilters);
				esqFilter = filterCollection.ToEntitySchemaQueryFilterCollection(esq);
			}
			esq.Filters.Add(esqFilter);
		}

		/// <summary>
		/// Returns allowed activity results.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="activityId">ID of the activity.</param>
		/// <returns>Allowed values of the activity result.</returns>
		public static string GetAllowedActivityResults(UserConnection userConnection, Guid activityId) {
			var select = (Select)new Select(userConnection)
					.Column("AllowedResult")
				.From("Activity")
				.Where("Id").IsEqual(Column.Parameter(activityId));
			var allowedResult = select.ExecuteScalar<string>();
			if (string.IsNullOrEmpty(allowedResult)) {
				return "[]";
			}
			EntitySchemaManager entitySchemaManager = userConnection.EntitySchemaManager;
			EntitySchema entitySchema = entitySchemaManager.GetInstanceByName("ActivityResult");
			var esq = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = false
			};
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			string columnName = entitySchema.GetPrimaryDisplayColumnName();
			esq.AddColumn(columnName);
			esq.AddColumn("Category");
			EntitySchemaQueryFilterCollection filters = esq.Filters;
			var allowedResultIds = ServiceStackTextHelper.Deserialize<string[]>(allowedResult);
			var columnParameters = new object[allowedResultIds.Length];
			for (int i = 0; i < allowedResultIds.Length; i++) {
				var resultId = new Guid(allowedResultIds[i]);
				columnParameters[i] = resultId;
			}
			filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", columnParameters));
			EntityCollection entityCollection = esq.GetEntityCollection(userConnection);
			bool isFirstItem = true;
			var sb = new StringBuilder("[");
			foreach (Entity entity in entityCollection) {
				if (!isFirstItem) {
					sb.Append(",");
				} else {
					isFirstItem = false;
				}
				sb.AppendFormat("{{\"resultId\":\"{0}\",\"caption\":\"{1}\",\"categoryId\":\"{2}\"}}",
					entity.GetTypedColumnValue<Guid>("Id"), entity.GetTypedColumnValue<string>(columnName),
					entity.GetTypedColumnValue<Guid>("CategoryId"));
			}
			sb.Append("]");
			return sb.ToString();
		}

		/// <summary>
		/// Returns serialized filter that matches final status column values.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="resultColumnUId">The status column identifier.</param>
		/// <param name="activity">The activity.</param>
		public static string GetConditionData(UserConnection userConnection, Guid resultColumnUId, Entity activity) {
			var userConnectionArgument = new ConstructorArgument("userConnection", userConnection);
			var filterConverter = ClassFactory.Get<IProcessDataContractFilterConverter>(userConnectionArgument);
			return filterConverter.GetActivityFinalStatusFilter(resultColumnUId, activity);
		}

		public static bool GetIsReexecution(ProcessUserTask currentUserTask) {
			Process process = currentUserTask.Owner;
			Collection<ProcessFlowElement> flowElements =
				process.FlowElements[currentUserTask.SchemaElementUId];
			return flowElements.Count > 1;
		}

		public static void SetupSchemaParameterValues(UserConnection userConnection, ProcessActivity processElement) {
			return;
		}

		/// <summary>
		/// Creates activity connection dynamic column parameter if it doesn't exist.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="target">Target user task schema.</param>
		public static void SynchronizeActivityConnectionParameters(UserConnection userConnection,
				ProcessUserTaskSchema target) {
			EntitySchemaManager manager = userConnection.EntitySchemaManager;
			EntitySchema activity = manager.GetInstanceByName("Activity");
			activity.LoadLocalizableValues();
			EntitySchemaQuery esq = CreateActivityConnectionEsq(manager, activity.UId);
			EntityCollection activityConnections = esq.GetEntityCollection(userConnection);
			foreach (Entity connection in activityConnections) {
				Guid columnUId = connection.GetTypedColumnValue<Guid>("ColumnUId");
				EntitySchemaColumn column = activity.Columns.FindByUId(columnUId);
				if (column == null) {
					_log.InfoFormat("Activity connection column with identifier \"{0}\" not found", columnUId);
				} else {
					CreateDynamicProcessSchemaParameterIfNotExist(target, column);
				}
			}
		}

		/// <summary>
		/// Returns title of the activity.
		/// </summary>
		/// <param name="processElement">Process element.</param>
		/// <param name="recommendation">Text of the recommendation.</param>
		/// <param name="currentActivityId">Identifier of the current activity.</param>
		/// <returns></returns>
		public static string GetActivityTitle(ProcessActivity processElement, LocalizableString recommendation,
				Guid currentActivityId) {
			if (processElement.IsExecuted) {
				var select = 
					(Select)new Select(processElement.UserConnection)
						.Column("Title")
						.From("Activity").WithHints(Hints.NoLock)
						.Where("Id").IsEqual(Column.Parameter(currentActivityId));
				return select.ExecuteScalar<string>();
			}
			LocalizableString titleValue = null;
			if (!LocalizableString.IsNullOrEmpty(recommendation)) {
				titleValue = recommendation;
			}
			return (titleValue ?? GetSchemaElementCaption(processElement))
				.Value?.Truncate(500);
		}

		/// <summary>
		/// Assigns data of the process element notification event.
		/// </summary>
		/// <param name="notification">Data of the process element notification event.</param>
		/// <param name="title">Title of the notification event.</param>
		/// <param name="offset">Start in.</param>
		/// <param name="period">Start in period.</param>
		public static void AssignNotificationData(ProcessElementNotification notification, string title, int offset,
				int period) {
			if (title.IsNotNullOrEmpty()) {
				notification.Title = title;
			}
			DateTime startDate = notification.StartDate;
			notification.StartDate = NewDate(startDate, offset, (ProcessDurationPeriod)period);
		}

		#endregion

	}

	#endregion

}

