namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaRecordDefRight

	/// <exclude/>
	public class SysEntitySchemaRecordDefRight : Terrasoft.Configuration.SysEntitySchemaRecordDefRight
	{

		#region Constructors: Public

		public SysEntitySchemaRecordDefRight(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaRecordDefRight(Terrasoft.Configuration.SysEntitySchemaRecordDefRight source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

