namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadStatus

	/// <exclude/>
	public class LeadStatus : Terrasoft.Configuration.LeadStatus
	{

		#region Constructors: Public

		public LeadStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadStatus(Terrasoft.Configuration.LeadStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

