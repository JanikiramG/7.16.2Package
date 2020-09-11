namespace Terrasoft.Configuration.Imap
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using MailBee.ImapMail;

	#region Class: ImapFolderCollection

	/// <summary>
	/// Class that encapsulates <see cref="MailBee.ImapMail.FolderCollection"/> instance.
	/// </summary>
	/// <remarks>
	/// Was created in order to make ImapUtilitiesService implementation independent from external library.
	/// </remarks>
	public class ImapFolderCollection: IEnumerable<ImapFolder> {

		#region Fields: Private

		///<summary>
		/// Collection of imap folders.
		///</summary>
		private IEnumerable<ImapFolder> _imapFolders;

		#endregion

		#region Constructors: Public 

		public ImapFolderCollection(FolderCollection foldersCollection) {
			_imapFolders = GetFolders(foldersCollection);
		}
		
		public ImapFolderCollection(IEnumerable<ImapFolder> folders) {
			_imapFolders = folders.OrderBy(f => f.NestingLevel);
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Creates collection of <see cref="ImapFolder"/> from <paramref name="folders"/>.
		/// </summary>
		/// <param name="folders"><see cref="MailBee.ImapMail.FolderCollection"/> instance.</param>
		/// <returns>ImapFolder collection</returns>
		private IEnumerable<ImapFolder> GetFolders(FolderCollection folders) {
			var result = new List<ImapFolder>();
			for (var i = 0; i < folders.Count; i++) {
				result.Add(new ImapFolder(folders[i]));
			}
			return result.OrderBy(f => f.NestingLevel);
		}

		#endregion

		#region Methods: Public
		
		/// <summary>
		/// Returns an <see cref="ImapFolder> typed enumerator.
		/// </summary>
		/// <returns>Typed enumerator instance.</returns>
		public IEnumerator<ImapFolder> GetEnumerator() {
			return _imapFolders.GetEnumerator();
		}
		
		/// <summary>
		/// Returns an <see cref="ImapFolder> enumerator.
		/// </summary>
		/// <returns>Enumerator instance.</returns>
		IEnumerator IEnumerable.GetEnumerator() {
			return GetEnumerator();
		}

		#endregion
	}

	#endregion
}
