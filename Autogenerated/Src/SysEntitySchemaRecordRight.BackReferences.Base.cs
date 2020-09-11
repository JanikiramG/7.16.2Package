namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaRecordRight

	/// <exclude/>
	public class SysEntitySchemaRecordRight : Terrasoft.Configuration.SysEntitySchemaRecordRight
	{

		#region Constructors: Public

		public SysEntitySchemaRecordRight(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaRecordRight(Terrasoft.Configuration.SysEntitySchemaRecordRight source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

