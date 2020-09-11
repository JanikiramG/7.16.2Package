namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductInTag

	/// <exclude/>
	public class ProductInTag : Terrasoft.Configuration.ProductInTag
	{

		#region Constructors: Public

		public ProductInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductInTag(Terrasoft.Configuration.ProductInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

