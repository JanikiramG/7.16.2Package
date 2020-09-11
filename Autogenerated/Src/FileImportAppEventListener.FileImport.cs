namespace Terrasoft.Configuration.FileImport 
{
	using System.Reflection;
	using Quartz;
	using Quartz.Impl.Triggers;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	#region  Class: FileImportAppEventListener

	/// <summary>
	/// An application event listener that restart not completed import from excel.
	/// </summary>
	/// <seealso cref="Terrasoft.Web.Common.AppEventListenerBase" />
	public class FileImportAppEventListener : AppEventListenerBase 
	{

		#region Constants: Private

		private const string FileImportTriggerName = "RestarFileImportTrigger";
		private const string JobGroupName = "RestartFileImport";
		private const string InMemory = "InMemory";

		#endregion

		#region Fields: Private

		private readonly IAppSchedulerWraper _schedulerWraper = ClassFactory.Get<IAppSchedulerWraper>();

		#endregion

		#region Methods: Private

		private UserConnection GetUserConnection(AppEventContext context) {
			var appConnection = (AppConnection)context.Application["AppConnection"];
			return appConnection.SystemUserConnection;
		}

		private void RestartUncompletedImport(UserConnection userConnection) {
			string className = JobGroupName;
			if (_schedulerWraper.DoesJobExist(className, JobGroupName)) {
				_schedulerWraper.RemoveJob(className, JobGroupName);
			}
			IJobDetail job = _schedulerWraper.CreateClassJob<FileImportBackgroundProcessor>(className, JobGroupName,
				userConnection, isSystemUser: true);
			ITrigger trigger = new SimpleTriggerImpl(FileImportTriggerName, JobGroupName);
			_schedulerWraper.Instance.ScheduleJob(job, trigger);
		}

		private bool GetIsFailoverProcessCompletionEnabled() {
			var useMessageBusForStartProcesses = GetPrivateGlobalAppSettingsPropertyValue<bool>(
				"FeatureUseMessageBusForStartProcesses");
			var mode = GetPrivateGlobalAppSettingsPropertyValue<string>("MessageBusOperatingMode");
			return GlobalAppSettings.FeatureUseMessageBusForCompleteExecutingProcessElements
				&& useMessageBusForStartProcesses
				&& mode != InMemory;

		}

		private T GetPrivateGlobalAppSettingsPropertyValue<T>(string propertyName) {
			var propertyInfo = typeof(GlobalAppSettings).GetProperty(propertyName, BindingFlags.Static | BindingFlags.NonPublic);
			return (T)propertyInfo.GetValue(null);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Start import who not been ended.
		/// </summary>
		/// <param name="context">Application event context.</param>
		public override void OnAppStart(AppEventContext context) {
			if(GetIsFailoverProcessCompletionEnabled()) {
				return;
			}
			var userConnection = GetUserConnection(context);
			if (userConnection.GetIsFeatureEnabled("UsePersistentFileImport")) {
				RestartUncompletedImport(userConnection);
			}
		}

		#endregion

	}

	#endregion

}

