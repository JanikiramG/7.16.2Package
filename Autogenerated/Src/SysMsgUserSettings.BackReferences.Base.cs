namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgUserSettings

	/// <exclude/>
	public class SysMsgUserSettings : Terrasoft.Configuration.SysMsgUserSettings
	{

		#region Constructors: Public

		public SysMsgUserSettings(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgUserSettings(Terrasoft.Configuration.SysMsgUserSettings source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

