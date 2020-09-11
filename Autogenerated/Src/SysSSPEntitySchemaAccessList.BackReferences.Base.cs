namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSSPEntitySchemaAccessList

	/// <exclude/>
	public class SysSSPEntitySchemaAccessList : Terrasoft.Configuration.SysSSPEntitySchemaAccessList
	{

		#region Constructors: Public

		public SysSSPEntitySchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSSPEntitySchemaAccessList(Terrasoft.Configuration.SysSSPEntitySchemaAccessList source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

