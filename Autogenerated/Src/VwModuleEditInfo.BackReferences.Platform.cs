namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwModuleEditInfo

	/// <exclude/>
	public class VwModuleEditInfo : Terrasoft.Configuration.VwModuleEditInfo
	{

		#region Constructors: Public

		public VwModuleEditInfo(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwModuleEditInfo(Terrasoft.Configuration.VwModuleEditInfo source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

