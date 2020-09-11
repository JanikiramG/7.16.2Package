namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessElementLog

	/// <exclude/>
	public class SysProcessElementLog : Terrasoft.Configuration.SysProcessElementLog
	{

		#region Constructors: Public

		public SysProcessElementLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessElementLog(Terrasoft.Configuration.SysProcessElementLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPrcElementTraceLog> SysPrcElementTraceLogCollectionBySysProcessElementLog {
			get;
			set;
		}

		public IEnumerable<SysPrcElMIHistoryLog> SysPrcElMIHistoryLogCollectionByIteratorElement {
			get;
			set;
		}

		public IEnumerable<SysPrcElMILog> SysPrcElMILogCollectionByIteratorElement {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

