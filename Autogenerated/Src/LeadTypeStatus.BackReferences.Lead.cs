namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadTypeStatus

	/// <exclude/>
	public class LeadTypeStatus : Terrasoft.Configuration.LeadTypeStatus
	{

		#region Constructors: Public

		public LeadTypeStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadTypeStatus(Terrasoft.Configuration.LeadTypeStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByLeadTypeStatus {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadTypeRipeness {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

