namespace Terrasoft.Mail
{
	using System;
	using MailBee.ImapMail;
	using MailBee.Mime;

	#region Interface: ISyncStrategy

	/// <summary>
	/// Provides methods for get query to searching not synced messages.
	/// </summary>
	public partial interface ISyncStrategy
	{
		#region Methods: Public

		/// <summary>
		/// Returns <see cref="MailBee.ImapMail.MessageIndexCollection"/> for messages, resolved as not synced 
		/// in current folder.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <returns>
		/// Not synced messages <see cref="MailBee.ImapMail.MessageIndexCollection"/>.
		/// </returns>
		MessageIndexCollection GetUnsyncedMsgIndexes(Imap client);

		/// <summary>
		/// Returns <see cref="MailBee.ImapMail.MessageIndexCollection"/> for messages, resolved as not synced
		/// in <paramref name="folderPath"/> folder.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <param name="folderPath">Imap folder full path.</param>
		/// <returns>
		/// Not synced messages <see cref="MailBee.ImapMail.MessageIndexCollection"/>.
		/// </returns>
		MessageIndexCollection GetUnsyncedMsgIndexes(Imap client, string folderPath);

		/// <summary>
		/// Marks message as synchronized.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <param name="header"><see cref="MailBee.ImapMail.MailMessage"/> instance.</param>
		void SetMessageSynchronized(Imap client, MailMessage header);
		
		#endregion
	}

	#endregion

}
