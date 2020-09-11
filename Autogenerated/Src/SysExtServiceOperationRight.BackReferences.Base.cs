namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysExtServiceOperationRight

	/// <exclude/>
	public class SysExtServiceOperationRight : Terrasoft.Configuration.SysExtServiceOperationRight
	{

		#region Constructors: Public

		public SysExtServiceOperationRight(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysExtServiceOperationRight(Terrasoft.Configuration.SysExtServiceOperationRight source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

