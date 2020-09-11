namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentProduct

	/// <exclude/>
	public class DocumentProduct : Terrasoft.Configuration.DocumentProduct
	{

		#region Constructors: Public

		public DocumentProduct(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentProduct(Terrasoft.Configuration.DocumentProduct source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

