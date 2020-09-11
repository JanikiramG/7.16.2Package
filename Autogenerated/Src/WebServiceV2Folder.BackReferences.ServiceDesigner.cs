namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: WebServiceV2Folder

	/// <exclude/>
	public class WebServiceV2Folder : Terrasoft.Configuration.WebServiceV2Folder
	{

		#region Constructors: Public

		public WebServiceV2Folder(UserConnection userConnection)
			: base(userConnection) {
		}

		public WebServiceV2Folder(Terrasoft.Configuration.WebServiceV2Folder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<WebServiceV2Folder> WebServiceV2FolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<WebServiceV2InFolder> WebServiceV2InFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

