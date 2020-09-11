namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLookupSearchColumn

	/// <exclude/>
	public class SysLookupSearchColumn : Terrasoft.Configuration.SysLookupSearchColumn
	{

		#region Constructors: Public

		public SysLookupSearchColumn(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLookupSearchColumn(Terrasoft.Configuration.SysLookupSearchColumn source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

