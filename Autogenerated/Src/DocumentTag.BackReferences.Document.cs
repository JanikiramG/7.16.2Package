namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentTag

	/// <exclude/>
	public class DocumentTag : Terrasoft.Configuration.DocumentTag
	{

		#region Constructors: Public

		public DocumentTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentTag(Terrasoft.Configuration.DocumentTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<DocumentInTag> DocumentInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

