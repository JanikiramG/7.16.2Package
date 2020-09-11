namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Relationship

	/// <exclude/>
	public class Relationship : Terrasoft.Configuration.Relationship
	{

		#region Constructors: Public

		public Relationship(UserConnection userConnection)
			: base(userConnection) {
		}

		public Relationship(Terrasoft.Configuration.Relationship source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

