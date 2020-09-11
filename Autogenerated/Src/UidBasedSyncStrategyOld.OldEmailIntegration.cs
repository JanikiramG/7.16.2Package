namespace Terrasoft.Mail
{
	using System.Collections.Generic;
	using System.Linq;
	using MailBee.ImapMail;
	using Terrasoft.Common;

	#region Class: UidBasedSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementatiton, delivered from <see cref="DateBasedSentSinceSyncStrategy"/>.
	/// </summary>
	/// <remarks>
	/// UidBasedSyncStrategy used to select all new messages,
	/// beginning at a specified unique identifier message. rfc4549 https://tools.ietf.org/html/rfc4549
	/// </remarks>
	public partial class UidBasedSyncStrategy : DateBasedSentSinceSyncStrategy
	{

		#region Methods: Private

		/// <summary>
		/// Loads not synchronized messages indexes form selected folder.
		/// Selected folder must be specified in <paramref name="client"/>, using <see cref="ImapClient.SelectFolderForSyncronization"/> method.
		/// Due to imap protocol realization, search method with "UId N:*" query allways returns last message index in folder.
		/// Message index with <see cref="CurrentMessageUidInFolder"/> UId will be skipped.
		/// If current folder was removed and created again in mailbox, synchronization strategy will use new folder query string.
		/// </summary>
		/// <param name="client"><see cref="Imap"/> instance.</param>
		/// <returns><see cref="MessageIndexCollection"/> instance.</returns>
		private MessageIndexCollection GetNotSyncedMessageIndexes(Imap client) {
			MessageIndexCollection messageIndexCollection = GetUnsyncMsgIndexCollection(client);
			if (IsFolderWasRecreated(messageIndexCollection)) {
				CurrentMessageUidInFolder = "0";
				messageIndexCollection = GetUnsyncMsgIndexCollection(client);
			}
			List<long> messageIndexList = messageIndexCollection.Cast<long>().ToList();
			messageIndexList.Sort();
			if (messageIndexList.Count > 0 && messageIndexList.First().ToString() == CurrentMessageUidInFolder) {
				messageIndexCollection.RemoveAt(0);
			}
			return messageIndexCollection;
		}

		/// <summary>
		/// When folder removed and created again, its messages UIs counter clears, and starts from 0.
		/// Due to imap protocol realization, search method with "UId N:*" query allways returns last message index in folder.
		/// Theafore, when last message index UId is less then <see cref="CurrentMessageUidInFolder"/> value, 
		/// we assume that folder was recreated.
		/// </summary>
		/// <param name="messageIndexCollection"><see cref="MessageIndexCollection"/> instance.</param>
		/// <returns><c>True</c> if folder was recreated in mailbox, <c>false</c> otherwise.</returns>
		private bool IsFolderWasRecreated(MessageIndexCollection messageIndexCollection) {
			List<long> messageIndexList = messageIndexCollection.Cast<long>().ToList();
			messageIndexList.Sort();
			return messageIndexList.Count > 0 && messageIndexList.First() < long.Parse(CurrentMessageUidInFolder);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets unsynchronized messages indexes from mail server.
		/// </summary>
		/// <param name="client"><see cref="Imap"/> instance.</param>
		/// <returns>Unsynchronized messages indexes from mail server.</returns>
		protected virtual MessageIndexCollection GetUnsyncMsgIndexCollection(Imap client) {
			return client.Search(true, GetUnsyncMsgSearchQuery(), null);
		}

		/// <summary>
		/// Gets "UidValidity" property from <see cref="Imap"/> instance.
		/// </summary>
		/// <param name="client"><see cref="Imap"/> instance.</param>
		/// <returns>"UidValidity" property.</returns>
		protected virtual string GetImapClientUidValidity(Imap client) {
			return client.UidValidity.ToString();
		}

		/// <summary>
		/// Returns <see cref="MailBee.ImapMail.MessageIndexCollection"/> for messages, resolved as not synced
		/// in <paramref name="folderPath"/> folder. When <paramref name="folderPath"/> not passed,
		/// uses <see cref="Imap.UidValidity"/> as current folder.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <param name="folderPath">Imap folder full path.</param>
		/// <returns>
		/// Not synced messages <see cref="MailBee.ImapMail.MessageIndexCollection"/>.
		/// </returns>
		protected virtual MessageIndexCollection InternalGetUnsyncedMsgIndexes(Imap client, string folderPath = null) {
			string filterColumnPath = folderPath.IsNullOrEmpty() ? "UIdValidity" : "FolderPath";
			string columnFilterValue = folderPath.IsNullOrEmpty() ? GetImapClientUidValidity(client) : folderPath;
			CurrentMessageUidInFolder = GetsMessageUidInFolder(SyncSettings.PrimaryColumnValue, filterColumnPath,
					columnFilterValue);
			return GetNotSyncedMessageIndexes(client);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// <see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap)"/>
		/// </summary>
		public override MessageIndexCollection GetUnsyncedMsgIndexes(Imap client) {
			return InternalGetUnsyncedMsgIndexes(client);
		}

		/// <summary>
		/// <see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap, string)"/>
		/// </summary>
		public override MessageIndexCollection GetUnsyncedMsgIndexes(Imap client, string folderPath) {
			return InternalGetUnsyncedMsgIndexes(client, folderPath);
		}

		#endregion
	}

	#endregion
}

