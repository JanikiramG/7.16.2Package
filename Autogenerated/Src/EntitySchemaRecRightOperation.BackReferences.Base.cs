namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntitySchemaRecRightOperation

	/// <exclude/>
	public class EntitySchemaRecRightOperation : Terrasoft.Configuration.EntitySchemaRecRightOperation
	{

		#region Constructors: Public

		public EntitySchemaRecRightOperation(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntitySchemaRecRightOperation(Terrasoft.Configuration.EntitySchemaRecRightOperation source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

