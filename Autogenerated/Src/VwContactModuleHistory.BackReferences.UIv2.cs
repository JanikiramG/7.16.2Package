namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwContactModuleHistory

	/// <exclude/>
	public class VwContactModuleHistory : Terrasoft.Configuration.VwContactModuleHistory
	{

		#region Constructors: Public

		public VwContactModuleHistory(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwContactModuleHistory(Terrasoft.Configuration.VwContactModuleHistory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

