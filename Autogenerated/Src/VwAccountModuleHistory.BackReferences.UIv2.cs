namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwAccountModuleHistory

	/// <exclude/>
	public class VwAccountModuleHistory : Terrasoft.Configuration.VwAccountModuleHistory
	{

		#region Constructors: Public

		public VwAccountModuleHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwAccountModuleHistory(Terrasoft.Configuration.VwAccountModuleHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

