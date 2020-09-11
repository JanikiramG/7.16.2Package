namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwDocumentProduct

	/// <exclude/>
	public class VwDocumentProduct : Terrasoft.Configuration.VwDocumentProduct
	{

		#region Constructors: Public

		public VwDocumentProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwDocumentProduct(Terrasoft.Configuration.VwDocumentProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

