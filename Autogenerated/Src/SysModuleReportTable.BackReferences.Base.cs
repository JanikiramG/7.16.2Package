namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysModuleReportTable

	/// <exclude/>
	public class SysModuleReportTable : Terrasoft.Configuration.SysModuleReportTable
	{

		#region Constructors: Public

		public SysModuleReportTable(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysModuleReportTable(Terrasoft.Configuration.SysModuleReportTable source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

