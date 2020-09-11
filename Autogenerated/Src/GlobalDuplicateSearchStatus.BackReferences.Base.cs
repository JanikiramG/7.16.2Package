namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: GlobalDuplicateSearchStatus

	/// <exclude/>
	public class GlobalDuplicateSearchStatus : Terrasoft.Configuration.GlobalDuplicateSearchStatus
	{

		#region Constructors: Public

		public GlobalDuplicateSearchStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public GlobalDuplicateSearchStatus(Terrasoft.Configuration.GlobalDuplicateSearchStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<GlobalDuplicateSearchState> GlobalDuplicateSearchStateCollectionBySearchStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

