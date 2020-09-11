namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysMsgLib

	/// <exclude/>
	public class SysMsgLib : Terrasoft.Configuration.SysMsgLib
	{

		#region Constructors: Public

		public SysMsgLib(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysMsgLib(Terrasoft.Configuration.SysMsgLib source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysMsgUserSettings> SysMsgUserSettingsCollectionBySysMsgLib {
			get;
			set;
		}

		public IEnumerable<SysMsgUserStateInLib> SysMsgUserStateInLibCollectionBySysMsgLib {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

