namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AccountCommunication

	/// <exclude/>
	public class AccountCommunication : Terrasoft.Configuration.AccountCommunication
	{

		#region Constructors: Public

		public AccountCommunication(UserConnection userConnection)
			: base(userConnection) {
		}

		public AccountCommunication(Terrasoft.Configuration.AccountCommunication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

