namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgUserStateInLib

	/// <exclude/>
	public class SysMsgUserStateInLib : Terrasoft.Configuration.SysMsgUserStateInLib
	{

		#region Constructors: Public

		public SysMsgUserStateInLib(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgUserStateInLib(Terrasoft.Configuration.SysMsgUserStateInLib source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

