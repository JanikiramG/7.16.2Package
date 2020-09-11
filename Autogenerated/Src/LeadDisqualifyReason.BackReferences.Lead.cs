namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadDisqualifyReason

	/// <exclude/>
	public class LeadDisqualifyReason : Terrasoft.Configuration.LeadDisqualifyReason
	{

		#region Constructors: Public

		public LeadDisqualifyReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadDisqualifyReason(Terrasoft.Configuration.LeadDisqualifyReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByLeadDisqualifyReason {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

