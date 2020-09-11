namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgUserStateReason

	/// <exclude/>
	public class SysMsgUserStateReason : Terrasoft.Configuration.SysMsgUserStateReason
	{

		#region Constructors: Public

		public SysMsgUserStateReason(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgUserStateReason(Terrasoft.Configuration.SysMsgUserStateReason source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

