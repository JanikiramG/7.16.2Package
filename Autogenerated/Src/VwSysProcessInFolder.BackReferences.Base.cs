namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysProcessInFolder

	/// <exclude/>
	public class VwSysProcessInFolder : Terrasoft.Configuration.VwSysProcessInFolder
	{

		#region Constructors: Public

		public VwSysProcessInFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysProcessInFolder(Terrasoft.Configuration.VwSysProcessInFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

