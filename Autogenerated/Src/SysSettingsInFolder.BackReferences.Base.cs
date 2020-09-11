namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettingsInFolder

	/// <exclude/>
	public class SysSettingsInFolder : Terrasoft.Configuration.SysSettingsInFolder
	{

		#region Constructors: Public

		public SysSettingsInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettingsInFolder(Terrasoft.Configuration.SysSettingsInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

