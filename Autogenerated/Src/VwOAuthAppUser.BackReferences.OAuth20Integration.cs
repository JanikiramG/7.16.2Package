namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOAuthAppUser

	/// <exclude/>
	public class VwOAuthAppUser : Terrasoft.Configuration.VwOAuthAppUser
	{

		#region Constructors: Public

		public VwOAuthAppUser(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwOAuthAppUser(Terrasoft.Configuration.VwOAuthAppUser source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

