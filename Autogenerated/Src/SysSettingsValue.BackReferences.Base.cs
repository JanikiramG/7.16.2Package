namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSettingsValue

	/// <exclude/>
	public class SysSettingsValue : Terrasoft.Configuration.SysSettingsValue
	{

		#region Constructors: Public

		public SysSettingsValue(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSettingsValue(Terrasoft.Configuration.SysSettingsValue source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

