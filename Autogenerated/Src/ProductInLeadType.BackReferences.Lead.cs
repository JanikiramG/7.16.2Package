namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductInLeadType

	/// <exclude/>
	public class ProductInLeadType : Terrasoft.Configuration.ProductInLeadType
	{

		#region Constructors: Public

		public ProductInLeadType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductInLeadType(Terrasoft.Configuration.ProductInLeadType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

