namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseFile

	/// <exclude/>
	public class KnowledgeBaseFile : Terrasoft.Configuration.KnowledgeBaseFile
	{

		#region Constructors: Public

		public KnowledgeBaseFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseFile(Terrasoft.Configuration.KnowledgeBaseFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

