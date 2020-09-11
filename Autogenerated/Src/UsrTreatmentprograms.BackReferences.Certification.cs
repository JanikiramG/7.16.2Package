namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTreatmentprograms

	/// <exclude/>
	public class UsrTreatmentprograms : Terrasoft.Configuration.UsrTreatmentprograms
	{

		#region Constructors: Public

		public UsrTreatmentprograms(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrTreatmentprograms(Terrasoft.Configuration.UsrTreatmentprograms source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTreatmentprogramsFile> UsrTreatmentprogramsFileCollectionByUsrTreatmentprograms {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsInFolder> UsrTreatmentprogramsInFolderCollectionByUsrTreatmentprograms {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentprogramsInTag> UsrTreatmentprogramsInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<UsrTreatmentsessions> UsrTreatmentsessionsCollectionByUsrTreatmentPrograms {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

