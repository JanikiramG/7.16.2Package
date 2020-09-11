namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnerParamCategory

	/// <exclude/>
	public class PartnerParamCategory : Terrasoft.Configuration.PartnerParamCategory
	{

		#region Constructors: Public

		public PartnerParamCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnerParamCategory(Terrasoft.Configuration.PartnerParamCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerParamCategory {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByPartnerParamCategory {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByPartnerParamCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

