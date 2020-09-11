namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysPrcElHistoryLog

	/// <exclude/>
	public class SysPrcElHistoryLog : Terrasoft.Configuration.SysPrcElHistoryLog
	{

		#region Constructors: Public

		public SysPrcElHistoryLog(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysPrcElHistoryLog(Terrasoft.Configuration.SysPrcElHistoryLog source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

