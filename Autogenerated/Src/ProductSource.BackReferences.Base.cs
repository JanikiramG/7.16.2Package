namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductSource

	/// <exclude/>
	public class ProductSource : Terrasoft.Configuration.ProductSource
	{

		#region Constructors: Public

		public ProductSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductSource(Terrasoft.Configuration.ProductSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Product> ProductCollectionByProductSource {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

