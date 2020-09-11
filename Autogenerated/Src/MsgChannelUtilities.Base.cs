namespace Terrasoft.Configuration
{

	using System;
	using Core;
	using Messaging.Common;
	using global::Common.Logging;

	#region Class: MsgChannelUtilities

	public static class MsgChannelUtilities
	{

		#region Constants: Public

		public const string ProcessEngineSenderName = "ProcessEngine";

		[Obsolete("7.15.1 | Constant is not in use and will be removed in upcoming releases")]
		public const string ProcessEngineBackHistoryStateSenderName = "ProcessEngineBackHistoryState";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("WebSocket");

		#endregion

		#region Methods: Private

		private static bool CheckCanPostMessage(string userName, string senderName) {
			if (!MsgChannelManager.IsRunning) {
				_log.WarnFormat("Can't post message to {0} from {1} while MsgChannelManager is not running",
					userName ?? "All", senderName);
				return false;
			}
			return true;
		}

		private static void PostMessageInternal(IMsgChannel channel, string sender, string msg) {
			IMsg simpleMessage = new SimpleMessage() {
				Id = new Guid(),
				Body = msg
			};
			simpleMessage.Header.Sender = sender;
			_log.Debug(string.Format("Channel {0} post for {1} msg: {2}", channel.Name, sender, msg));
			channel.PostMessage(simpleMessage);
		}

		#endregion

		#region Methods: Public

		public static void PostMessage(UserConnection userConnection, string senderName, string messageText) {
			if (!CheckCanPostMessage(userConnection.CurrentUser.Name, senderName)) {
				return;
			}
			MsgChannelManager channelManager = MsgChannelManager.Instance;
			IMsgChannel userChannel = channelManager.FindItemByUId(userConnection.CurrentUser.Id);
			if (userChannel != null) {
				PostMessageInternal(userChannel, senderName, messageText);
			} else {
				_log.Info(string.Format("Channel not found for user {0} from {1}",
					userConnection.CurrentUser.Name, senderName));
			}
		}

		public static void PostMessageToAll(string senderName, string messageText) {
			if (!CheckCanPostMessage(null, senderName)) {
				return;
			}
			MsgChannelManager channelManager = MsgChannelManager.Instance;
			foreach (IMsgChannel userChannel in channelManager.Channels.Values) {
				PostMessageInternal(userChannel, senderName, messageText);
			}
		}

		#endregion
	}

	#endregion
}

