namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysWidgetDashboard

	/// <exclude/>
	public class SysWidgetDashboard : Terrasoft.Configuration.SysWidgetDashboard
	{

		#region Constructors: Public

		public SysWidgetDashboard(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysWidgetDashboard(Terrasoft.Configuration.SysWidgetDashboard source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

