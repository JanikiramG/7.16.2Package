namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LeadFolder

	/// <exclude/>
	public class LeadFolder : Terrasoft.Configuration.LeadFolder
	{

		#region Constructors: Public

		public LeadFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public LeadFolder(Terrasoft.Configuration.LeadFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<LeadFolder> LeadFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<LeadInFolder> LeadInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

