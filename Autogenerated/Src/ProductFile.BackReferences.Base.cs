namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductFile

	/// <exclude/>
	public class ProductFile : Terrasoft.Configuration.ProductFile
	{

		#region Constructors: Public

		public ProductFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductFile(Terrasoft.Configuration.ProductFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

