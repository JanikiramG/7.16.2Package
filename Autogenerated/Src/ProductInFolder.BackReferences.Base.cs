namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductInFolder

	/// <exclude/>
	public class ProductInFolder : Terrasoft.Configuration.ProductInFolder
	{

		#region Constructors: Public

		public ProductInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductInFolder(Terrasoft.Configuration.ProductInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

