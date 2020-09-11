namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysProcessStatus

	/// <exclude/>
	public class SysProcessStatus : Terrasoft.Configuration.SysProcessStatus
	{

		#region Constructors: Public

		public SysProcessStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysProcessStatus(Terrasoft.Configuration.SysProcessStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPrcElHistoryLog> SysPrcElHistoryLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<SysProcessElementLog> SysProcessElementLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<VwSysProcessElementLog> VwSysProcessElementLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionByStatus {
			get;
			set;
		}

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

