namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSspAdminUnit

	/// <exclude/>
	public class VwSspAdminUnit : Terrasoft.Configuration.VwSspAdminUnit
	{

		#region Constructors: Public

		public VwSspAdminUnit(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSspAdminUnit(Terrasoft.Configuration.VwSspAdminUnit source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionByParentRole {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

