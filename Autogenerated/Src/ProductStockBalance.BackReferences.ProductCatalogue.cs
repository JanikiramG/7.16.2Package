namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductStockBalance

	/// <exclude/>
	public class ProductStockBalance : Terrasoft.Configuration.ProductStockBalance
	{

		#region Constructors: Public

		public ProductStockBalance(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductStockBalance(Terrasoft.Configuration.ProductStockBalance source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

