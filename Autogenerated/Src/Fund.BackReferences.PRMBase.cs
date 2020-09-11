namespace Terrasoft.Configuration.OData
{

	using System.Collections.Generic;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Fund

	/// <exclude/>
	public class Fund : Terrasoft.Configuration.Fund
	{

		#region Constructors: Public

		public Fund(UserConnection userConnection)
			: base(userConnection) {
		}

		public Fund(Terrasoft.Configuration.Fund source)
			: base(source) {
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<PRMTransaction> PRMTransactionCollectionByFund {
			get;
			set;
		}

		#endregion

	}

	#endregion

}

