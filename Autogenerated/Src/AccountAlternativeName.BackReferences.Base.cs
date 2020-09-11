namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountAlternativeName

	/// <exclude/>
	public class AccountAlternativeName : Terrasoft.Configuration.AccountAlternativeName
	{

		#region Constructors: Public

		public AccountAlternativeName(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountAlternativeName(Terrasoft.Configuration.AccountAlternativeName source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

