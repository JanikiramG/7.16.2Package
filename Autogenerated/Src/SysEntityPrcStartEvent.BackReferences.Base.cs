namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntityPrcStartEvent

	/// <exclude/>
	public class SysEntityPrcStartEvent : Terrasoft.Configuration.SysEntityPrcStartEvent
	{

		#region Constructors: Public

		public SysEntityPrcStartEvent(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntityPrcStartEvent(Terrasoft.Configuration.SysEntityPrcStartEvent source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

