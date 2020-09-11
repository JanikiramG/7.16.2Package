namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentInTag

	/// <exclude/>
	public class DocumentInTag : Terrasoft.Configuration.DocumentInTag
	{

		#region Constructors: Public

		public DocumentInTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentInTag(Terrasoft.Configuration.DocumentInTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

