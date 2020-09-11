namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaOperationRight

	/// <exclude/>
	public class SysEntitySchemaOperationRight : Terrasoft.Configuration.SysEntitySchemaOperationRight
	{

		#region Constructors: Public

		public SysEntitySchemaOperationRight(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaOperationRight(Terrasoft.Configuration.SysEntitySchemaOperationRight source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

