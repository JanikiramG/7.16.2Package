namespace Terrasoft.Configuration.Imap
{
	using MailBee.ImapMail;
	using Terrasoft.Mail;

	#region Class: ImapFolder

	/// <summary>
	/// Class that encapsulates <see cref="MailBee.ImapMail.Folder"/> instance.
	/// </summary>
	/// <remarks>
	/// Was created in order to make ImapUtilitiesService implementation independent from external library.
	/// </remarks>
	public class ImapFolder: IImapFolder
	{

		#region Constructors: Public 

		public ImapFolder(Folder folder) {
			Name = folder.Name;
			Delimiter = folder.Delimiter;
			ShortName = folder.ShortName;
			RawName = folder.RawName;
			NestingLevel = folder.NestingLevel;
			Flags = folder.Flags;
		}

		public ImapFolder() {
		}

		#endregion

		#region Properties: Public

		///<summary>
		///Full name of the folder.
		///</summary>
		public string Name {
			get;
			set;
		}
		
		///<summary>
		///The character which is used as a hierarchy delimiter of separate levels of folder names.
		///</summary>
		public string Delimiter {
			get;
			set;
		}

		///<summary>
		///Short name (without parent folder names if any) of the folder.
		///</summary>
		public string ShortName {
			get;
			set;
		}

		///<summary>
		///Full name of the folder as was returned by the server including parent folder names if any.
		///</summary>
		public string RawName {
			get;
			set;
		}
		
		///<summary>
		///Level of nesting of this folder into parent folders.
		///</summary>
		public int NestingLevel {
			get;
			set;
		}
		
		/// <summary>
		/// <see cref="MailBee.ImapMail.FolderFlags"/> associated with the folder.
		/// </summary>
		public FolderFlags Flags {
			get;
			set;
		}

		/// <summary>
		/// Folder unique identifier.
		/// </summary>
		public long UIdValidity {
			get;
			set;
		}

		#endregion
	}

	#endregion
}
