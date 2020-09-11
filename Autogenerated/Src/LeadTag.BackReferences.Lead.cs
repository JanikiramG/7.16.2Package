namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadTag

	/// <exclude/>
	public class LeadTag : Terrasoft.Configuration.LeadTag
	{

		#region Constructors: Public

		public LeadTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadTag(Terrasoft.Configuration.LeadTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LeadInTag> LeadInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

