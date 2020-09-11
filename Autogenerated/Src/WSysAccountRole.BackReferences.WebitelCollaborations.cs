namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WSysAccountRole

	/// <exclude/>
	public class WSysAccountRole : Terrasoft.Configuration.WSysAccountRole
	{

		#region Constructors: Public

		public WSysAccountRole(UserConnection userConnection)
			: base(userConnection) {
		}

		public WSysAccountRole(Terrasoft.Configuration.WSysAccountRole source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WSysAccount> WSysAccountCollectionByRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

