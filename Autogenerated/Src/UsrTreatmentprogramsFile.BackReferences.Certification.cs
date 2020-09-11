namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTreatmentprogramsFile

	/// <exclude/>
	public class UsrTreatmentprogramsFile : Terrasoft.Configuration.UsrTreatmentprogramsFile
	{

		#region Constructors: Public

		public UsrTreatmentprogramsFile(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrTreatmentprogramsFile(Terrasoft.Configuration.UsrTreatmentprogramsFile source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

	}

	#endregion

}

