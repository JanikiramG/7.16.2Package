namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityDepartment

	/// <exclude/>
	public class OpportunityDepartment : Terrasoft.Configuration.OpportunityDepartment
	{

		#region Constructors: Public

		public OpportunityDepartment(UserConnection userConnection)
			: base(userConnection) {
		}

		public OpportunityDepartment(Terrasoft.Configuration.OpportunityDepartment source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByOpportunityDepartment {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionByOpportunityDepartment {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByResponsibleDepartment {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

