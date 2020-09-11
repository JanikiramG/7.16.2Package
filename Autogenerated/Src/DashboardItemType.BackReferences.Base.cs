namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DashboardItemType

	/// <exclude/>
	public class DashboardItemType : Terrasoft.Configuration.DashboardItemType
	{

		#region Constructors: Public

		public DashboardItemType(UserConnection userConnection)
			: base(userConnection) {
		}

		public DashboardItemType(Terrasoft.Configuration.DashboardItemType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

