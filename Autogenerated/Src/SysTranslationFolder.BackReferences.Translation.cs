namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysTranslationFolder

	/// <exclude/>
	public class SysTranslationFolder : Terrasoft.Configuration.SysTranslationFolder
	{

		#region Constructors: Public

		public SysTranslationFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysTranslationFolder(Terrasoft.Configuration.SysTranslationFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysTranslationFolder> SysTranslationFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysTranslationInFolder> SysTranslationInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

