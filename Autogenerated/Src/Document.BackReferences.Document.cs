namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Document

	/// <exclude/>
	public class Document : Terrasoft.Configuration.Document
	{

		#region Constructors: Public

		public Document(UserConnection userConnection)
			: base(userConnection) {
		}

		public Document(Terrasoft.Configuration.Document source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Activity> ActivityCollectionByDocument {
			get;
			set;
		}

		public IEnumerable<DocumentFile> DocumentFileCollectionByDocument {
			get;
			set;
		}

		public IEnumerable<DocumentInFolder> DocumentInFolderCollectionByDocument {
			get;
			set;
		}

		public IEnumerable<DocumentInTag> DocumentInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<DocumentParticipant> DocumentParticipantCollectionByDocument {
			get;
			set;
		}

		public IEnumerable<DocumentRelationship> DocumentRelationshipCollectionByDocumentA {
			get;
			set;
		}

		public IEnumerable<DocumentRelationship> DocumentRelationshipCollectionByDocumentB {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByDocument {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

