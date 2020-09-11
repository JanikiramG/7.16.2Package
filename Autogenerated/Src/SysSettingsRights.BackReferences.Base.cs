namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettingsRights

	/// <exclude/>
	public class SysSettingsRights : Terrasoft.Configuration.SysSettingsRights
	{

		#region Constructors: Public

		public SysSettingsRights(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettingsRights(Terrasoft.Configuration.SysSettingsRights source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

