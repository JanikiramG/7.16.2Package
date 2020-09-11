namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrSessionstatus

	/// <exclude/>
	public class UsrSessionstatus : Terrasoft.Configuration.UsrSessionstatus
	{

		#region Constructors: Public

		public UsrSessionstatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public UsrSessionstatus(Terrasoft.Configuration.UsrSessionstatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTreatmentsessions> UsrTreatmentsessionsCollectionByUsrSessionstatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

