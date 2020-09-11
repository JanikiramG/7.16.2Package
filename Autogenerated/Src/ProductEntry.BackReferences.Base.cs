namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductEntry

	/// <exclude/>
	public class ProductEntry : Terrasoft.Configuration.ProductEntry
	{

		#region Constructors: Public

		public ProductEntry(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductEntry(Terrasoft.Configuration.ProductEntry source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

