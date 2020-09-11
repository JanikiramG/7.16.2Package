namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentProduct

	/// <exclude/>
	public class SupplyPaymentProduct : Terrasoft.Configuration.SupplyPaymentProduct
	{

		#region Constructors: Public

		public SupplyPaymentProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public SupplyPaymentProduct(Terrasoft.Configuration.SupplyPaymentProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<InvoiceProduct> InvoiceProductCollectionBySupplyPaymentProduct {
			get;
			set;
		}

		public IEnumerable<VwSupplyPaymentProduct> VwSupplyPaymentProductCollectionBySupplyPaymentProduct {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

