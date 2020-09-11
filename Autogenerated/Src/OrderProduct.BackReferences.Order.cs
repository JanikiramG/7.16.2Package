namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OrderProduct

	/// <exclude/>
	public class OrderProduct : Terrasoft.Configuration.OrderProduct
	{

		#region Constructors: Public

		public OrderProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public OrderProduct(Terrasoft.Configuration.OrderProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentElement> SupplyPaymentElementCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<SupplyPaymentProduct> SupplyPaymentProductCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwOrderProductFilter> VwOrderProductFilterCollectionByProduct {
			get;
			set;
		}

		public IEnumerable<VwSupplyPaymentProduct> VwSupplyPaymentProductCollectionByOrderProduct {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

