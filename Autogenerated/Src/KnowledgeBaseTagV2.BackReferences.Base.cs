namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseTagV2

	/// <exclude/>
	public class KnowledgeBaseTagV2 : Terrasoft.Configuration.KnowledgeBaseTagV2
	{

		#region Constructors: Public

		public KnowledgeBaseTagV2(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseTagV2(Terrasoft.Configuration.KnowledgeBaseTagV2 source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2CollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

