namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CashflowType

	/// <exclude/>
	public class CashflowType : Terrasoft.Configuration.CashflowType
	{

		#region Constructors: Public

		public CashflowType(UserConnection userConnection)
			: base(userConnection) {
		}

		public CashflowType(Terrasoft.Configuration.CashflowType source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Cashflow> CashflowCollectionByType {
			get;
			set;
		}

		public IEnumerable<CashflowCategory> CashflowCategoryCollectionByCashflowType {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

