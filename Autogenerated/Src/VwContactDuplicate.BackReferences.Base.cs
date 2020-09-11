namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwContactDuplicate

	/// <exclude/>
	public class VwContactDuplicate : Terrasoft.Configuration.VwContactDuplicate
	{

		#region Constructors: Public

		public VwContactDuplicate(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwContactDuplicate(Terrasoft.Configuration.VwContactDuplicate source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

