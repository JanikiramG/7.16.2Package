namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductTag

	/// <exclude/>
	public class ProductTag : Terrasoft.Configuration.ProductTag
	{

		#region Constructors: Public

		public ProductTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductTag(Terrasoft.Configuration.ProductTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProductInTag> ProductInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

