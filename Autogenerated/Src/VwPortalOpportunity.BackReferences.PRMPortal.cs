namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwPortalOpportunity

	/// <exclude/>
	public class VwPortalOpportunity : Terrasoft.Configuration.VwPortalOpportunity
	{

		#region Constructors: Public

		public VwPortalOpportunity(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwPortalOpportunity(Terrasoft.Configuration.VwPortalOpportunity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

