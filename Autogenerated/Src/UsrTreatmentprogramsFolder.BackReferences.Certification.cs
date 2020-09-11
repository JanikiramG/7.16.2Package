namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTreatmentprogramsFolder

	/// <exclude/>
	public class UsrTreatmentprogramsFolder : Terrasoft.Configuration.UsrTreatmentprogramsFolder
	{

		#region Constructors: Public

		public UsrTreatmentprogramsFolder(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrTreatmentprogramsFolder(Terrasoft.Configuration.UsrTreatmentprogramsFolder source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTreatmentprogramsFolder> UsrTreatmentprogramsFolderCollectionByParent {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsInFolder> UsrTreatmentprogramsInFolderCollectionByFolder {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

