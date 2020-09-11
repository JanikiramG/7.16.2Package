namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysLookupInFolder

	/// <exclude/>
	public class VwSysLookupInFolder : Terrasoft.Configuration.VwSysLookupInFolder
	{

		#region Constructors: Public

		public VwSysLookupInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysLookupInFolder(Terrasoft.Configuration.VwSysLookupInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

