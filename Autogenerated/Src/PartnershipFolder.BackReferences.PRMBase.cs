namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: PartnershipFolder

	/// <exclude/>
	public class PartnershipFolder : Terrasoft.Configuration.PartnershipFolder
	{

		#region Constructors: Public

		public PartnershipFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public PartnershipFolder(Terrasoft.Configuration.PartnershipFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PartnershipFolder> PartnershipFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<PartnershipInFolder> PartnershipInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

