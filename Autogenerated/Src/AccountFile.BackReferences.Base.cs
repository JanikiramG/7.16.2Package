namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountFile

	/// <exclude/>
	public class AccountFile : Terrasoft.Configuration.AccountFile
	{

		#region Constructors: Public

		public AccountFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountFile(Terrasoft.Configuration.AccountFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

