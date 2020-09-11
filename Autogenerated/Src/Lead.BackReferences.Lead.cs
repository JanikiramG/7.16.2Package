namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Lead

	/// <exclude/>
	public class Lead : Terrasoft.Configuration.Lead
	{

		#region Constructors: Public

		public Lead(UserConnection userConnection)
			: base(userConnection) {
		}

		public Lead(Terrasoft.Configuration.Lead source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByLead {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByLead {
			get;
			set;
		}

		public IEnumerable<FileLead> FileLeadCollectionByLead {
			get;
			set;
		}

		public IEnumerable<LeadAddress> LeadAddressCollectionByLead {
			get;
			set;
		}

		public IEnumerable<LeadInFolder> LeadInFolderCollectionByLead {
			get;
			set;
		}

		public IEnumerable<LeadInQualifyStatus> LeadInQualifyStatusCollectionByLead {
			get;
			set;
		}

		public IEnumerable<LeadInTag> LeadInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<LeadMessageHistory> LeadMessageHistoryCollectionByLead {
			get;
			set;
		}

		public IEnumerable<LeadProduct> LeadProductCollectionByLead {
			get;
			set;
		}

		public IEnumerable<SpecificationInLead> SpecificationInLeadCollectionByLead {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

