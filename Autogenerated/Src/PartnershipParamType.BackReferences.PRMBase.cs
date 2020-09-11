namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipParamType

	/// <exclude/>
	public class PartnershipParamType : Terrasoft.Configuration.PartnershipParamType
	{

		#region Constructors: Public

		public PartnershipParamType(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipParamType(Terrasoft.Configuration.PartnershipParamType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByPartnershipParameterType {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByPartnershipParameterType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

