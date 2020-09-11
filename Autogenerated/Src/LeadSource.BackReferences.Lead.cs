namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadSource

	/// <exclude/>
	public class LeadSource : Terrasoft.Configuration.LeadSource
	{

		#region Constructors: Public

		public LeadSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadSource(Terrasoft.Configuration.LeadSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByLeadSource {
			get;
			set;
		}

		public IEnumerable<LeadSourceCode> LeadSourceCodeCollectionByLeadSource {
			get;
			set;
		}

		public IEnumerable<LeadSourceUrl> LeadSourceUrlCollectionByLeadSource {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

