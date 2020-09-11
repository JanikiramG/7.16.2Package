namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSupplyPaymentProduct

	/// <exclude/>
	public class VwSupplyPaymentProduct : Terrasoft.Configuration.VwSupplyPaymentProduct
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSupplyPaymentProduct(Terrasoft.Configuration.VwSupplyPaymentProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

