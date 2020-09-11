namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwAccountDuplicate

	/// <exclude/>
	public class VwAccountDuplicate : Terrasoft.Configuration.VwAccountDuplicate
	{

		#region Constructors: Public

		public VwAccountDuplicate(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwAccountDuplicate(Terrasoft.Configuration.VwAccountDuplicate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

