namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContentBlockInTag

	/// <exclude/>
	public class ContentBlockInTag : Terrasoft.Configuration.ContentBlockInTag
	{

		#region Constructors: Public

		public ContentBlockInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContentBlockInTag(Terrasoft.Configuration.ContentBlockInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

