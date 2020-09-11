namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContentUserBlock

	/// <exclude/>
	public class ContentUserBlock : Terrasoft.Configuration.ContentUserBlock
	{

		#region Constructors: Public

		public ContentUserBlock(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContentUserBlock(Terrasoft.Configuration.ContentUserBlock source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

