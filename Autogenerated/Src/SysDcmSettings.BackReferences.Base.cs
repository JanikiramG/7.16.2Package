namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDcmSettings

	/// <exclude/>
	public class SysDcmSettings : Terrasoft.Configuration.SysDcmSettings
	{

		#region Constructors: Public

		public SysDcmSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDcmSettings(Terrasoft.Configuration.SysDcmSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysDcmSchemaInSettings> SysDcmSchemaInSettingsCollectionBySysDcmSettings {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

