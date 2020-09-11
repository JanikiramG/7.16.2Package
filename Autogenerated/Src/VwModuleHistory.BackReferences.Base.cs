namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwModuleHistory

	/// <exclude/>
	public class VwModuleHistory : Terrasoft.Configuration.VwModuleHistory
	{

		#region Constructors: Public

		public VwModuleHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwModuleHistory(Terrasoft.Configuration.VwModuleHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

