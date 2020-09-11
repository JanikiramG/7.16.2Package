namespace Terrasoft.Mail
{
	using MailBee.ImapMail;
	using MailBee.Mime;

	#region Class: FlagBasedSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementaiton, delivered from <see cref="SyncStrategy"/>.
	/// </summary>
	/// <remarks>
	/// FlagBasedSyncStrategy used to select all not-draft, not-deleted messages,
	/// not marked by <see cref="FlagBasedSyncStrategy.SyncFlag"/> keyword.
	/// </remarks>
	public partial class FlagBasedSyncStrategy : SyncStrategy
	{

		#region Methods: Internal

		/// <summary>
		/// Checks if imap server implementation supports custom message flags.
		/// </summary>
		/// <param name="client"><see cref=" MailBee.ImapMail.Imap"/> instance.</param>
		internal bool ValidateCustomFlagsSuport(Imap client) {
			int count = client.PermanentFlags.AllFlags.Length;
			for (int i = 0; i < count; i++) {
				if (client.PermanentFlags.AllFlags[i] == "\\*" || client.PermanentFlags.AllFlags[i] == _syncFlag) {
					return true;
				}
			}
			return false;
		}

		#endregion
		
		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.SetMessageSynchronized"/></summary>
		public override void SetMessageSynchronized(Imap client, MailMessage header) {
			client.SetMessageFlags(header.UidOnServer.ToString(), true, _syncFlag, MessageFlagAction.Add, true);
		}


		#endregion
	}

	#endregion
}
