namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipTag

	/// <exclude/>
	public class PartnershipTag : Terrasoft.Configuration.PartnershipTag
	{

		#region Constructors: Public

		public PartnershipTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipTag(Terrasoft.Configuration.PartnershipTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PartnershipInTag> PartnershipInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

