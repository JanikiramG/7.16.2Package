namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysSSPEntitySchemaAccessList

	/// <exclude/>
	public class VwSysSSPEntitySchemaAccessList : Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList
	{

		#region Constructors: Public

		public VwSysSSPEntitySchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysSSPEntitySchemaAccessList(Terrasoft.Configuration.VwSysSSPEntitySchemaAccessList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

