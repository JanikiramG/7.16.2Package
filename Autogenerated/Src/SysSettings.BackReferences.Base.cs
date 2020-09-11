namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettings

	/// <exclude/>
	public class SysSettings : Terrasoft.Configuration.SysSettings
	{

		#region Constructors: Public

		public SysSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettings(Terrasoft.Configuration.SysSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysSettingsInFolder> SysSettingsInFolderCollectionBySysSettings {
			get;
			set;
		}

		public IEnumerable<SysSettingsReferenceSchema> SysSettingsReferenceSchemaCollectionBySysSettings {
			get;
			set;
		}

		public IEnumerable<SysSettingsValue> SysSettingsValueCollectionBySysSettings {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

