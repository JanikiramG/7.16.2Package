namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseInFolder

	/// <exclude/>
	public class KnowledgeBaseInFolder : Terrasoft.Configuration.KnowledgeBaseInFolder
	{

		#region Constructors: Public

		public KnowledgeBaseInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseInFolder(Terrasoft.Configuration.KnowledgeBaseInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

