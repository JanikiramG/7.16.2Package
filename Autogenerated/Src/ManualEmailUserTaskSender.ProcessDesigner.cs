namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail.Sender;

	#region Class: ManualEmailUserTaskSender

	public class ManualEmailUserTaskSender : IEmailUserTaskSender
	{

		#region Properties: Public

		public UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Methods: Private

		private static void SetParameterByActivity(EmailTemplateUserTask userTask, Activity activity,
				string parameterName) {
			var column = activity.Schema.Columns.FindByName(parameterName);
			if (column != null) {
				object columnValue = activity.GetColumnValue(column);
				if (columnValue != null) {
					userTask.SetPropertyValue(parameterName, columnValue);
				}
			}
		}

		private static void SetActivityRemindToOwnerDate(Activity activity, EmailTemplateUserTask userTask) {
			if (userTask.OwnerId.IsNotEmpty()) {
				activity.OwnerId = userTask.OwnerId;
				if (userTask.RemindBefore != 0) {
					activity.RemindToOwner = true;
					var processDurationPeriod = (ProcessDurationPeriod)userTask.RemindBeforePeriod;
					DateTime remindToOwnerDate = ProcessUserTaskUtilities.NewDate(activity.StartDate, -1 * userTask.RemindBefore,
						processDurationPeriod);
					activity.RemindToOwnerDate = remindToOwnerDate;
				}
			}
		}

		private void InternalExecute(IEmailUserTaskMessageProvider messageProvider) {
			EmailTemplateUserTask userTask = messageProvider.EmailUserTask;
			EmailMessage message = messageProvider.GetEmailMessage();
			Activity activity = CreateActivity(message, userTask);
			userTask.ExecuteAfterActivitySaveScript(activity);
		}

		private Activity CreateActivity(EmailMessage message, EmailTemplateUserTask userTask) {
			var activity = new Activity(UserConnection);
			activity.SetDefColumnValues();
			activity.Id = Guid.NewGuid();
			activity.TypeId = ActivityConsts.EmailTypeUId;
			activity.MessageTypeId = ActivityConsts.OutgoingEmailTypeId;
			userTask.Subject = message.Subject;
			activity.Title = message.Subject;
			activity.StartDate = ProcessUserTaskUtilities.NewDate(
				UserConnection.CurrentUser.GetCurrentDateTime(), userTask.StartIn,
				(ProcessDurationPeriod)userTask.StartInPeriod);
			activity.DueDate = ProcessUserTaskUtilities.NewDate(
				activity.StartDate, userTask.Duration, (ProcessDurationPeriod)userTask.DurationPeriod);
			if (userTask.ActivityCategory.IsEmpty()) {
				userTask.ActivityCategory = ActivityConsts.EmailActivityCategoryId;
			}
			activity.ActivityCategoryId = userTask.ActivityCategory;
			activity.ShowInScheduler = userTask.ShowInScheduler;
			activity.Recepient = message.To.ConcatIfNotEmpty(";");
			activity.CopyRecepient = message.Cc.ConcatIfNotEmpty(";");
			activity.BlindCopyRecepient = message.Bcc.ConcatIfNotEmpty(";");
			activity.Body = message.Body;
			activity.IsHtmlBody = true;
			activity.Sender = message.From;
			SetActivityRemindToOwnerDate(activity, userTask);
			FillActivityConnections(activity, userTask);
			activity.ProcessElementId = userTask.UId;
			activity.AllowedResult = userTask.GetResultAllowedValues();
			LinkActivityToProcess(activity, userTask);
			userTask.IsActivityCompleted = false;
			userTask.ActivityId = activity.Id;
			return activity;
		}

		private void FillActivityConnections(Activity activity, EmailTemplateUserTask userTask) {
			IEnumerable<string> activityConnections = GetActivityConnections();
			foreach (string activityConnection in activityConnections) {
				object propertyValue = userTask.GetPropertyValue(activityConnection);
				ProcessUserTaskUtilities.SetEntityColumnValue(activity, activityConnection, propertyValue);
			}
			ProcessUserTaskUtilities.SetEntityColumnValues(userTask, activity);
		}

		private string GetActivityTitle(EmailTemplateUserTask userTask) {
			if (userTask.IsExecuted) {
				Select select =
					new Select(UserConnection).
						Column("Title").
						From("Activity").
						Where("Id").IsEqual(Column.Parameter(userTask.ActivityId)) as Select;
				return select.ExecuteScalar<string>();
			}
			return userTask.Subject;
		}

		private IEnumerable<string> GetActivityConnections() {
			return new[] {
				"Account",
				"Contact",
				"Lead",
				"Opportunity",
				"Invoice",
				"Order",
				"Project",
				"Contract",
				"Document",
				"Requests",
				"Listing",
				"Property",
				"Change",
				"Problem",
				"Release",
				"Case",
			};
		}

		#endregion

		#region Methods: Protected

		protected virtual void LinkActivityToProcess(Activity activity, EmailTemplateUserTask userTask) {
			Guid resultColumntUId = activity.Schema.Columns.GetByName("Status").UId;
			string conditionData =
				ProcessUserTaskUtilities.GetConditionData(UserConnection, resultColumntUId, activity);
			UserConnection.IProcessEngine.AddProcessListener(activity, userTask.UId, conditionData);
			UserConnection.IProcessEngine.LinkProcessToEntity(userTask.Owner, activity.Schema.UId, activity.Id);
		}

		#endregion

		#region Methods: Public

		public bool Execute(IEmailUserTaskMessageProvider messageProvider, ProcessExecutingContext context) {
			var userTask = messageProvider.EmailUserTask;
			Guid activityId = userTask.ActivityId;
			bool showExecutionPage = userTask.ShowExecutionPage;
			bool isActivityCompleted = userTask.IsActivityCompleted;
			bool isRunning = activityId.IsNotEmpty() && !isActivityCompleted;
			if (userTask.Status == ProcessStatus.Error) {
				bool isActivityCreated = ProcessUserTaskUtilities.GetIsActivityCreated(UserConnection, userTask.UId);
				if (activityId.IsEmpty() && !isActivityCreated) {
					InternalExecute(messageProvider);
				}
			}
			if (!isRunning) {
				InternalExecute(messageProvider);
			}
			userTask.InteractWithUser(context, isRunning, showExecutionPage);
			return false;
		}

		public bool CompleteExecuting(EmailTemplateUserTask userTask, Func<object[], bool> callBase,
				params object[] parameters) {
			var activity = parameters[0] as Activity;
			if (activity == null) {
				return false;
			}
			userTask.OwnerId = activity.OwnerId;
			IEnumerable<string> activityConnections = GetActivityConnections();
			foreach (string activityConnection in activityConnections) {
				SetParameterByActivity(userTask, activity, activityConnection);
			}
			ProcessUserTaskUtilities.SetEntityColumnValues(userTask, activity);
			userTask.ActivityResult = activity.ResultId;
			userTask.IsActivityCompleted = true;
			bool result = callBase(parameters);
			activity.SetColumnValue("ProcessElementId", null);
			activity.UseAdminRights = false;
			activity.Save();
			return result;
		}

		public void CancelExecuting(EmailTemplateUserTask userTask, Action<object[]> callBase,
				params object[] parameters) {
			UserConnection.IProcessEngine.RemoveActivityProcessListener(userTask.ActivityId, userTask.UId,
				ActivityConsts.CanceledStatusUId);
			callBase(parameters);
		}

		public string GetExecutionData(EmailTemplateUserTask userTask) {
			string informationOnStep = LocalizableString.IsNullOrEmpty(userTask.InformationOnStep)
				? userTask.GetParameterValue("InformationOnStep")?.ToString() ?? string.Empty
				: userTask.InformationOnStep.Value;
			string allowedActivityResults = ProcessUserTaskUtilities.GetAllowedActivityResults(UserConnection,
				userTask.ActivityId);
			Guid parentProcessId = ProcessUserTaskUtilities.GetParentProcessId(userTask.Owner);
			return
				ServiceStackTextHelper.Serialize(
					new {
						procElUId = userTask.UId,
						name = userTask.Name,
						processId = parentProcessId,
						isProcessExecutedBySignal = userTask.Owner.IsProcessExecutedBySignal,
						processName = userTask.Owner.Name,
						entitySchemaName = "Activity",
						recommendation = GetActivityTitle(userTask),
						informationOnStep,
						pageTypeId = ActivityConsts.EmailTypeUId,
						activityRecordId = userTask.ActivityId,
						executionContext = userTask.ExecutionContext,
						nextProcElUId = "nextProcElUIdValue",
						allowedResults = allowedActivityResults
					});
		}

		/// <summary>
		/// Returns instance that implements the <see cref="IProcessNotifier"/> interface.
		/// </summary>
		/// <param name="baseProcessNotifier">Delegate to get base process notifier.</param>
		/// <returns></returns>
		public IProcessNotifier GetProcessNotifier(Func<IProcessNotifier> baseProcessNotifier) {
			return baseProcessNotifier();
		}

		#endregion

	}

	#endregion

}
