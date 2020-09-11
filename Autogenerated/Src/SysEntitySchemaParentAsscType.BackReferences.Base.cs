namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaParentAsscType

	/// <exclude/>
	public class SysEntitySchemaParentAsscType : Terrasoft.Configuration.SysEntitySchemaParentAsscType
	{

		#region Constructors: Public

		public SysEntitySchemaParentAsscType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaParentAsscType(Terrasoft.Configuration.SysEntitySchemaParentAsscType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

