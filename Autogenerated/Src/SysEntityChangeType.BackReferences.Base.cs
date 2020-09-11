namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntityChangeType

	/// <exclude/>
	public class SysEntityChangeType : Terrasoft.Configuration.SysEntityChangeType
	{

		#region Constructors: Public

		public SysEntityChangeType(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntityChangeType(Terrasoft.Configuration.SysEntityChangeType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

