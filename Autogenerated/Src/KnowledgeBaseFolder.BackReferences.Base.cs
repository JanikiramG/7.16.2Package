namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseFolder

	/// <exclude/>
	public class KnowledgeBaseFolder : Terrasoft.Configuration.KnowledgeBaseFolder
	{

		#region Constructors: Public

		public KnowledgeBaseFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseFolder(Terrasoft.Configuration.KnowledgeBaseFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<KnowledgeBaseFolder> KnowledgeBaseFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseInFolder> KnowledgeBaseInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

