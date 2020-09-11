namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwContactRelationship

	/// <exclude/>
	public class VwContactRelationship : Terrasoft.Configuration.VwContactRelationship
	{

		#region Constructors: Public

		public VwContactRelationship(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwContactRelationship(Terrasoft.Configuration.VwContactRelationship source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

