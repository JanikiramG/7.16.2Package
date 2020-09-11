namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleDcmSettings

	/// <exclude/>
	public class SysModuleDcmSettings : Terrasoft.Configuration.SysModuleDcmSettings
	{

		#region Constructors: Public

		public SysModuleDcmSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleDcmSettings(Terrasoft.Configuration.SysModuleDcmSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

