namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSystemUsers

	/// <exclude/>
	public class VwSystemUsers : Terrasoft.Configuration.VwSystemUsers
	{

		#region Constructors: Public

		public VwSystemUsers(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSystemUsers(Terrasoft.Configuration.VwSystemUsers source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

