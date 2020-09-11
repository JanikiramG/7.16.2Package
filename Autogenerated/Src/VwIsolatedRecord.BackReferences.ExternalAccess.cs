namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwIsolatedRecord

	/// <exclude/>
	public class VwIsolatedRecord : Terrasoft.Configuration.VwIsolatedRecord
	{

		#region Constructors: Public

		public VwIsolatedRecord(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwIsolatedRecord(Terrasoft.Configuration.VwIsolatedRecord source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

