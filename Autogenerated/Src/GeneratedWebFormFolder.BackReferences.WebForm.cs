namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GeneratedWebFormFolder

	/// <exclude/>
	public class GeneratedWebFormFolder : Terrasoft.Configuration.GeneratedWebFormFolder
	{

		#region Constructors: Public

		public GeneratedWebFormFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public GeneratedWebFormFolder(Terrasoft.Configuration.GeneratedWebFormFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GeneratedWebFormFolder> GeneratedWebFormFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormInFolder> GeneratedWebFormInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

