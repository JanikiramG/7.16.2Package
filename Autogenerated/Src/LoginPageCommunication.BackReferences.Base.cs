namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LoginPageCommunication

	/// <exclude/>
	public class LoginPageCommunication : Terrasoft.Configuration.LoginPageCommunication
	{

		#region Constructors: Public

		public LoginPageCommunication(UserConnection userConnection)
			: base(userConnection) {
		}

		public LoginPageCommunication(Terrasoft.Configuration.LoginPageCommunication source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

