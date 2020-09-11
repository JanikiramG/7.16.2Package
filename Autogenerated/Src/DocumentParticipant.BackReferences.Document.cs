namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DocumentParticipant

	/// <exclude/>
	public class DocumentParticipant : Terrasoft.Configuration.DocumentParticipant
	{

		#region Constructors: Public

		public DocumentParticipant(UserConnection userConnection)
			: base(userConnection) {
		}

		public DocumentParticipant(Terrasoft.Configuration.DocumentParticipant source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

