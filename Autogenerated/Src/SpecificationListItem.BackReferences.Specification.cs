namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SpecificationListItem

	/// <exclude/>
	public class SpecificationListItem : Terrasoft.Configuration.SpecificationListItem
	{

		#region Constructors: Public

		public SpecificationListItem(UserConnection userConnection)
			: base(userConnection) {
		}

		public SpecificationListItem(Terrasoft.Configuration.SpecificationListItem source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LevelPartnershipParam> LevelPartnershipParamCollectionByListItemValue {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByListItemValue {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByListItemValue {
			get;
			set;
		}

		public IEnumerable<SpecificationInLead> SpecificationInLeadCollectionByListItemValue {
			get;
			set;
		}

		public IEnumerable<SpecificationInObject> SpecificationInObjectCollectionByListItemValue {
			get;
			set;
		}

		public IEnumerable<SpecificationInProduct> SpecificationInProductCollectionByListItemValue {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

