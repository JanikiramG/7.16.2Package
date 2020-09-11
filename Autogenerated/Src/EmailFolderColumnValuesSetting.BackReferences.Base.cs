namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EmailFolderColumnValuesSetting

	/// <exclude/>
	public class EmailFolderColumnValuesSetting : Terrasoft.Configuration.EmailFolderColumnValuesSetting
	{

		#region Constructors: Public

		public EmailFolderColumnValuesSetting(UserConnection userConnection)
			: base(userConnection) {
		}

		public EmailFolderColumnValuesSetting(Terrasoft.Configuration.EmailFolderColumnValuesSetting source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

