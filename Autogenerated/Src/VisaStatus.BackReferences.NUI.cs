namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VisaStatus

	/// <exclude/>
	public class VisaStatus : Terrasoft.Configuration.VisaStatus
	{

		#region Constructors: Public

		public VisaStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public VisaStatus(Terrasoft.Configuration.VisaStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContractVisa> ContractVisaCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<VwVisa> VwVisaCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

