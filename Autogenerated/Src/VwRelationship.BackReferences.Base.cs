namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwRelationship

	/// <exclude/>
	public class VwRelationship : Terrasoft.Configuration.VwRelationship
	{

		#region Constructors: Public

		public VwRelationship(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwRelationship(Terrasoft.Configuration.VwRelationship source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

