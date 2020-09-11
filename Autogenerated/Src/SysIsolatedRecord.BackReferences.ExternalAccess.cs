namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysIsolatedRecord

	/// <exclude/>
	public class SysIsolatedRecord : Terrasoft.Configuration.SysIsolatedRecord
	{

		#region Constructors: Public

		public SysIsolatedRecord(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysIsolatedRecord(Terrasoft.Configuration.SysIsolatedRecord source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

