namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTreatmentprogramsTag

	/// <exclude/>
	public class UsrTreatmentprogramsTag : Terrasoft.Configuration.UsrTreatmentprogramsTag
	{

		#region Constructors: Public

		public UsrTreatmentprogramsTag(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrTreatmentprogramsTag(Terrasoft.Configuration.UsrTreatmentprogramsTag source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTreatmentprogramsInTag> UsrTreatmentprogramsInTagCollectionByTag {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

