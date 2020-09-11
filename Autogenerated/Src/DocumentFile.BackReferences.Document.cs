namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentFile

	/// <exclude/>
	public class DocumentFile : Terrasoft.Configuration.DocumentFile
	{

		#region Constructors: Public

		public DocumentFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentFile(Terrasoft.Configuration.DocumentFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

