namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadType

	/// <exclude/>
	public class LeadType : Terrasoft.Configuration.LeadType
	{

		#region Constructors: Public

		public LeadType(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadType(Terrasoft.Configuration.LeadType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<ProductInLeadType> ProductInLeadTypeCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByLeadType {
			get;
			set;
		}

		public IEnumerable<VwProductInLeadType> VwProductInLeadTypeCollectionByLeadType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

