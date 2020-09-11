namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessIntermediateEvent

	/// <exclude/>
	public class SysProcessIntermediateEvent : Terrasoft.Configuration.SysProcessIntermediateEvent
	{

		#region Constructors: Public

		public SysProcessIntermediateEvent(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessIntermediateEvent(Terrasoft.Configuration.SysProcessIntermediateEvent source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

