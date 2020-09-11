namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ProductFolder

	/// <exclude/>
	public class ProductFolder : Terrasoft.Configuration.ProductFolder
	{

		#region Constructors: Public

		public ProductFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public ProductFolder(Terrasoft.Configuration.ProductFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ProductFolder> ProductFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<ProductInFolder> ProductInFolderCollectionByFolder {
			get;
			set;
		}

		public IEnumerable<ProductInLeadType> ProductInLeadTypeCollectionByProductFolder {
			get;
			set;
		}

		public IEnumerable<VwProductInLeadType> VwProductInLeadTypeCollectionByProductFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

