namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntitySchemaRecRightSource

	/// <exclude/>
	public class SysEntitySchemaRecRightSource : Terrasoft.Configuration.SysEntitySchemaRecRightSource
	{

		#region Constructors: Public

		public SysEntitySchemaRecRightSource(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntitySchemaRecRightSource(Terrasoft.Configuration.SysEntitySchemaRecRightSource source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

