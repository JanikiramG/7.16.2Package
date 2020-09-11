namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadMedium

	/// <exclude/>
	public class LeadMedium : Terrasoft.Configuration.LeadMedium
	{

		#region Constructors: Public

		public LeadMedium(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadMedium(Terrasoft.Configuration.LeadMedium source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByLeadMedium {
			get;
			set;
		}

		public IEnumerable<LeadMediumCode> LeadMediumCodeCollectionByLeadMedium {
			get;
			set;
		}

		public IEnumerable<LeadSource> LeadSourceCollectionByLeadMedium {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

