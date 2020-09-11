namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcHistoryLog

	/// <exclude/>
	public class SysPrcHistoryLog : Terrasoft.Configuration.SysPrcHistoryLog
	{

		#region Constructors: Public

		public SysPrcHistoryLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcHistoryLog(Terrasoft.Configuration.SysPrcHistoryLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPrcElHistoryLog> SysPrcElHistoryLogCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<SysPrcEntityHistory> SysPrcEntityHistoryCollectionBySysProcess {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionByParent {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

