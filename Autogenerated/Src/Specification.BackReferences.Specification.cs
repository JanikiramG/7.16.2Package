namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Specification

	/// <exclude/>
	public class Specification : Terrasoft.Configuration.Specification
	{

		#region Constructors: Public

		public Specification(UserConnection userConnection)
			: base(userConnection) {
		}

		public Specification(Terrasoft.Configuration.Specification source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<ProductFilter> ProductFilterCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInLead> SpecificationInLeadCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInObject> SpecificationInObjectCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationInProduct> SpecificationInProductCollectionBySpecification {
			get;
			set;
		}

		public IEnumerable<SpecificationListItem> SpecificationListItemCollectionBySpecification {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

