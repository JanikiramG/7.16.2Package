namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: DuplicateStatus

	/// <exclude/>
	public class DuplicateStatus : Terrasoft.Configuration.DuplicateStatus
	{

		#region Constructors: Public

		public DuplicateStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public DuplicateStatus(Terrasoft.Configuration.DuplicateStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountDuplicate> AccountDuplicateCollectionByStatusOfDuplicate {
			get;
			set;
		}

		public IEnumerable<ContactDuplicate> ContactDuplicateCollectionByStatusOfDuplicate {
			get;
			set;
		}

		public IEnumerable<VwAccountDuplicate> VwAccountDuplicateCollectionByStatusOfDuplicate {
			get;
			set;
		}

		public IEnumerable<VwContactDuplicate> VwContactDuplicateCollectionByStatusOfDuplicate {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

