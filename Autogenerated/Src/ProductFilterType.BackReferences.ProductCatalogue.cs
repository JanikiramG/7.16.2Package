namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductFilterType

	/// <exclude/>
	public class ProductFilterType : Terrasoft.Configuration.ProductFilterType
	{

		#region Constructors: Public

		public ProductFilterType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductFilterType(Terrasoft.Configuration.ProductFilterType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProductFilter> ProductFilterCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

