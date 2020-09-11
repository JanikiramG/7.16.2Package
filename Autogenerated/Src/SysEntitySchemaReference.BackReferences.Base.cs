namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaReference

	/// <exclude/>
	public class SysEntitySchemaReference : Terrasoft.Configuration.SysEntitySchemaReference
	{

		#region Constructors: Public

		public SysEntitySchemaReference(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaReference(Terrasoft.Configuration.SysEntitySchemaReference source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

