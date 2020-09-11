namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysDashboard

	/// <exclude/>
	public class SysDashboard : Terrasoft.Configuration.SysDashboard
	{

		#region Constructors: Public

		public SysDashboard(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysDashboard(Terrasoft.Configuration.SysDashboard source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

