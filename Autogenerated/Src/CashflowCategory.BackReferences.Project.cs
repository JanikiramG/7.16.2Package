namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CashflowCategory

	/// <exclude/>
	public class CashflowCategory : Terrasoft.Configuration.CashflowCategory
	{

		#region Constructors: Public

		public CashflowCategory(UserConnection userConnection)
			: base(userConnection) {
		}

		public CashflowCategory(Terrasoft.Configuration.CashflowCategory source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Cashflow> CashflowCollectionByCategory {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

