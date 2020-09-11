namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentType

	/// <exclude/>
	public class DocumentType : Terrasoft.Configuration.DocumentType
	{

		#region Constructors: Public

		public DocumentType(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentType(Terrasoft.Configuration.DocumentType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Document> DocumentCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

