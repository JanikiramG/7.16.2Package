namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicatesReference

	/// <exclude/>
	public class DuplicatesReference : Terrasoft.Configuration.DuplicatesReference
	{

		#region Constructors: Public

		public DuplicatesReference(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicatesReference(Terrasoft.Configuration.DuplicatesReference source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

