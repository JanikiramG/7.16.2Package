namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ParameterType

	/// <exclude/>
	public class ParameterType : Terrasoft.Configuration.ParameterType
	{

		#region Constructors: Public

		public ParameterType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ParameterType(Terrasoft.Configuration.ParameterType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionByParameterType {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByParameterType {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByParameterType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

