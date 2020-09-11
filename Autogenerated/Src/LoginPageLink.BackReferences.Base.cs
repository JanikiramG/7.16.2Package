namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LoginPageLink

	/// <exclude/>
	public class LoginPageLink : Terrasoft.Configuration.LoginPageLink
	{

		#region Constructors: Public

		public LoginPageLink(UserConnection userConnection)
			: base(userConnection) {
		}

		public LoginPageLink(Terrasoft.Configuration.LoginPageLink source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

