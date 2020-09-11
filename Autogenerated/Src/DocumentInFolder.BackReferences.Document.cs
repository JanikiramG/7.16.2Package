namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentInFolder

	/// <exclude/>
	public class DocumentInFolder : Terrasoft.Configuration.DocumentInFolder
	{

		#region Constructors: Public

		public DocumentInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentInFolder(Terrasoft.Configuration.DocumentInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

