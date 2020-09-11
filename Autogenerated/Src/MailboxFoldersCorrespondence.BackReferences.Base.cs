namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailboxFoldersCorrespondence

	/// <exclude/>
	public class MailboxFoldersCorrespondence : Terrasoft.Configuration.MailboxFoldersCorrespondence
	{

		#region Constructors: Public

		public MailboxFoldersCorrespondence(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailboxFoldersCorrespondence(Terrasoft.Configuration.MailboxFoldersCorrespondence source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

