namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecificationType

	/// <exclude/>
	public class SpecificationType : Terrasoft.Configuration.SpecificationType
	{

		#region Constructors: Public

		public SpecificationType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SpecificationType(Terrasoft.Configuration.SpecificationType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionByParameterValueType {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByParameterValueType {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByParameterValueType {
			get;
			set;
		}

		public IEnumerable<Specification> SpecificationCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

