namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductType

	/// <exclude/>
	public class ProductType : Terrasoft.Configuration.ProductType
	{

		#region Constructors: Public

		public ProductType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductType(Terrasoft.Configuration.ProductType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Product> ProductCollectionByType {
			get;
			set;
		}

		public IEnumerable<ProductFilter> ProductFilterCollectionByProductType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

