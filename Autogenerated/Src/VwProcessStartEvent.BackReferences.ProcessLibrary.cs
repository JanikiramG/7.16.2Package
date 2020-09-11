namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessStartEvent

	/// <exclude/>
	public class VwProcessStartEvent : Terrasoft.Configuration.VwProcessStartEvent
	{

		#region Constructors: Public

		public VwProcessStartEvent(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessStartEvent(Terrasoft.Configuration.VwProcessStartEvent source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

