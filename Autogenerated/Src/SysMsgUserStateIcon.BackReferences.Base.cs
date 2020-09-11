namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgUserStateIcon

	/// <exclude/>
	public class SysMsgUserStateIcon : Terrasoft.Configuration.SysMsgUserStateIcon
	{

		#region Constructors: Public

		public SysMsgUserStateIcon(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgUserStateIcon(Terrasoft.Configuration.SysMsgUserStateIcon source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysMsgUserState> SysMsgUserStateCollectionByIcon {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

