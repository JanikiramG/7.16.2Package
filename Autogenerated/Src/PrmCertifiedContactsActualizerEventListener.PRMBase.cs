namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using Quartz;
	using Quartz.Impl.Matchers;
	using Quartz.Impl.Triggers;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;
	using Terrasoft.Common;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Core.Configuration;

	/// <summary>
	/// Actualize partner contact certificates.
	/// </summary>
	public class PrmCertifiedContactsActualizerEventListener : AppEventListenerBase
	{

		#region Fields: Private

		private readonly string _jobGroup = "PartnershipCertifiedContactsActualizerJobGroup";
		private readonly string _triggerName = "PartnershipCertifiedContactsActualizerJobTrigger";
		private readonly string _cronExpression = "0 0 5 * * ?";
		private readonly string _className = "PartnershipCertifiedContactsActualizerJob";


		private AppEventContext _appEventContext;
		private AppConnection _appConnection;
		private UserConnection _userConnection;

		#endregion

		#region Properties: Public

		public UserConnection UserConnection {
			get => _userConnection ?? (_userConnection = AppConnection.SystemUserConnection);
			set {
				value.CheckArgumentNull("UserConnection");
				_userConnection = value;
			}
		}

		public AppConnection AppConnection {
			get {
				if (_appConnection == null) {
					AppConnection = _appEventContext.Application["AppConnection"] as AppConnection;
				}
				return _appConnection;
			}
			set {
				value.CheckArgumentNull("AppConnection");
				_appConnection = value;
			}
		}

		#endregion

		#region Methods: Private

		private void ScheduleCronTriggerJob() {
			if (AppScheduler.DoesJobExist(_className, _jobGroup)) {
				AppScheduler.RemoveJob(_className, _jobGroup);
			}
			IJobDetail job = AppScheduler.CreateClassJob<PartnershipCertifiedContactsActualizerJob>(_className, _jobGroup, UserConnection);
			ITrigger trigger = new CronTriggerImpl(_triggerName, _jobGroup, _cronExpression);
			AppScheduler.Instance.ScheduleJob(job, trigger);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates and schedules a job for certificated partner contact actualization.
		/// </summary>
		/// <param name="context">Execution context.</param>
		public override void OnAppStart(AppEventContext context) {
			context.CheckArgumentNull("context");
			_appEventContext = context;
			ScheduleCronTriggerJob();
		}

		#endregion
	}
}

