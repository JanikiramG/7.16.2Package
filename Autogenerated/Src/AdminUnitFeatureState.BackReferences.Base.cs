namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: AdminUnitFeatureState

	/// <exclude/>
	public class AdminUnitFeatureState : Terrasoft.Configuration.AdminUnitFeatureState
	{

		#region Constructors: Public

		public AdminUnitFeatureState(UserConnection userConnection)
			: base(userConnection) {
		}

		public AdminUnitFeatureState(Terrasoft.Configuration.AdminUnitFeatureState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

