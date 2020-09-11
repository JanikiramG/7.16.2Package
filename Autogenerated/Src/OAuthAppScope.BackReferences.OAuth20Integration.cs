namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OAuthAppScope

	/// <exclude/>
	public class OAuthAppScope : Terrasoft.Configuration.OAuthAppScope
	{

		#region Constructors: Public

		public OAuthAppScope(UserConnection userConnection)
			: base(userConnection) {
		}

		public OAuthAppScope(Terrasoft.Configuration.OAuthAppScope source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

