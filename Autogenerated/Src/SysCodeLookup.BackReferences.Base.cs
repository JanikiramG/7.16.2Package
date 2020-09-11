namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysCodeLookup

	/// <exclude/>
	public class SysCodeLookup : Terrasoft.Configuration.SysCodeLookup
	{

		#region Constructors: Public

		public SysCodeLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysCodeLookup(Terrasoft.Configuration.SysCodeLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

