using System.Linq;

namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core.Factories;
	using Terrasoft.Common;
	using Terrasoft.Core;

	#region Class: RemindingJob

	public class RemindingJob : IJobExecutor
	{
		#region Fields: Private

		private UserConnection _userConnection;

		#endregion

		#region Properties: Public

		private INotificationSender _notificationSender;
		public INotificationSender NotificationSender {
			get {
				return _notificationSender ?? (_notificationSender = ClassFactory
					       .Get<INotificationSender>(new ConstructorArgument("userConnection", _userConnection)));
			}
			set {
				if (_notificationSender != null) {
					throw new InvalidOperationException();
				}
				_notificationSender = value ?? throw new ArgumentNullException("NotificationSender");
			}
		}

		private IRemindingRepository _remindingRepository;
		public IRemindingRepository RemindingRepository {
			get {
				return _remindingRepository ?? (_remindingRepository = ClassFactory
					       .Get<IRemindingRepository>(new ConstructorArgument("userConnection", _userConnection)));
			}
			set {
				if (_remindingRepository != null) {
					throw new InvalidOperationException();
				}
				_remindingRepository = value ?? throw new ArgumentNullException("RemindingRepository");
			}
		}

		#endregion

		#region Methods: Protected

		private void InternalExecute() {
			IEnumerable<INotificationInfo> notificationInfos = RemindingRepository.GetRemindings();
			if (notificationInfos != null && notificationInfos.IsNotEmpty()) {
				NotificationSender.Send(notificationInfos);
				var notificationsId = notificationInfos.Select(a => a.MessageId);
				RemindingRepository.SetRemindingsIsSent(notificationsId);
			}
		}

		#endregion

		#region Methods: Public

		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			_userConnection = userConnection;
			if (_userConnection.GetIsFeatureEnabled("NotificationV2")) {
				InternalExecute();	
			}
		}

		#endregion
	}

	#endregion
}


