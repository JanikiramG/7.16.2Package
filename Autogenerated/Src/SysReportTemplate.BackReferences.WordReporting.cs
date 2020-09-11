namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysReportTemplate

	/// <exclude/>
	public class SysReportTemplate : Terrasoft.Configuration.SysReportTemplate
	{

		#region Constructors: Public

		public SysReportTemplate(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysReportTemplate(Terrasoft.Configuration.SysReportTemplate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

