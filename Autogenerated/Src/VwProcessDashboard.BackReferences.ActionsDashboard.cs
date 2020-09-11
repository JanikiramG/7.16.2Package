namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwProcessDashboard

	/// <exclude/>
	public class VwProcessDashboard : Terrasoft.Configuration.VwProcessDashboard
	{

		#region Constructors: Public

		public VwProcessDashboard(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwProcessDashboard(Terrasoft.Configuration.VwProcessDashboard source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

