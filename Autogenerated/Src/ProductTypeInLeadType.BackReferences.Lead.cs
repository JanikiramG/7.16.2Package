namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductTypeInLeadType

	/// <exclude/>
	public class ProductTypeInLeadType : Terrasoft.Configuration.ProductTypeInLeadType
	{

		#region Constructors: Public

		public ProductTypeInLeadType(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductTypeInLeadType(Terrasoft.Configuration.ProductTypeInLeadType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwProductInLeadType> VwProductInLeadTypeCollectionByProductTypeInLeadType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

