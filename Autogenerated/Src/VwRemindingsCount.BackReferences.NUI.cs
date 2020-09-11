namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwRemindingsCount

	/// <exclude/>
	public class VwRemindingsCount : Terrasoft.Configuration.VwRemindingsCount
	{

		#region Constructors: Public

		public VwRemindingsCount(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwRemindingsCount(Terrasoft.Configuration.VwRemindingsCount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

