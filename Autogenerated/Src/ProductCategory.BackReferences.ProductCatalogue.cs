namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductCategory

	/// <exclude/>
	public class ProductCategory : Terrasoft.Configuration.ProductCategory
	{

		#region Constructors: Public

		public ProductCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductCategory(Terrasoft.Configuration.ProductCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Product> ProductCollectionByCategory {
			get;
			set;
		}

		public IEnumerable<ProductType> ProductTypeCollectionByCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

