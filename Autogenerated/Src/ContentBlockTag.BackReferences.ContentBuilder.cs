namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContentBlockTag

	/// <exclude/>
	public class ContentBlockTag : Terrasoft.Configuration.ContentBlockTag
	{

		#region Constructors: Public

		public ContentBlockTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContentBlockTag(Terrasoft.Configuration.ContentBlockTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<ContentBlockInTag> ContentBlockInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

