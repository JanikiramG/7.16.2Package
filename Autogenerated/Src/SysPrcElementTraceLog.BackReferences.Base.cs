namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcElementTraceLog

	/// <exclude/>
	public class SysPrcElementTraceLog : Terrasoft.Configuration.SysPrcElementTraceLog
	{

		#region Constructors: Public

		public SysPrcElementTraceLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcElementTraceLog(Terrasoft.Configuration.SysPrcElementTraceLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

