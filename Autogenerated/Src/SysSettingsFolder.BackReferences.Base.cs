namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettingsFolder

	/// <exclude/>
	public class SysSettingsFolder : Terrasoft.Configuration.SysSettingsFolder
	{

		#region Constructors: Public

		public SysSettingsFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettingsFolder(Terrasoft.Configuration.SysSettingsFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysSettings> SysSettingsCollectionBySysFolder {
			get;
			set;
		}

		public IEnumerable<SysSettingsFolder> SysSettingsFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<SysSettingsInFolder> SysSettingsInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

