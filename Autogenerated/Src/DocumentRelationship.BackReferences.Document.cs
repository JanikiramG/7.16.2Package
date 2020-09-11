namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentRelationship

	/// <exclude/>
	public class DocumentRelationship : Terrasoft.Configuration.DocumentRelationship
	{

		#region Constructors: Public

		public DocumentRelationship(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentRelationship(Terrasoft.Configuration.DocumentRelationship source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

