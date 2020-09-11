namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysSchemaProperty

	/// <exclude/>
	public class SysSchemaProperty : Terrasoft.Configuration.SysSchemaProperty
	{

		#region Constructors: Public

		public SysSchemaProperty(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysSchemaProperty(Terrasoft.Configuration.SysSchemaProperty source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

