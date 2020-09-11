namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysCronTriggerState

	/// <exclude/>
	public class SysCronTriggerState : Terrasoft.Configuration.SysCronTriggerState
	{

		#region Constructors: Public

		public SysCronTriggerState(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysCronTriggerState(Terrasoft.Configuration.SysCronTriggerState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

