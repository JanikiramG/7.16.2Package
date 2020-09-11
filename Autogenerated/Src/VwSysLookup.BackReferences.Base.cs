namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysLookup

	/// <exclude/>
	public class VwSysLookup : Terrasoft.Configuration.VwSysLookup
	{

		#region Constructors: Public

		public VwSysLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysLookup(Terrasoft.Configuration.VwSysLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

