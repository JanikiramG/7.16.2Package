namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentState

	/// <exclude/>
	public class DocumentState : Terrasoft.Configuration.DocumentState
	{

		#region Constructors: Public

		public DocumentState(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentState(Terrasoft.Configuration.DocumentState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Document> DocumentCollectionByState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

