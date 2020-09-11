namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MailboxSettingsFile

	/// <exclude/>
	public class MailboxSettingsFile : Terrasoft.Configuration.MailboxSettingsFile
	{

		#region Constructors: Public

		public MailboxSettingsFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public MailboxSettingsFile(Terrasoft.Configuration.MailboxSettingsFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

