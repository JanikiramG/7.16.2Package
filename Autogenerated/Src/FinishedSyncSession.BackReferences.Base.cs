namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: FinishedSyncSession

	/// <exclude/>
	public class FinishedSyncSession : Terrasoft.Configuration.FinishedSyncSession
	{

		#region Constructors: Public

		public FinishedSyncSession(UserConnection userConnection)
			: base(userConnection) {
		}

		public FinishedSyncSession(Terrasoft.Configuration.FinishedSyncSession source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

