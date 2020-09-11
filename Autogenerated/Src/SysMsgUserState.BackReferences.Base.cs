namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgUserState

	/// <exclude/>
	public class SysMsgUserState : Terrasoft.Configuration.SysMsgUserState
	{

		#region Constructors: Public

		public SysMsgUserState(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgUserState(Terrasoft.Configuration.SysMsgUserState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysMsgUserStateInLib> SysMsgUserStateInLibCollectionBySysMsgUserState {
			get;
			set;
		}

		public IEnumerable<SysMsgUserStateReason> SysMsgUserStateReasonCollectionBySysMsgUserState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

