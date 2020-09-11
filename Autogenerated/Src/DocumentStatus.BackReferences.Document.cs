namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentStatus

	/// <exclude/>
	public class DocumentStatus : Terrasoft.Configuration.DocumentStatus
	{

		#region Constructors: Public

		public DocumentStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentStatus(Terrasoft.Configuration.DocumentStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

