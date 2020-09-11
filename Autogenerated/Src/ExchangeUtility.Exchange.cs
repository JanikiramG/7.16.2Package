namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using global::Common.Logging;
	using IntegrationApi.Interfaces;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;
	using Terrasoft.ExchangeApi.Interfaces;
	using Terrasoft.Sync.Exchange;
#if !NETSTANDARD2_0
	using Exchange = Microsoft.Exchange.WebServices.Data;
#endif

	#region Class: ExchangeUtility

	/// <summary>
	/// Contains utility methods to work with Exchange Server Objects.
	/// </summary>
	public static class ExchangeUtility
	{

		#region Constants: Private

		private const string ObjectNotFoundErrorMessage = "The specified object was not found in the store";
		private const string ObjectNotFoundErrorMessageRu = "�� ������� ����� ��������� ������ � ���������";
		private const string AccessDeniedErrorMessage = "Access is denied. Check credentials and try again";
		private const string AccessDeniedErrorMessageRu = "������ ��������. ��������� ������� ������ � ��������� �������.";
		private const string MailBoxNotFoundErrorMessage = "No mailbox with such guid.";
		private const string MailBoxNotFoundErrorMessageRu = "�������� ���� � ����� GUID �����������.";
		private const string OccurrenceNotFoundErrorMessage = "The occurrence couldn't be found";

		#endregion

		#region Constants: Public

		/// <summary>
		/// Mail sync process name.
		/// </summary>
		public const string MailSyncProcessName = "LoadExchangeEmailsProcess";

		/// <summary>
		/// Contacts sync process name.
		/// </summary>
		public const string ContactSyncProcessName = "SyncExchangeContactsProcess";

		/// <summary>
		/// Meeting and tasks sync process name.
		/// </summary>
		public const string ActivitySyncProcessName = "SyncExchangeActivitiesProcess";

		#endregion

		#region Properties: Public

		/// <summary>
		/// Exchange integration logger.
		/// </summary>
		public static ILog Log { get; } = LogManager.GetLogger("Exchange");
#if !NETSTANDARD2_0
		/// <summary>
		/// Definition of property which contains record identifier in local storage.
		/// </summary>
		public static Exchange.ExtendedPropertyDefinition LocalIdProperty = new Exchange.ExtendedPropertyDefinition(
			Exchange.DefaultExtendedPropertySet.PublicStrings, "LocalId", Exchange.MapiPropertyType.String);
#endif

		#endregion

		#region Methods: Private

		private static IExchangeUtility GetExchangeUtility() {
			return ClassFactory.Get<IExchangeUtility>();
		}

#if !NETSTANDARD2_0

		private static Exchange.ExchangeService CreateExchangeService(UserConnection userConnection, string mailboxName ) {
			string serverAddress;
			var exchangeUtility = GetExchangeUtility();
			var credentials = exchangeUtility.GetCredentials(userConnection, mailboxName);
			serverAddress = GetServerAddressByMailbox(userConnection, mailboxName);
			Exchange.ExchangeService exchangeService = new Exchange.ExchangeService(Exchange.ExchangeVersion.Exchange2010_SP1);
			exchangeService.Url = new Uri(string.Format("https://{0}/EWS/Exchange.asmx", serverAddress));
			exchangeService.Credentials = new Exchange.WebCredentials(credentials.UserName, credentials.UserPassword);
			return exchangeService;
		}

#endif

		private static string GetServerAddressByMailbox(UserConnection userConnection, string serverName) {
			var select = new Select(userConnection).Top(1)
				.Column("ExchangeEmailAddress")
				.From("MailServer")
				.Where("Name").IsEqual(Column.Parameter(serverName)) as Select;
			return select.ExecuteScalar<string>();
		}

		/// <summary>
		/// Checks is <paramref name="message"/> is not processed errors message.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <returns><c>True</c> if message not processed. Returns <c>false</c> otherwise.</returns>
		private static bool IsNotProcessedErrorMessages(string message) {
			return !message.Contains(ObjectNotFoundErrorMessage) && !message.Contains(ObjectNotFoundErrorMessageRu)
				&& !message.Contains(OccurrenceNotFoundErrorMessage);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Delete synchronizer from activitySynchronizer.
		/// </summary>
		/// <param name="userConnection">A instance of the current user connection.</param>
		/// <returns></returns>
		public static void DeleteEmptyActivityFromActivitySynchronizer(UserConnection userConnection,
				Guid activityType) {
			var exchangeUtility = GetExchangeUtility();
			exchangeUtility.DeleteEmptyActivityFromActivitySynchronizer(userConnection, activityType);
		}

		/// <summary>
		/// Deletes exchange synchronization process schedule job.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="senderEmailAddress">Sender email adress.</param>
		/// <param name="processName">Synchronization process name.</param>
		public static void RemoveSyncJob(UserConnection userConnection, string senderEmailAddress,
				string processName) {
			var syncJobScheduler = ClassFactory.Get<ISyncJobScheduler>();
			syncJobScheduler.RemoveSyncJob(userConnection, senderEmailAddress, processName);
		}

		/// <summary>
		/// Check if sync job exists.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="senderEmailAddress">Sender email address.</param>
		/// <param name="processName">Synchronization process name.</param>
		/// <returns><c>True</c> if job exists. Otherwise returns <c>false</c>.</returns>
		public static bool DoesSyncJobExists(UserConnection userConnection, string senderEmailAddress,
				string processName) {
			var exchangeUtility = GetExchangeUtility();
			return exchangeUtility.DoesSyncJobExists(userConnection, senderEmailAddress, processName);
		}

		/// <summary>
		/// Deletes jobs for mailbox synchronization.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="senderEmailAddress">Sender email adress.</param>
		public static void RemoveAllSyncJob(UserConnection userConnection, string senderEmailAddress, Guid serverTypeId) {
			var exchangeUtility = GetExchangeUtility();
			exchangeUtility.RemoveAllSyncJob(userConnection, senderEmailAddress, serverTypeId);
		}

		/// <summary>
		/// Uploads attachments body for not loaded <see cref="ActivityFile"/>.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="userEmailAddress">User email address.</param>
		/// <remarks>
		/// <see cref="ExchangeAttachmentHelper"/> used by default.
		/// </remarks>
		public static void UploadAttachmentsData(UserConnection userConnection, string userEmailAddress) {
			var exchangeUtility = GetExchangeUtility();
			exchangeUtility.UploadAttachmentsData(userConnection, userEmailAddress);
		}

		/// <summary>
		/// Starts exchange items synchronization process.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="senderEmailAddress">User email address.</param>
		/// <param name="exchangeSyncProviderFunc">Delegate function that returns
		/// an instance of the Exchange synchronization provider.</param>
		/// <param name="resultMessage">Synchronization result message.</param>
		/// <param name="localChangesCount">Local storage changes count.</param>
		/// <param name="remoteChangesCount">Remote storage changes count.</param>
		/// <param name="syncProcessName">Synchronization process name.</param>
		public static void SyncExchangeItems(UserConnection userConnection, string senderEmailAddress,
				Func<BaseExchangeSyncProvider> exchangeSyncProviderFunc, out string resultMessage,
				out int localChangesCount, out int remoteChangesCount, string syncProcessName = null) {
			var exchangeUtility = GetExchangeUtility();
			exchangeUtility.SyncExchangeItems(userConnection, senderEmailAddress, exchangeSyncProviderFunc,
				 out resultMessage, out localChangesCount, out remoteChangesCount, syncProcessName);
		}

		#if !NETSTANDARD2_0

		/// <summary>
		/// Creates <see cref="Exchange.ExchangeService"/> instance for <paramref name="senderEmailAddress"/> settings.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="senderEmailAddress">Sender email address.</param>
		/// <param name="stopOnFirstError">Stop synchronization triggers on first error flag.</param>
		/// <returns><see cref="Exchange.ExchangeService"/> instance.</returns>
		public static Exchange.ExchangeService CreateExchangeService(UserConnection userConnection,
				string senderEmailAddress, bool stopOnFirstError = false, bool ignoreRights = false) {
			return CreateExchangeService(userConnection, senderEmailAddress);
		}

		/// <summary>
		/// Creates <see cref="Exchange.ExchangeService"/> instance using <paramref name="credentials"/> credentials.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials">Exchane service credentials.</param>
		/// <param name="senderEmailAddress">Sender email address.</param>
		/// <param name="stopOnFirstError">Stop synchronization triggers on first error flag.</param>
		/// <returns><see cref="Exchange.ExchangeService"/> instance.</returns>
		public static Exchange.ExchangeService CreateExchangeService(UserConnection userConnection,
				Mail.Credentials credentials, string senderEmailAddress, bool stopOnFirstError = false) {
			return CreateExchangeService(userConnection, senderEmailAddress);
		}

		public static T SafeBindItem<T>(Exchange.ExchangeService service, Exchange.ItemId id)
				where T : Exchange.Item {
			T value = null;
			try {
				value = Exchange.Item.Bind(service, id) as T;
			} catch (Exchange.ServiceResponseException exception) {
				string message = exception.Message;
				if (message.Contains(AccessDeniedErrorMessage) || message.Contains(MailBoxNotFoundErrorMessage) ||
						 message.Contains(MailBoxNotFoundErrorMessageRu) || message.Contains(AccessDeniedErrorMessageRu)) {
					Log.ErrorFormat("[ExchangeUtility.SafeBindItem]: Error while loading item with Id: {0}", exception, id);
				} else if (IsNotProcessedErrorMessages(message)) {
					throw;
				}
			}
			return value;
		}

		#endif

		/// <summary>
		/// Creates exchange synchronization process schedule job.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="periodInMinutes">Job interval.</param>
		/// <param name="processName">Synchronization process name.</param>
		/// <param name="parameters">Synchronization process parameters.</param>
		/// <remarks>
		/// If <paramref name="periodInMinutes"/> is 0, imediate job will be created.
		/// </remarks>
		public static void CreateSyncJob(UserConnection userConnection, int periodInMinutes,
				string processName, IDictionary<string, object> parameters = null) {
			var syncJobScheduler = ClassFactory.Get<ISyncJobScheduler>();
			var senderEmailAddress = parameters["SenderEmailAddress"].ToString();
			syncJobScheduler.RemoveSyncJob(userConnection, senderEmailAddress, processName);
		}

		#endregion

	}

	#endregion

}
