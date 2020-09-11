namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CashflowStatus

	/// <exclude/>
	public class CashflowStatus : Terrasoft.Configuration.CashflowStatus
	{

		#region Constructors: Public

		public CashflowStatus(UserConnection userConnection)
			: base(userConnection) {
		}

		public CashflowStatus(Terrasoft.Configuration.CashflowStatus source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Cashflow> CashflowCollectionByStatus {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

