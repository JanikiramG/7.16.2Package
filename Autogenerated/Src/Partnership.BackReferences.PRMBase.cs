namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Partnership

	/// <exclude/>
	public class Partnership : Terrasoft.Configuration.Partnership
	{

		#region Constructors: Public

		public Partnership(UserConnection userConnection)
			: base(userConnection) {
		}

		public Partnership(Terrasoft.Configuration.Partnership source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Fund> FundCollectionByPartnership {
			get;
			set;
		}

		public IEnumerable<PartnerParamHistory> PartnerParamHistoryCollectionByPartnership {
			get;
			set;
		}

		public IEnumerable<PartnershipFile> PartnershipFileCollectionByPartnership {
			get;
			set;
		}

		public IEnumerable<PartnershipInFolder> PartnershipInFolderCollectionByPartnership {
			get;
			set;
		}

		public IEnumerable<PartnershipInTag> PartnershipInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<PartnershipParameter> PartnershipParameterCollectionByPartnership {
			get;
			set;
		}

		public IEnumerable<PRMTransaction> PRMTransactionCollectionByPartnership {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

