namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipInTag

	/// <exclude/>
	public class PartnershipInTag : Terrasoft.Configuration.PartnershipInTag
	{

		#region Constructors: Public

		public PartnershipInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipInTag(Terrasoft.Configuration.PartnershipInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

