namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ContentBlockFile

	/// <exclude/>
	public class ContentBlockFile : Terrasoft.Configuration.ContentBlockFile
	{

		#region Constructors: Public

		public ContentBlockFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public ContentBlockFile(Terrasoft.Configuration.ContentBlockFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

