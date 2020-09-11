namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: KnowledgeBase

	/// <exclude/>
	public class KnowledgeBase : Terrasoft.Configuration.KnowledgeBase
	{

		#region Constructors: Public

		public KnowledgeBase(UserConnection userConnection)
			: base(userConnection) {
		}

		public KnowledgeBase(Terrasoft.Configuration.KnowledgeBase source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Comment> CommentCollectionByKnowledgeBase {
			get;
			set;
		}

		public IEnumerable<Favorites> FavoritesCollectionByKnowledgeBase {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseFile> KnowledgeBaseFileCollectionByKnowledgeBase {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseInFolder> KnowledgeBaseInFolderCollectionByKnowledgeBase {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2CollectionByEntity {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseTagDecoupling> KnowledgeBaseTagDecouplingCollectionByKnowledgeBase {
			get;
			set;
		}

		public IEnumerable<Like> LikeCollectionByKnowledgeBase {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

