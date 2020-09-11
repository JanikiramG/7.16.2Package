namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessMILog

	/// <exclude/>
	public class VwSysProcessMILog : Terrasoft.Configuration.VwSysProcessMILog
	{

		#region Constructors: Public

		public VwSysProcessMILog(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessMILog(Terrasoft.Configuration.VwSysProcessMILog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

