namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GlobalDuplicateSearchState

	/// <exclude/>
	public class GlobalDuplicateSearchState : Terrasoft.Configuration.GlobalDuplicateSearchState
	{

		#region Constructors: Public

		public GlobalDuplicateSearchState(UserConnection userConnection)
			: base(userConnection) {
		}

		public GlobalDuplicateSearchState(Terrasoft.Configuration.GlobalDuplicateSearchState source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

