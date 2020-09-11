namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductPrice

	/// <exclude/>
	public class ProductPrice : Terrasoft.Configuration.ProductPrice
	{

		#region Constructors: Public

		public ProductPrice(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductPrice(Terrasoft.Configuration.ProductPrice source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

