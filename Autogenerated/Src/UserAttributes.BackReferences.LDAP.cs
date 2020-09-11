namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UserAttributes

	/// <exclude/>
	public class UserAttributes : Terrasoft.Configuration.UserAttributes
	{

		#region Constructors: Public

		public UserAttributes(UserConnection userConnection)
			: base(userConnection) {
		}

		public UserAttributes(Terrasoft.Configuration.UserAttributes source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

