namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContentBlock

	/// <exclude/>
	public class ContentBlock : Terrasoft.Configuration.ContentBlock
	{

		#region Constructors: Public

		public ContentBlock(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContentBlock(Terrasoft.Configuration.ContentBlock source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContentBlockFile> ContentBlockFileCollectionByContentBlock {
			get;
			set;
		}

		public IEnumerable<ContentBlockInTag> ContentBlockInTagCollectionByEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

