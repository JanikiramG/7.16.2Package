namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SyncErrorHandler

	/// <exclude/>
	public class SyncErrorHandler : Terrasoft.Configuration.SyncErrorHandler
	{

		#region Constructors: Public

		public SyncErrorHandler(UserConnection userConnection)
			: base(userConnection) {
		}

		public SyncErrorHandler(Terrasoft.Configuration.SyncErrorHandler source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

