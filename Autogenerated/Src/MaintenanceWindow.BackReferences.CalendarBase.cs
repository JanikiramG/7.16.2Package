namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MaintenanceWindow

	/// <exclude/>
	public class MaintenanceWindow : Terrasoft.Configuration.MaintenanceWindow
	{

		#region Constructors: Public

		public MaintenanceWindow(UserConnection userConnection)
			: base(userConnection) {
		}

		public MaintenanceWindow(Terrasoft.Configuration.MaintenanceWindow source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

