namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwAccountRelationship

	/// <exclude/>
	public class VwAccountRelationship : Terrasoft.Configuration.VwAccountRelationship
	{

		#region Constructors: Public

		public VwAccountRelationship(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwAccountRelationship(Terrasoft.Configuration.VwAccountRelationship source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

