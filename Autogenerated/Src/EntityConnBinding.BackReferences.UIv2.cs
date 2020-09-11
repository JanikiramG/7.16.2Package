namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EntityConnBinding

	/// <exclude/>
	public class EntityConnBinding : Terrasoft.Configuration.EntityConnBinding
	{

		#region Constructors: Public

		public EntityConnBinding(UserConnection userConnection)
			: base(userConnection) {
		}

		public EntityConnBinding(Terrasoft.Configuration.EntityConnBinding source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

