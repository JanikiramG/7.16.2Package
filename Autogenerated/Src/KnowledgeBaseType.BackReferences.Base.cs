namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBaseType

	/// <exclude/>
	public class KnowledgeBaseType : Terrasoft.Configuration.KnowledgeBaseType
	{

		#region Constructors: Public

		public KnowledgeBaseType(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBaseType(Terrasoft.Configuration.KnowledgeBaseType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<KnowledgeBase> KnowledgeBaseCollectionByType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

