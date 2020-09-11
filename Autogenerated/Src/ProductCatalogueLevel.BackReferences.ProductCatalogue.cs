namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductCatalogueLevel

	/// <exclude/>
	public class ProductCatalogueLevel : Terrasoft.Configuration.ProductCatalogueLevel
	{

		#region Constructors: Public

		public ProductCatalogueLevel(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductCatalogueLevel(Terrasoft.Configuration.ProductCatalogueLevel source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

