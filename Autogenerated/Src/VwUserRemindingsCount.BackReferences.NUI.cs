namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwUserRemindingsCount

	/// <exclude/>
	public class VwUserRemindingsCount : Terrasoft.Configuration.VwUserRemindingsCount
	{

		#region Constructors: Public

		public VwUserRemindingsCount(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwUserRemindingsCount(Terrasoft.Configuration.VwUserRemindingsCount source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

