namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseTag

	/// <exclude/>
	public class KnowledgeBaseTag : Terrasoft.Configuration.KnowledgeBaseTag
	{

		#region Constructors: Public

		public KnowledgeBaseTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseTag(Terrasoft.Configuration.KnowledgeBaseTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<KnowledgeBaseTagDecoupling> KnowledgeBaseTagDecouplingCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

