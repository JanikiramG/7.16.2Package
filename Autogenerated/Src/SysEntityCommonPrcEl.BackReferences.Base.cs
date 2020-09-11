namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysEntityCommonPrcEl

	/// <exclude/>
	public class SysEntityCommonPrcEl : Terrasoft.Configuration.SysEntityCommonPrcEl
	{

		#region Constructors: Public

		public SysEntityCommonPrcEl(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysEntityCommonPrcEl(Terrasoft.Configuration.SysEntityCommonPrcEl source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

