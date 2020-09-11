namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SysLookupColumn

	/// <exclude/>
	public class SysLookupColumn : Terrasoft.Configuration.SysLookupColumn
	{

		#region Constructors: Public

		public SysLookupColumn(UserConnection userConnection)
			: base(userConnection) {
		}

		public SysLookupColumn(Terrasoft.Configuration.SysLookupColumn source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

