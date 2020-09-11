namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntityTypeLookup

	/// <exclude/>
	public class EntityTypeLookup : Terrasoft.Configuration.EntityTypeLookup
	{

		#region Constructors: Public

		public EntityTypeLookup(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntityTypeLookup(Terrasoft.Configuration.EntityTypeLookup source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

