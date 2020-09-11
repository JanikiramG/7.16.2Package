namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailboxContactFolder

	/// <exclude/>
	public class MailboxContactFolder : Terrasoft.Configuration.MailboxContactFolder
	{

		#region Constructors: Public

		public MailboxContactFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailboxContactFolder(Terrasoft.Configuration.MailboxContactFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

