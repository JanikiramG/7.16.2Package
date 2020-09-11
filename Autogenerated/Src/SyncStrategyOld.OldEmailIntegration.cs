namespace Terrasoft.Mail
{
	using MailBee.ImapMail;
	using MailBee.Mime;

	#region Class: SyncStrategy

	/// <summary><see cref="ISyncStrategy"/> implementaiton.</summary>
	public abstract partial class SyncStrategy : ISyncStrategy
	{

		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap)"/></summary>
		public virtual MessageIndexCollection GetUnsyncedMsgIndexes(Imap client) {
			return client.Search(true, GetUnsyncMsgSearchQuery(), null);
		}

		/// <summary><see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap, string)"/></summary>
		public virtual MessageIndexCollection GetUnsyncedMsgIndexes(Imap client, string folderPath) {
			return GetUnsyncedMsgIndexes(client);
		}

		/// <summary><see cref="ISyncStrategy.SetMessageSynchronized"/></summary>
		public virtual void SetMessageSynchronized(Imap client, MailMessage header) {
		}

		#endregion

	}

	#endregion

}
