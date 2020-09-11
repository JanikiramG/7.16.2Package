namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysStoringObjectState

	/// <exclude/>
	public class SysStoringObjectState : Terrasoft.Configuration.SysStoringObjectState
	{

		#region Constructors: Public

		public SysStoringObjectState(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysStoringObjectState(Terrasoft.Configuration.SysStoringObjectState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysGridPageView> SysGridPageViewCollectionBySysStoringState {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

