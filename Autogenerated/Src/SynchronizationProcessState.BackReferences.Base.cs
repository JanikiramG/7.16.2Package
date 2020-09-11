namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SynchronizationProcessState

	/// <exclude/>
	public class SynchronizationProcessState : Terrasoft.Configuration.SynchronizationProcessState
	{

		#region Constructors: Public

		public SynchronizationProcessState(UserConnection userConnection)
			: base(userConnection) {
		}

		public SynchronizationProcessState(Terrasoft.Configuration.SynchronizationProcessState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

