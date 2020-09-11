namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentType

	/// <exclude/>
	public class SupplyPaymentType : Terrasoft.Configuration.SupplyPaymentType
	{

		#region Constructors: Public

		public SupplyPaymentType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentType(Terrasoft.Configuration.SupplyPaymentType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByType {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemCollectionByType {
			get;
			set;
		}

		public IEnumerable<VwOrderProductFilter> VwOrderProductFilterCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

