namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnerType

	/// <exclude/>
	public class PartnerType : Terrasoft.Configuration.PartnerType
	{

		#region Constructors: Public

		public PartnerType(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnerType(Terrasoft.Configuration.PartnerType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Lead> LeadCollectionByPartnerType {
			get;
			set;
		}

		public IEnumerable<PartnerLevel> PartnerLevelCollectionByPartnerType {
			get;
			set;
		}

		public IEnumerable<Partnership> PartnershipCollectionByPartnerType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

