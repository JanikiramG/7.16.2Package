namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTreatmentprogramfrequency

	/// <exclude/>
	public class UsrTreatmentprogramfrequency : Terrasoft.Configuration.UsrTreatmentprogramfrequency
	{

		#region Constructors: Public

		public UsrTreatmentprogramfrequency(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrTreatmentprogramfrequency(Terrasoft.Configuration.UsrTreatmentprogramfrequency source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTreatmentprograms> UsrTreatmentprogramsCollectionByUsrTreatmentprogramfrequency {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

