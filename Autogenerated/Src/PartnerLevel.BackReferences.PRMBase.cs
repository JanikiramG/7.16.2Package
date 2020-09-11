namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnerLevel

	/// <exclude/>
	public class PartnerLevel : Terrasoft.Configuration.PartnerLevel
	{

		#region Constructors: Public

		public PartnerLevel(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnerLevel(Terrasoft.Configuration.PartnerLevel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionByPartnerLevel {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByPartnerLevel {
			get;
			set;
		}

		public IEnumerable<Partnership> PartnershipCollectionByPartnerLevel {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByPartnerLevel {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

