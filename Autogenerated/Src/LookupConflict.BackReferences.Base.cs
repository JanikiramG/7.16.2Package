namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LookupConflict

	/// <exclude/>
	public class LookupConflict : Terrasoft.Configuration.LookupConflict
	{

		#region Constructors: Public

		public LookupConflict(UserConnection userConnection)
			: base(userConnection) {
		}

		public LookupConflict(Terrasoft.Configuration.LookupConflict source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

