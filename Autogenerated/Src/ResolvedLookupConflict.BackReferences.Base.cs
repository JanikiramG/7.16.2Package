namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ResolvedLookupConflict

	/// <exclude/>
	public class ResolvedLookupConflict : Terrasoft.Configuration.ResolvedLookupConflict
	{

		#region Constructors: Public

		public ResolvedLookupConflict(UserConnection userConnection)
			: base(userConnection) {
		}

		public ResolvedLookupConflict(Terrasoft.Configuration.ResolvedLookupConflict source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

