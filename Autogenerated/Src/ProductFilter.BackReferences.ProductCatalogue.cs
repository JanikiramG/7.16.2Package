namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductFilter

	/// <exclude/>
	public class ProductFilter : Terrasoft.Configuration.ProductFilter
	{

		#region Constructors: Public

		public ProductFilter(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductFilter(Terrasoft.Configuration.ProductFilter source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

