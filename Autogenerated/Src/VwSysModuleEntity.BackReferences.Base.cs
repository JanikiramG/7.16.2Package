namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwSysModuleEntity

	/// <exclude/>
	public class VwSysModuleEntity : Terrasoft.Configuration.VwSysModuleEntity
	{

		#region Constructors: Public

		public VwSysModuleEntity(UserConnection userConnection)
			: base(userConnection) {
		}

		public VwSysModuleEntity(Terrasoft.Configuration.VwSysModuleEntity source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Reminding> RemindingCollectionByLoader {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionBySysEntitySchema {
			get;
			set;
		}

		public IEnumerable<ScoringModel> ScoringModelCollectionByScoringObject {
			get;
			set;
		}

		public IEnumerable<VwAccountModuleHistory> VwAccountModuleHistoryCollectionBySysEntity {
			get;
			set;
		}

		public IEnumerable<VwContactModuleHistory> VwContactModuleHistoryCollectionBySysEntity {
			get;
			set;
		}

		public IEnumerable<VwModuleHistory> VwModuleHistoryCollectionBySysEntity {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

