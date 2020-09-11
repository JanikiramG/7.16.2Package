namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Text;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: UserQuestionUserTask

	public partial class UserQuestionUserTask
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (Status == ProcessStatus.Error) {
				if (CurrentActivityId == Guid.Empty &&
						!ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, UId)) {
					Activity activity = CreateActivity();
					AfterActivitySaveScriptExecute(activity);
				}
			}
			bool isRunning = CurrentActivityId.IsNotEmpty() && !IsActivityCompleted;
			if (!isRunning) {
				Activity activity = CreateActivity();
				AfterActivitySaveScriptExecute(activity);
			}
			InteractWithUser(context, isRunning, ShowExecutionPage);
			return false;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			Guid activityStatusId = ProcessUserTaskUtilities.GetActivityStatus(UserConnection, CurrentActivityId);
			if (activityStatusId != ActivityConsts.CanceledStatusUId) {
				activityStatusId = ActivityConsts.CompletedStatusUId;
			}
			if (UserConnection.IProcessEngine.RemoveActivityProcessListener(CurrentActivityId, UId, activityStatusId)) {
				IsActivityCompleted = true;
				return base.CompleteExecuting(parameters);
			}
			return false;
		}

		public override void CancelExecuting(params object[] parameters) {
			base.CancelExecuting(parameters);
			UserConnection.IProcessEngine.RemoveActivityProcessListener(CurrentActivityId, UId,
				ActivityConsts.CanceledStatusUId);
		}

		public override string GetExecutionData() {
			LocalizableParameterValuesList decisionOptionItems = null;
			if (BranchingDecisions.Value.IsNotNullOrEmpty()) {
				Process process = Owner;
				ProcessSchema processSchema = process.ProcessSchema;
				string resourceManagerName = processSchema.OwnerSchema == null
					? processSchema.GetResourceManagerName()
					: processSchema.OwnerSchema.GetResourceManagerName();
				var element = processSchema.GetBaseElementByUId(SchemaElementUId);
				var resourceItemName = "BaseElements." + element.Name + ".Parameters.BranchingDecisions.Value";
				var localizableString = new LocalizableString(Storage, resourceManagerName, resourceItemName);
				string value = localizableString.Value;
				if (value.IsNotNullOrEmpty()) {
					decisionOptionItems = LocalizableParameterValuesList.DeserializeFrom77FormatData(value, "Caption");
				} else {
					decisionOptionItems = LocalizableParameterValuesList.DeserializeData(BranchingDecisions.Value);
					decisionOptionItems.SetupDefaultLocalizableValues("Caption", NoCaptionLocalizableString.Value);
				}
			}
			string informationOnStep = LocalizableString.IsNullOrEmpty(InformationOnStep)
					? GetParameterValue("InformationOnStep")?.ToString() ?? string.Empty
					: InformationOnStep.Value;
			string executionData = SerializeToString(new {
				procElUId = UId,
				name = Name,
				processId = ProcessUserTaskUtilities.GetParentProcessId(Owner),
				isProcessExecutedBySignal = ProcessUserTaskUtilities.GetIsProcessExecutedBySignal(Owner),
				processName = Owner.Name,
				urlToken = "ProcessCardModuleV2/UserQuestionProcessPageV2",
				recommendation = GetActivityTitle(),
				informationOnStep,
				activityRecordId = CurrentActivityId,
				questionText = Question.ToString(),
				decisionMode = DecisionMode,
				isDecisionRequired = IsDecisionRequired,
				decisionOptions = decisionOptionItems?.To77FormatList(),
				executionContext = ExecutionContext,
				nextProcElUId = "nextProcElUIdValue"
			});
			string userContextData = ProcessLane?.GetUserContextData();
			if (!string.IsNullOrEmpty(userContextData)) {
				var sb = new StringBuilder(executionData);
				sb.Length--;
				sb.Append(",");
				sb.Append(userContextData);
				sb.Append("}");
				executionData = sb.ToString();
			}
			return executionData;
		}

		/// <summary>
		/// Returns date and time with the specified offset period.
		/// </summary>
		/// <param name="dateTime">Date time.</param>
		/// <param name="offset">Offset value.</param>
		/// <param name="offsetPeriod">Offset period.</param>
		/// <returns>Modified date and time.</returns>
		public virtual DateTime GetDateTime(DateTime dateTime, int offset, ProcessDurationPeriod offsetPeriod) {
			return ProcessUserTaskUtilities.NewDate(dateTime, offset, offsetPeriod);
		}

		public virtual Activity CreateActivity() {
			var activity = new Activity(UserConnection);
			activity.SetDefColumnValues();
			activity.Id = Guid.NewGuid();
			activity.TypeId = ActivityConsts.TaskTypeUId;
			activity.Title = GetActivityTitle();
			activity.StartDate = GetDateTime(UserConnection.CurrentUser.GetCurrentDateTime(), StartIn,
				(ProcessDurationPeriod)StartInPeriod);
			activity.DueDate = GetDateTime(activity.StartDate, Duration, (ProcessDurationPeriod)DurationPeriod);
			activity.ActivityCategoryId = ActivityCategory;
			activity.ShowInScheduler = ShowInScheduler;
			if (OwnerId != Guid.Empty) {
				activity.OwnerId = OwnerId;
				if (RemindBefore != 0) {
					activity.RemindToOwner = true;
					activity.RemindToOwnerDate = GetDateTime(activity.StartDate, -1 * RemindBefore,
						(ProcessDurationPeriod)RemindBeforePeriod);
				}
			}
			var columnLead = activity.Schema.Columns.FindByName("Lead");
			if (columnLead != null && Lead != Guid.Empty) {
				activity.SetColumnValue(columnLead, Lead);
			}
			if (Account != Guid.Empty) {
				activity.AccountId = Account;
			}
			if (Contact != Guid.Empty) {
				activity.ContactId = Contact;
			}
			var columnOpportunity = activity.Schema.Columns.FindByName("Opportunity");
			if (columnOpportunity != null && Opportunity != Guid.Empty) {
				activity.SetColumnValue(columnOpportunity, Opportunity);
			}
			var columnInvoice = activity.Schema.Columns.FindByName("Invoice");
			if (columnInvoice != null && Invoice != Guid.Empty) {
				activity.SetColumnValue(columnInvoice, Invoice);
			}
			var columnCase = activity.Schema.Columns.FindByName("Case");
			if (columnCase != null && Case != Guid.Empty) {
				activity.SetColumnValue(columnCase, Case);
			}
			var columnOrder = activity.Schema.Columns.FindByName("Order");
			if (columnOrder != null && Order != Guid.Empty) {
				activity.SetColumnValue(columnOrder, Order);
			}
			var columnRequests = activity.Schema.Columns.FindByName("Requests");
			if (columnRequests != null && Requests != Guid.Empty) {
				activity.SetColumnValue(columnRequests, Requests);
			}
			var columnListing = activity.Schema.Columns.FindByName("Listing");
			if (columnListing != null && Listing != Guid.Empty) {
				activity.SetColumnValue(columnListing, Listing);
			}
			var columnProperty = activity.Schema.Columns.FindByName("Property");
			if (columnProperty != null && Property != Guid.Empty) {
				activity.SetColumnValue(columnProperty, Property);
			}
			var columnContract = activity.Schema.Columns.FindByName("Contract");
			if (columnContract != null && Contract != Guid.Empty) {
				activity.SetColumnValue(columnContract, Contract);
			}
			var columnProject = activity.Schema.Columns.FindByName("Project");
			if (columnProject != null && Project != Guid.Empty) {
				activity.SetColumnValue(columnProject, Project);
			}
			var columnDocument = activity.Schema.Columns.FindByName("Document");
			if (columnDocument != null && Document != Guid.Empty) {
				activity.SetColumnValue(columnDocument, Document);
			}
			var columnChange = activity.Schema.Columns.FindByName("Change");
			if (columnChange != null && Change != Guid.Empty) {
				activity.SetColumnValue(columnChange, Change);
			}
			var columnRelease = activity.Schema.Columns.FindByName("Release");
			if (columnRelease != null && Release != Guid.Empty) {
				activity.SetColumnValue(columnRelease, Release);
			}
			var columnProblem = activity.Schema.Columns.FindByName("Problem");
			if (columnProblem != null && Problem != Guid.Empty) {
				activity.SetColumnValue(columnProblem, Problem);
			}
			BaseProcessUserTaskUtilities.SetEntityColumnValues(this, activity);
			activity.ProcessElementId = UId;
			activity.AllowedResult = JsonConvert.SerializeObject(GetResultParameterAllowedValues(), Formatting.None,
				new JsonSerializerSettings {
					TypeNameHandling = TypeNameHandling.All,
					TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
				});
			Guid resultColumnUId = activity.Schema.Columns.GetByName("Status").UId;
			UserConnection.IProcessEngine
				.AddProcessListener(activity, UId, GetConditionData(resultColumnUId, activity));
			IsActivityCompleted = false;
			CurrentActivityId = activity.Id;
			return activity;
		}

		public virtual string GetActivityTitle() {
			return ProcessUserTaskUtilities.GetActivityTitle(this, Recommendation, CurrentActivityId);
		}

		public virtual string GetConditionData(Guid resultColumnUId, Entity activity) {
			return ProcessUserTaskUtilities.GetConditionData(UserConnection, resultColumnUId, activity);
		}

		public virtual Guid GetActivityEntitySchemaUId() {
			return ActivityConsts.ActivityEntitySchemaUId;
		}

		public override ProcessElementNotification GetNotificationData() {
			ProcessElementNotification notification = base.GetNotificationData();
			ProcessUserTaskUtilities.AssignNotificationData(notification, Recommendation, StartIn, StartInPeriod);
			return notification;
		}

		#endregion

	}

	#endregion

}

